﻿using Artemis.Core.Models.Surface;
using Artemis.Core.Plugins.LayerBrushes;
using SkiaSharp;
using $safeprojectname$.PropertyGroups;
$if$ ($IncludeConfigurationWindow$ == True)using $safeprojectname$.ViewModels;$endif$

namespace $safeprojectname$
{
    // This is the layer brush, the plugin has provided it to Artemis via a descriptor
    // Artemis may create multiple instances of it, one instance for each profile element (folder/layer) it is applied to
    public class PluginLayerBrush : PerLedLayerBrush<MainPropertyGroup>
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

        public override SKColor GetColor(ArtemisLed led, SKPoint renderPoint)
        {
			return SKColor.Empty;
        }
    }
}