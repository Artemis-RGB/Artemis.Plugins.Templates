using System.Collections.Generic;
using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Plugins.ModuleTemplate.DataModels;

namespace Artemis.Plugins.ModuleTemplate;

public class __ModuleName__Module : Module<__ModuleName__DataModel>
{
        public override List<IModuleActivationRequirement> ActivationRequirements { get; } = new();

        public override void ModuleActivated(bool isOverride)
        {

        }

        public override void ModuleDeactivated(bool isOverride)
        {

        }

        public override void Enable() 
        { 

        }

        public override void Disable() 
        { 

        }

        public override void Update(double deltaTime) 
        { 

        }
}