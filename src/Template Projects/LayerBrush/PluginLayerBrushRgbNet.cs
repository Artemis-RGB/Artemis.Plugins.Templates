using Artemis.Core.LayerBrushes;
using RGB.NET.Brushes;
using RGB.NET.Core;
using $safeprojectname$.PropertyGroups;
$if$ ($IncludeConfigurationWindow$ == True)using $safeprojectname$.ViewModels;$endif$

namespace $safeprojectname$
{
    // This is the layer brush, the plugin feature has provided it to Artemis via a descriptor
    // Artemis may create multiple instances of it, one instance for each profile element (folder/layer) it is applied to
    public class PluginLayerBrush : RgbNetLayerBrush<MainPropertyGroup>
    {
        public override void EnableLayerBrush()
        {
        $if$ ($IncludeConfigurationWindow$ == True)ConfigurationDialog = new LayerBrushConfigurationDialog<CustomViewModel>();$endif$
        }

        public override void DisableLayerBrush()
        {
        }

        public override void Update(double deltaTime)
        {
        }

        public override IBrush GetBrush()
        {
            // Return an RGB.NET IBrush here
			// You can implement your own or use one of the built-in types provided in RGB.NET.Brushes
            return new SolidColorBrush(new Color(255, 0, 0));
        }
    }
}