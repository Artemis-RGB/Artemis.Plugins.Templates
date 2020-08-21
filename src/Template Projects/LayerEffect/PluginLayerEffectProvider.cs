using Artemis.Core.Plugins.LayerEffects;

namespace $safeprojectname$
{
    // This is your plugin, it provides Artemis wil one or more layer effects via descriptors.
    // Your plugin gets enabled once. Your layer effects get enabled multiple times, once for each profile element (folder/layer) it is applied to.
    public class PluginLayerEffectProvider : LayerEffectProvider
    {
        public override void EnablePlugin()
        {
            // This is where we can register our effect for use, we can also register multiple effects if we'd like
            AddLayerEffectDescriptor<PluginLayerEffect>("$LayerEffectName$", "$LayerEffectDescription$", "$LayerEffectIcon$");
        }

        public override void DisablePlugin()
        {
            // Any registrations we made will be removed automatically, we don't need to do anything here
        }
    }
}