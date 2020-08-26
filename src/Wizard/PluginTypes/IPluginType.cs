namespace ArtemisPluginTemplates.PluginTypes
{
    internal interface IPluginType
    {
        void GatherInfo();
        bool ShouldAddProjectItem(string filePath);
    }
}