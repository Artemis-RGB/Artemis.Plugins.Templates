using System.Collections.Generic;
using Artemis.Core.Models.Surface;
using Artemis.Core.Plugins.Abstract;
using Artemis.Core.Plugins.Modules;
using ModuleProject.DataModels;
using ModuleProject.ViewModels;
using SkiaSharp;

namespace ModuleProject
{
    // The core of your module. Hover over the method names to see a description.
    public class TemplateModule : ProfileModule<TemplateDataModel>
    {
        // This is the beginning of your plugin life cycle. Use this instead of a constructor.
        public override void EnablePlugin()
        {
            // The modules display name that's shown in the menu
            DisplayName = "Template";
            // The modules display icon that's shown in the menu see https://materialdesignicons.com for available icons
            DisplayIcon = "AccountHardHat";

            // The default priority category in which the module will fall, the user may change this if they want
            DefaultPriorityCategory = ModulePriorityCategory.Normal;

            // This defines when the module should activate. Remove this if you want your module to always be active
            ActivationRequirementMode = ActivationRequirementType.Any;
            ActivationRequirements.Add(new ProcessActivationRequirement("Test"));
        }

        // This is the end of your plugin life cycle.
        public override void DisablePlugin()
        {
            // Make sure to clean up resources where needed (dispose IDisposables etc.)
        }

        public override IEnumerable<ModuleTab> GetModuleTabs()
        {
            // Optional - You may return a list of module tabs here, each view model will get its own tab in the UI. 
            return new List<ModuleTab> {new ModuleTab<TemplateViewModel>("Template tab")};
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