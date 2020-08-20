using System;

namespace ModuleProjectWizard.Models
{
    internal class PluginInfo
    {
        public Guid Guid { get; set; }
        public string ArtemisDirectory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}