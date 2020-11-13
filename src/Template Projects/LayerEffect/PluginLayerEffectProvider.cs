using Artemis.Core.LayerEffects;

namespace $safeprojectname$
{
    // This is your plugin feature, it provides Artemis wil one or more layer effects via descriptors.
    // Your feature gets enabled once. Your layer effects get enabled multiple times, once for each profile element (folder/layer) it is applied to.
    public class PluginLayerEffectProvider : LayerEffectProvider
    {
        public override void Enable()
        {
            // This is where we can register our effect for use, we can also register multiple effects if we'd like
            RegisterLayerEffectDescriptor<PluginLayerEffect>("$LayerEffectName$", "$LayerEffectDescription$", "$LayerEffectIcon$");
        }

        public override void Disable()
        {
            // Any registrations we made will be removed automatically, we don't need to do anything here
        }
    }
}