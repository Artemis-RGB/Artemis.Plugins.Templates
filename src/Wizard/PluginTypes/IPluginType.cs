namespace PluginTemplatesWizard.PluginTypes
{
    internal interface IPluginType
    {
        void GatherInfo();
        bool ShouldAddProjectItem(string filePath);
    }
}