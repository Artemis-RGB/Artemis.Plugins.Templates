using System;
using RGB.NET.Core;
using System.Collections.Generic;
using System.Linq;

namespace RgbNetDeviceProvider
{
    // This is your RGB.NET device provider
    // See https://github.com/DarthAffe/RGB.NET for more info on RGB.NET and examples of other device providers
    public class MyPluginDeviceProvider : AbstractRGBDeviceProvider
    {
        private static MyPluginDeviceProvider _instance;
        public static MyPluginDeviceProvider Instance => _instance ?? new MyPluginDeviceProvider();

        public MyPluginDeviceProvider()
        {
            if (_instance != null) throw new InvalidOperationException($"There can be only one instance of type {nameof(MyPluginDeviceProvider)}");
            _instance = this;
        }

        // You may remove this if not applicable for your device
        public static List<string> PossibleX86NativePaths { get; } = new List<string> { "x86/MyNativeSDK.dll" };
        public static List<string> PossibleX64NativePaths { get; } = new List<string> { "x64/MyNativeSDK.dll" };

        #region Overrides of AbstractRGBDeviceProvider

        protected override void InitializeSDK()
        {
            // Perform SDK initialization here
        }

        /// <inheritdoc />
        protected override IEnumerable<IRGBDevice> LoadDevices()
        {
            // Load your devices here and return them
            return Enumerable.Empty<IRGBDevice>();
        }

        #endregion
    }
}