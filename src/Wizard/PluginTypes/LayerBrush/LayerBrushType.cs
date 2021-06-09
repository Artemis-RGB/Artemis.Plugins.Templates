using System.Collections.Generic;
using ArtemisPluginTemplates.Models;

namespace ArtemisPluginTemplates.PluginTypes.LayerBrush
{
    internal class LayerBrushType : IPluginType
    {
        private readonly PluginInfo _pluginInfo;
        private readonly Dictionary<string, string> _replacementsDictionary;
        private readonly object[] _customParams;
        private readonly WizardImplementation _wizard;
        private readonly LayerBrushInfo _layerBrushInfo;

        public LayerBrushType(WizardImplementation wizard, Dictionary<string, string> replacementsDictionary, object[] customParams, PluginInfo pluginInfo)
        {
            _wizard = wizard;
            _replacementsDictionary = replacementsDictionary;
            _customParams = customParams;
            _pluginInfo = pluginInfo;
            _layerBrushInfo = new LayerBrushInfo();
        }

        public void GatherInfo()
        {
            _layerBrushInfo.Name = _pluginInfo.Name;
            _layerBrushInfo.Icon = _pluginInfo.Icon;

            var moduleInfoDialog = new LayerBrushInfoDialog(_layerBrushInfo);
            var moduleInfoDialogCompleted = moduleInfoDialog.ShowModal();
            if (moduleInfoDialogCompleted == false)
            {
                _wizard.GatherPluginInfo(_replacementsDictionary, _customParams);
                return;
            }

            _replacementsDictionary["$LayerBrushName$"] = _layerBrushInfo.Name;
            _replacementsDictionary["$LayerBrushIcon$"] = _layerBrushInfo.Icon;
            _replacementsDictionary["$LayerBrushDescription$"] = _layerBrushInfo.Description;
            _replacementsDictionary["$LayerBrushRenderType$"] = _layerBrushInfo.RenderType;

            _replacementsDictionary["$IncludeConfigurationWindow$"] = _layerBrushInfo.IncludeCustomDialog.ToString();
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            if (filePath == "ViewModels" || filePath == "Views")
                return _layerBrushInfo.IncludeCustomDialog;
            if (filePath == "PluginLayerBrushRegular.cs")
                return _layerBrushInfo.RenderType == "Regular";
            if (filePath == "PluginLayerBrushPerLed.cs")
                return _layerBrushInfo.RenderType == "PerLed";

            return true;
        }
    }
}