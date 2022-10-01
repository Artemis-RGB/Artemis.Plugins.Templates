using Artemis.Core.LayerEffects;
using Artemis.Plugins.LayerEffects.Template.LayerEffects;

namespace Artemis.Plugins.LayerEffects.Template;

public class __LayerEffectName__LayerEffectProvider : LayerEffectProvider
{
    public override void Enable()
    {
        RegisterLayerEffectDescriptor<__LayerEffectName__LayerEffect>("__LayerEffectName__ layer effect", "__LayerEffectName__ layer effect", "QuestionMark");
    }

    public override void Disable()
    {
    }
}