using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using SharpDX;

namespace ExpeditionArtifacts
{
    public class ExpeditionArtifactsSettings : ISettings
    {
        public ExpeditionArtifactsSettings()
        {
			BackgroundColor = new ColorBGRA(0, 0, 0, 150);
			TextColor = new ColorBGRA(255, 255, 255, 255);


        }

        public ToggleNode Enable { get; set; } = new ToggleNode(true);
        public RangeNode<int> PosX { get; set; } = new RangeNode<int>(0, 0, 2500);
        public RangeNode<int> PosY { get; set; } = new RangeNode<int>(0, 0, 1500);
        public ColorNode BackgroundColor { get; set; }
        public ColorNode TextColor { get; set; }

    }
}
