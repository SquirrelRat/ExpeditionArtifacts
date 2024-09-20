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
		TujenTitleColor = new ColorBGRA(3, 227, 252, 255);
		DannigTitleColor = new ColorBGRA(3, 132, 255, 255);
		TujenEnabled = new ToggleNode(true);
		DannigEnabled = new ToggleNode(true);
        }

        	public ToggleNode Enable { get; set; } = new ToggleNode(true);
		public ToggleNode TujenEnabled { get; set; } = new ToggleNode(true);
		public ToggleNode DannigEnabled { get; set; } = new ToggleNode(true);	
        	public RangeNode<int> PosX { get; set; } = new RangeNode<int>(0, 0, 2500);
        	public RangeNode<int> PosY { get; set; } = new RangeNode<int>(0, 0, 1500);		
        	public ColorNode BackgroundColor { get; set; }
        	public ColorNode TextColor { get; set; }
		public ColorNode TujenTitleColor { get; set; }
	    	public ColorNode DannigTitleColor { get; set; }	

   	 }
}
