using Artemis.Core.Plugins.Abstract.ViewModels;
using Artemis.Core.Plugins.LayerEffect.Abstract;
using SkiaSharp;
using LayerEffect.PropertyGroups;
// using $safeprojectname$.PropertyGroups;
// $if$ ($IncludeConfigurationWindow$ == True)using $safeprojectname$.ViewModels;$endif$

// namespace $safeprojectname$
namespace LayerEffect
{
    // This is the layer effect, the plugin has provided it to Artemis via a descriptor
    // Artemis may create multiple instances of it, one instance for each profile element (folder/layer) it is applied to
    public class PluginLayerEffect : LayerEffect<MainPropertyGroup>
    {
        public override void EnableLayerEffect()
        {
        }

        public override void DisableLayerEffect()
        {
        }

        public override void Update(double deltaTime)
        {
        }

        public override void PreProcess(SKCanvas canvas, SKImageInfo canvasInfo, SKPath renderBounds, SKPaint paint)
        {
        }

        public override void PostProcess(SKCanvas canvas, SKImageInfo canvasInfo, SKPath renderBounds, SKPaint paint)
        {
        }

        public override EffectConfigurationViewModel GetConfigurationViewModel()
        {
            return base.GetConfigurationViewModel();
        }
    }
}