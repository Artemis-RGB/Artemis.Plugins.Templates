namespace PluginTemplatesWizard.PluginTypes.Device
{
    internal class DeviceType : IPluginType
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