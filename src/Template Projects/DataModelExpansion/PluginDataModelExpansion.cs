using Artemis.Core.DataModelExpansions;
using $safeprojectname$.DataModels;

namespace $safeprojectname$
{
    public class PluginDataModelExpansion : DataModelExpansion<PluginDataModel>
    {
        public override void Enable()
        {
        }

        public override void Disable()
        {
        }

        public override void Update(double deltaTime)
        {
            // You can access your data model here and update it however you like
            DataModel.TemplateDataModelString = $"The last delta time was {deltaTime} seconds";
        }
    }
}