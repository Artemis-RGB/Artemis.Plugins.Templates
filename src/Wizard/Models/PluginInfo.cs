using System;

namespace ArtemisPluginTemplates.Models
{
    internal class PluginInfo
    {
        public Guid Guid { get; set; }
        public string ArtemisDirectory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Uri Website { get; set; }
        public Uri Repository { get; set; }
        public string Icon { get; set; }
    }
}