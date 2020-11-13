using Artemis.Core.LayerBrushes;
using SkiaSharp;
using $safeprojectname$.PropertyGroups;
$if$ ($IncludeConfigurationWindow$ == True)using $safeprojectname$.ViewModels;$endif$

namespace $safeprojectname$
{
    // This is the layer brush, the plugin feature has provided it to Artemis via a descriptor
    // Artemis may create multiple instances of it, one instance for each profile element (folder/layer) it is applied to
    public class PluginLayerBrush : LayerBrush<MainPropertyGroup>
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

        public override void Render(SKCanvas canvas, SKPath path, SKPaint paint)
    {
        }
    }
}