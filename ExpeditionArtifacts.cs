using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ExileCore;
using ExileCore.PoEMemory.Components;
using ExileCore.PoEMemory.MemoryObjects;
using ExileCore.PoEMemory.Elements;
using ExileCore.Shared;
using ExileCore.Shared.Cache;
using ExileCore.Shared.Enums;
using ExileCore.Shared.Helpers;
using SharpDX;
using Vector2N = System.Numerics.Vector2;

namespace ExpeditionArtifacts
{
    public class ExpeditionArtifacts : BaseSettingsPlugin<ExpeditionArtifactsSettings>
    {
	private string ST = "";
	private string TA = "";
        private string TB = "";		
        private string TC = "";		
        private string TD = "";
        private string Tujen = "";
	private string DA = "";
        private string DB = "";		
        private string DC = "";		
        private string DD = "";	
        private string Dannig = "";			
        
	private bool CanRender;	
        private Vector2N drawTextVector2;


        public override bool Initialise()
        {
            return true;
        }

        public override Job Tick()
        {
            Panel();
            return null;
        }

        private void Panel()
        {

            {
                var TujenA = GameController.IngameState.ServerData.LesserBlackScytheArtifacts;
		var TujenB = GameController.IngameState.ServerData.GreaterBlackScytheArtifacts;
                var TujenC = GameController.IngameState.ServerData.GrandBlackScytheArtifacts;
		var TujenD = GameController.IngameState.ServerData.ExceptionalBlackScytheArtifacts;	
                var DannigA = GameController.IngameState.ServerData.LesserSunArtifacts;
		var DannigB = GameController.IngameState.ServerData.GreaterSunArtifacts;
                var DannigC = GameController.IngameState.ServerData.GrandSunArtifacts;
		var DannigD = GameController.IngameState.ServerData.ExceptionalSunArtifacts;			

                CanRender = true;
		
		ST = $"";
		TA = $"Lesser: {TujenA}";
		TB = $"Greater: {TujenB}";
		TC = $"Grand: {TujenC}";
		TD = $"Exceptional: {TujenD}";				
		DA = $"Lesser: {DannigA}";
		DB = $"Greater: {DannigB}";
		DC = $"Grand: {DannigC}";
		DD = $"Exceptional: {DannigD}";	
		Tujen = $"Tujen Artifacts:\n";
		Dannig = $"Dannig Artifacts:\n";
 	    }
		
	}
		


        public override void Render()
        {
            if (!CanRender)
                return;

            var iList = new List<(string, ExileCore.Shared.Nodes.ColorNode)>

		{


    };
    var separator = "\n";
	var stringListT = string.Join(separator, ST, TA, TB, TC, TD);
	var stringListD = string.Join(separator, ST, DA, DB, DC, DD);	
	var textSizeT = Graphics.MeasureText(stringListT);	
	var textSizeD = Graphics.MeasureText(stringListD);		
	var boxPos = new Vector2(textSizeT.X + Settings.PosX, textSizeT.Y + Settings.PosY);
	var boxPos2 = new Vector2(textSizeT.X + Settings.PosX, textSizeT.Y + Settings.PosY);	
	var boxSize = new Vector2(textSizeT.X, textSizeT.Y);		
	var textPos = new Vector2(boxPos.X, boxPos.Y);	
	var textPos2 = new Vector2(boxPos2.X + 125, boxPos2.Y);	



Graphics.DrawText(stringListT, textPos, Settings.TextColor);
Graphics.DrawText(stringListD, textPos2, Settings.TextColor);
Graphics.DrawText(Tujen, textPos, Color.Gold);
Graphics.DrawText(Dannig, textPos2, Color.Orange);
Graphics.DrawBox(new RectangleF(boxPos.X - 5, boxPos.Y - 3, boxSize.X + 10, boxSize.Y + 6), Settings.BackgroundColor);
Graphics.DrawBox(new RectangleF(boxPos2.X + 120, boxPos2.Y - 3, boxSize.X + 15, boxSize.Y + 6), Settings.BackgroundColor);


        }

    }
}
