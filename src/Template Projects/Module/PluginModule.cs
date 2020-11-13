using Artemis.Core;
using Artemis.Core.Modules;
using SkiaSharp;
$if$ ($EnableDataModel$ == True)using $safeprojectname$.DataModels;$endif$
$if$ ($IncludeCustomTab$ == True)using System.Collections.Generic;$endif$
$if$ ($IncludeCustomTab$ == True)using $safeprojectname$.ViewModels;$endif$

namespace $safeprojectname$
{
    // The core of your module. Hover over the method names to see a description.
    public class PluginModule : $BaseClass$
    {
        // This is the beginning of your plugin feature's life cycle. Use this instead of a constructor.
        public override void Enable()
        {
            DisplayName = "$ModuleName$";
            DisplayIcon = "$ModuleIcon$";
            DefaultPriorityCategory = ModulePriorityCategory.$ModuleCategory$;
            $if$ ($IncludeCustomTab$ == True)ModuleTabs = new List<ModuleTab> { new ModuleTab<CustomViewModel>("Custom tab") };$endif$
        }

        // This is the end of your plugin feature's life cycle.
        public override void Disable()
        {
            // Make sure to clean up resources where needed (dispose IDisposables etc.)
        }

        public override void ModuleActivated(bool isOverride)
        {
            // When this gets called your activation requirements have been met and the module will start displaying
        }

        public override void ModuleDeactivated(bool isOverride)
        {
            // When this gets called your activation requirements are no longer met and your module will stop displaying
        }

        public override void Update(double deltaTime)
        {
			$if$ ($EnableProfiles$ == True)// This is where you can add your update logic, this method is called before the profile is updated$endif$
        }

        public override void Render(double deltaTime, ArtemisSurface surface, SKCanvas canvas, SKImageInfo canvasInfo)
        {
			$if$ ($EnableProfiles$ == True)// This is where you may add extra render logic, this method is called before the profile is rendered$endif$
        }        
    }
}