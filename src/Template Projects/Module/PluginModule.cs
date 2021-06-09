using System.Collections.Generic;
using Artemis.Core;
using Artemis.Core.Modules;
using SkiaSharp;
using $safeprojectname$.DataModels;

namespace $safeprojectname$
{
    // The core of your module. Hover over the method names to see a description.
    [PluginFeature(Name = "$ModuleName$", Icon = "$ModuleIcon$")]
    public class PluginModule : Module<PluginDataModel>
    {
        // This is useful if your module targets a specific game or application.
        // If this list is not null and not empty, the data of your module is only available to profiles specifically targeting it
        public override List<IModuleActivationRequirement> ActivationRequirements => null;

        // This is the beginning of your plugin feature's life cycle. Use this instead of a constructor.
        public override void Enable()
        {
            // Anything you'd otherwise do in a constructor is done here
        }

        // This is the end of your plugin feature's life cycle.
        public override void Disable()
        {
            // Make sure to clean up resources where needed (dispose IDisposables etc.)
        }

        public override void ModuleActivated(bool isOverride)
        {
            // When this gets called your activation requirements have been met and the module will start displaying
            // You can remove this if you don't need it
        }

        public override void ModuleDeactivated(bool isOverride)
        {
            // When this gets called your activation requirements are no longer met and your module will stop displaying
            // You can remove this if you don't need it
        }

        public override void Update(double deltaTime)
        {
			// This is where you can add your update logic
        }     
    }
}