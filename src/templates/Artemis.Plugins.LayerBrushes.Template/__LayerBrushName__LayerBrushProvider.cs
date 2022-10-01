using Artemis.Core.LayerBrushes;
using Artemis.UI.Shared.Services.PropertyInput;
using Artemis.Plugins.LayerBrushes.Template.LayerBrushes;

namespace Artemis.Plugins.LayerBrushes.Template;

public class __LayerBrushName__LayerBrushProvider : LayerBrushProvider
{
    public override void Enable()
    {
        RegisterLayerBrushDescriptor<__LayerBrushName__LayerBrush>("__LayerBrushName__ layer brush", "__LayerBrushName__ layer brush", "QuestionMark");
    }

    public override void Disable()
    {
    }
}