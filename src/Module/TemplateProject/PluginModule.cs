using System.Collections.Generic;
using Artemis.Core.Models.Surface;
using Artemis.Core.Plugins.Abstract;
using Artemis.Core.Plugins.Modules;
using SkiaSharp;
$if$ ($EnableDataModel$ == True)using $safeprojectname$.DataModels;$endif$
$if$ ($IncludeCustomTab$ == True)using $safeprojectname$.ViewModels;$endif$

namespace $safeprojectname$
{
    // The core of your module. Hover over the method names to see a description.
    public class PluginModule : $BaseClass$
    {
        // This is the beginning of your plugin life cycle. Use this instead of a constructor.
        public override void EnablePlugin()
        {
            DisplayName = "$ModuleName$";
            // See https://materialdesignicons.com for available icons
            DisplayIcon = "$ModuleIcon$";
            DefaultPriorityCategory = ModulePriorityCategory.$ModuleCategory$;
        }

        // This is the end of your plugin life cycle.
        public override void DisablePlugin()
        {
            // Make sure to clean up resources where needed (dispose IDisposables etc.)
        }

        public override IEnumerable<ModuleTab> GetModuleTabs()
        {
            // Optional - You may return a list of module tabs here, each view model will get its own tab in the UI. 
            $if$ ($IncludeCustomTab$ == True)
            return new List<ModuleTab> {new ModuleTab<CustomViewModel>("Custom tab")};
            $else$
            return null;
            $endif$
        }

        public override void ModuleActivated()
        {
            // When this gets called your activation requirements have been met and the module will start displaying
        }

        public override void ModuleDeactivated()
        {
            // When this gets called your activation requirements are no longer met and your module will stop displaying
        }

        public override void Update(double deltaTime)
        {
        }

        public override void Render(double deltaTime, ArtemisSurface surface, SKCanvas canvas, SKImageInfo canvasInfo)
        {
        }
    }
}