using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using ModuleProjectWizard.Dialogs;
using ModuleProjectWizard.Models;

namespace ModuleProjectWizard
{
    public class WizardImplementation : IWizard
    {
        private readonly ModuleInfo _moduleInfo = new ModuleInfo();
        private readonly PluginInfo _pluginInfo = new PluginInfo {Guid = Guid.NewGuid()};
        private ModuleInfoDialog _moduleInfoDialog;
        private PluginInfoDialog _pluginInfoDialog;

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _pluginInfo.Name = replacementsDictionary["$specifiedsolutionname$"];
            _pluginInfo.Description = "This is my awesome plugin";
            _pluginInfo.Icon = "ToyBrickPlus";

            _pluginInfoDialog = new PluginInfoDialog(_pluginInfo);
            var pluginInfoDialogCompleted = _pluginInfoDialog.ShowModal();
            if (pluginInfoDialogCompleted == false)
                throw new WizardCancelledException();

            _moduleInfo.Name = _pluginInfo.Name;
            _moduleInfo.Icon = _pluginInfo.Icon;

            _moduleInfoDialog = new ModuleInfoDialog(_moduleInfo);
            var moduleInfoDialogCompleted = _moduleInfoDialog.ShowModal();
            if (moduleInfoDialogCompleted == false)
                RunStarted(automationObject, replacementsDictionary, runKind, customParams);

            ApplyInfo(replacementsDictionary);
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            if (filePath == "DataModels")
                return _moduleInfo.EnableDataModel;
            if (filePath == "ViewModels" || filePath == "Views")
                return _moduleInfo.IncludeCustomTab;
            return true;
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        private void ApplyInfo(Dictionary<string, string> replacementsDictionary)
        {
            // Paths
            replacementsDictionary.Add("$ArtemisDirectory$", _pluginInfo.ArtemisDirectory);
            replacementsDictionary.Add("$ArtemisDirectoryEscaped$", _pluginInfo.ArtemisDirectory.Replace("\\", "\\\\"));

            // Nuget package versions
            replacementsDictionary.Add("$MaterialDesignThemesVersion$", GetNugetFileVersion("MaterialDesignThemes.Wpf.dll"));
            replacementsDictionary.Add("$SkiaSharpVersion$", GetNugetFileVersion("SkiaSharp.dll"));
            replacementsDictionary.Add("$StyletVersion$", GetNugetFileVersion("Stylet.dll"));

            // Plugin info
            replacementsDictionary.Add("$PluginGuid$", _pluginInfo.Guid.ToString());
            replacementsDictionary.Add("$PluginName$", _pluginInfo.Name);
            replacementsDictionary.Add("$PluginDescription$", _pluginInfo.Description);
            if (_pluginInfo.Icon != null)
                replacementsDictionary.Add("$PluginIcon$", _pluginInfo.Icon);

            // Module info
            if (_moduleInfo.EnableProfiles)
                replacementsDictionary.Add("$BaseClass$", _moduleInfo.EnableDataModel ? "ProfileModule<PluginDataModel>" : "ProfileModule");
            else
                replacementsDictionary.Add("$BaseClass$", _moduleInfo.EnableDataModel ? "Module<PluginDataModel>" : "Module");

            replacementsDictionary.Add("$ModuleName$", _moduleInfo.Name);
            replacementsDictionary.Add("$ModuleIcon$", _moduleInfo.Icon);
            replacementsDictionary.Add("$ModuleCategory$", _moduleInfo.PriorityCategory);

            replacementsDictionary.Add("$EnableProfiles$", _moduleInfo.EnableProfiles.ToString());
            replacementsDictionary.Add("$EnableDataModel$", _moduleInfo.EnableDataModel.ToString());
            replacementsDictionary.Add("$IncludeCustomTab$", _moduleInfo.IncludeCustomTab.ToString());
        }

        private string GetNugetFileVersion(string file)
        {
            var fileVersion = FileVersionInfo.GetVersionInfo(Path.Combine(_pluginInfo.ArtemisDirectory, file)).FileVersion;
            // Only take the first three parts of the version
            return string.Join(".", fileVersion.Split('.').Take(3));
        }
    }
}