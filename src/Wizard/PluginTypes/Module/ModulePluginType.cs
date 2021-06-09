using System.Collections.Generic;
using ArtemisPluginTemplates.Models;

namespace ArtemisPluginTemplates.PluginTypes.Module
{
    internal class ModulePluginType : IPluginType
    {
        private readonly PluginInfo _pluginInfo;
        private readonly Dictionary<string, string> _replacementsDictionary;
        private readonly object[] _customParams;
        private readonly WizardImplementation _wizard;
        private readonly ModuleInfo _moduleInfo;

        public ModulePluginType(WizardImplementation wizard, Dictionary<string, string> replacementsDictionary, object[] customParams, PluginInfo pluginInfo)
        {
            _wizard = wizard;
            _replacementsDictionary = replacementsDictionary;
            _customParams = customParams;
            _pluginInfo = pluginInfo;
            _moduleInfo = new ModuleInfo();
        }

        public void GatherInfo()
        {
            _moduleInfo.Name = _pluginInfo.Name;
            _moduleInfo.Icon = _pluginInfo.Icon;

            var moduleInfoDialog = new ModuleInfoDialog(_moduleInfo);
            var moduleInfoDialogCompleted = moduleInfoDialog.ShowModal();
            if (moduleInfoDialogCompleted == false)
            {
                _wizard.GatherPluginInfo(_replacementsDictionary, _customParams);
                return;
            }
            
            _replacementsDictionary["$ModuleName$"] = _moduleInfo.Name;
            _replacementsDictionary["$ModuleIcon$"] = _moduleInfo.Icon;
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}