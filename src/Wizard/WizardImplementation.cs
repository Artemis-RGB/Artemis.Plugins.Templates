using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ArtemisPluginTemplates.Dialogs;
using ArtemisPluginTemplates.Models;
using ArtemisPluginTemplates.PluginTypes;
using ArtemisPluginTemplates.PluginTypes.Device;
using ArtemisPluginTemplates.PluginTypes.LayerBrush;
using ArtemisPluginTemplates.PluginTypes.LayerEffect;
using ArtemisPluginTemplates.PluginTypes.Module;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace ArtemisPluginTemplates
{
    public class WizardImplementation : IWizard
    {
        private readonly PluginInfo _pluginInfo = new PluginInfo
        {
            Guid = Guid.NewGuid(),
            Author = Environment.UserName
        };
        private IPluginType _pluginType;

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            GatherPluginInfo(replacementsDictionary, customParams);
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return _pluginType.ShouldAddProjectItem(filePath);
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void GatherPluginInfo(Dictionary<string, string> replacementsDictionary, object[] customParams)
        {
            var destination = replacementsDictionary["$destinationdirectory$"];

            _pluginInfo.Name = replacementsDictionary["$specifiedsolutionname$"];
            _pluginInfo.Description = "This is my awesome plugin";
            _pluginInfo.Icon = "ToyBrickPlus";

            var pluginInfoDialog = new PluginInfoDialog(_pluginInfo);
            var pluginInfoDialogCompleted = pluginInfoDialog.ShowModal();
            if (pluginInfoDialogCompleted == false)
                throw new WizardCancelledException();

            // Paths
            replacementsDictionary["$ArtemisDirectory$"] = GetRelativePath(_pluginInfo.ArtemisDirectory, destination);
            replacementsDictionary["$ArtemisDirectoryEscaped$"] = GetRelativePath(_pluginInfo.ArtemisDirectory, destination).Replace("\\", "\\\\");

            // Nuget package versions
            replacementsDictionary["$MaterialDesignThemesVersion$"] = GetNugetFileVersion("MaterialDesignThemes.Wpf.dll");
            replacementsDictionary["$MaterialDesignExtensionsVersion$"] = GetNugetFileVersion("MaterialDesignExtensions.dll");
            replacementsDictionary["$FluentValidationVersion$"] = GetNugetFileVersion("FluentValidation.dll");
            replacementsDictionary["$SkiaSharpVersion$"] = GetNugetFileVersion("SkiaSharp.dll");
            replacementsDictionary["$StyletVersion$"] = GetNugetFileVersion("Stylet.dll");

            // Plugin info
            replacementsDictionary["$PluginGuid$"] = _pluginInfo.Guid.ToString();
            replacementsDictionary["$PluginName$"] = _pluginInfo.Name;
            replacementsDictionary["$PluginDescription$"] = _pluginInfo.Description;
            replacementsDictionary["$PluginAuthor$"] = _pluginInfo.Author;
            replacementsDictionary["$PluginWebsite$"] = _pluginInfo.Website != null ? $"\"{_pluginInfo.Website}\"" : "null";
            replacementsDictionary["$PluginRepository$"] = _pluginInfo.Repository != null ? $"\"{_pluginInfo.Repository}\"" : "null";
            if (_pluginInfo.Icon != null)
                replacementsDictionary["$PluginIcon$"] = _pluginInfo.Icon;

            // customParams contains the path to the template
            if (customParams.Any(p => p.ToString().Contains("Module")))
                _pluginType = new ModulePluginType(this, replacementsDictionary, customParams, _pluginInfo);
            else if (customParams.Any(p => p.ToString().Contains("Layer Brush")))
                _pluginType = new LayerBrushType(this, replacementsDictionary, customParams, _pluginInfo);
            else if (customParams.Any(p => p.ToString().Contains("Layer Effect")))
                _pluginType = new LayerEffectType(this, replacementsDictionary, customParams, _pluginInfo);
            else if (customParams.Any(p => p.ToString().Contains("Device")))
                _pluginType = new DeviceType(replacementsDictionary);
            else
                throw new Exception("Couldn't detect a plugin type based on the template that was selected.");

            _pluginType.GatherInfo();
        }

        private string GetNugetFileVersion(string file)
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Path.Combine(_pluginInfo.ArtemisDirectory, file)).FileVersion;
            // Only take the first three parts of the version
            return string.Join(".", fileVersion.Split('.').Take(3));
        }

        /// <summary>
        /// Returns a relative path string from a full path based on a base path
        /// provided.
        /// </summary>
        /// <param name="fullPath">The path to convert. Can be either a file or a directory</param>
        /// <param name="basePath">The base path on which relative processing is based. Should be a directory.</param>
        /// <returns>
        /// String of the relative path.
        /// 
        /// Examples of returned values:
        ///  test.txt, ..\test.txt, ..\..\..\test.txt, ., .., subdir\test.txt
        /// </returns>
        private static string GetRelativePath(string fullPath, string basePath)
        {
            // Require trailing backslash for path
            if (!basePath.EndsWith("\\"))
                basePath += "\\";

            Uri baseUri = new Uri(basePath);
            Uri fullUri = new Uri(fullPath);

            Uri relativeUri = baseUri.MakeRelativeUri(fullUri);

            // Uri's use forward slashes so convert back to backward slashes
            return relativeUri.ToString().Replace("/", "\\");

        }
    }
}