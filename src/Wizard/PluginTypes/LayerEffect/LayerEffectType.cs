using System.Collections.Generic;
using ArtemisPluginTemplates.Models;

namespace ArtemisPluginTemplates.PluginTypes.LayerEffect
{
    internal class LayerEffectType : IPluginType
    {
        private readonly PluginInfo _pluginInfo;
        private readonly Dictionary<string, string> _replacementsDictionary;
        private readonly object[] _customParams;
        private readonly WizardImplementation _wizard;
        private readonly LayerEffectInfo _layerEffectInfo;

        public LayerEffectType(WizardImplementation wizard, Dictionary<string, string> replacementsDictionary, object[] customParams, PluginInfo pluginInfo)
        {
            _wizard = wizard;
            _replacementsDictionary = replacementsDictionary;
            _customParams = customParams;
            _pluginInfo = pluginInfo;
            _layerEffectInfo = new LayerEffectInfo();
        }

        public void GatherInfo()
        {
            _layerEffectInfo.Name = _pluginInfo.Name;
            _layerEffectInfo.Icon = _pluginInfo.Icon;

            var moduleInfoDialog = new LayerEffectInfoDialog(_layerEffectInfo);
            var moduleInfoDialogCompleted = moduleInfoDialog.ShowModal();
            if (moduleInfoDialogCompleted == false)
            {
                _wizard.GatherPluginInfo(_replacementsDictionary, _customParams);
                return;
            }

            _replacementsDictionary["$LayerEffectName$"] = _layerEffectInfo.Name;
            _replacementsDictionary["$LayerEffectIcon$"] = _layerEffectInfo.Icon;
            _replacementsDictionary["$LayerEffectDescription$"] = _layerEffectInfo.Description;

            _replacementsDictionary["$IncludeConfigurationWindow$"] = _layerEffectInfo.IncludeCustomDialog.ToString();
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            if (filePath == "ViewModels" || filePath == "Views")
                return _layerEffectInfo.IncludeCustomDialog;

            return true;
        }
    }
}