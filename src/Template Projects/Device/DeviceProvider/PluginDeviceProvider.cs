using System.IO;
using Artemis.Core.DeviceProviders;
using Artemis.Core.Services;
using RgbNetDeviceProvider;

namespace $safeprojectname$
{
    // This is your Artemis device provider, all it really does is act as a bridge between RGB.NET and Artemis
    // You will not write any device logic in here, refer to the RgbNetDeviceProvider project instead    
    public class PluginDeviceProvider : DeviceProvider
    {
        private readonly IRgbService _rgbService;

        public PluginDeviceProvider(IRgbService rgbService) : base(MyPluginDeviceProvider.Instance)
        {
            _rgbService = rgbService;
        }

        public override void Enable()
        {
            // Uncomment this to let RGB.NET know where to look for layouts/device images.
            // Change 'typeof(MyRGBDevice<>)' to the main-type of your device, Artemis will handle the rest
            // PathHelper.ResolvingAbsolutePath += (sender, args) => ResolveAbsolutePath(typeof(MyRGBDevice<>), sender, args);

            // If your plugin's device uses native libraries you can point your RGB.NET device provider to the plugin directory like so
            // Feel free to remove this from here and your RGB.NET device provider if you don't need it
            MyPluginDeviceProvider.PossibleX64NativePaths.Add(Path.Combine(Plugin.Directory.FullName, "x64", "MyNativeSDK.dll"));
            MyPluginDeviceProvider.PossibleX86NativePaths.Add(Path.Combine(Plugin.Directory.FullName, "x86", "MyNativeSDK.dll"));

            // Let Artemis's RGB service know about our device provider
            _rgbService.AddDeviceProvider(RgbDeviceProvider);
        }

        public override void Disable()
        {
        	// Before disposing your provider, let Artemis know it is gone
            _rgbService.RemoveDeviceProvider(RgbDeviceProvider);
            RgbDeviceProvider.Dispose();
        }
    }
}