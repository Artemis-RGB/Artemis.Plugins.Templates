using Artemis.Core.LayerEffects;
using SkiaSharp;
using $safeprojectname$.PropertyGroups;
$if$ ($IncludeConfigurationWindow$ == True)using Artemis.UI.Shared.LayerEffects;
using $safeprojectname$.ViewModels;$endif$

namespace $safeprojectname$
{
    // This is the layer effect, the plugin feature has provided it to Artemis via a descriptor
    // Artemis may create multiple instances of it, one instance for each profile element (folder/layer) it is applied to
    public class PluginLayerEffect : LayerEffect<MainPropertyGroup>
    {
        public override void EnableLayerEffect()
        {
        $if$ ($IncludeConfigurationWindow$ == True)ConfigurationDialog = new LayerEffectConfigurationDialog<CustomViewModel>();$endif$
        }

        public override void DisableLayerEffect()
        {
        }

        public override void Update(double deltaTime)
        {
        }

        public override void PreProcess(SKCanvas canvas, SKRect renderBounds, SKPaint paint)
        {
        }

        public override void PostProcess(SKCanvas canvas, SKRect renderBounds, SKPaint paint)
        {
        }
    }
}