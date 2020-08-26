namespace ArtemisPluginTemplates.PluginTypes.DataModelExpansion
{
    internal class DataModelExpansionType : IPluginType
    {
        public void GatherInfo()
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}