using System.Collections.Generic;
using PluginTemplatesWizard.Models;

namespace PluginTemplatesWizard.PluginTypes.DataModelExpansion
{
    internal class DataModelExpansionType : IPluginType
    {
        public DataModelExpansionType()
        {
        }

        public void GatherInfo()
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}