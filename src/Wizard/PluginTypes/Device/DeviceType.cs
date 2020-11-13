using System.Collections.Generic;
using System.IO;

namespace ArtemisPluginTemplates.PluginTypes.Device
{
    internal class DeviceType : IPluginType
    {
        private readonly Dictionary<string, string> _replacementsDictionary;

        public DeviceType(Dictionary<string, string> replacementsDictionary)
        {
            _replacementsDictionary = replacementsDictionary;
        }

        public void GatherInfo()
        {
            if (!Path.IsPathRooted(_replacementsDictionary["$ArtemisDirectory$"]))
            {
                _replacementsDictionary["$ArtemisDirectory$"] = "..\\" + _replacementsDictionary["$ArtemisDirectory$"];
                _replacementsDictionary["$ArtemisDirectoryEscaped$"] = "..\\\\" + _replacementsDictionary["$ArtemisDirectoryEscaped$"];
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}