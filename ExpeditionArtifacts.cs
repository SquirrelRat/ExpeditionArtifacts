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
        private string Tujen = "";
	private string TA = "";
        private string TB = "";		
        private string TC = "";		
        private string TD = "";
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

                CanRender = true;
		Tujen = $"Tujen Artifacts:\n";
		TA = $"Lesser: {TujenA}";
		TB = $"Greater: {TujenB}";
		TC = $"Grand: {TujenC}";
		TD = $"Exceptional: {TujenD}";				

 
		
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
	var stringList = string.Join(separator, Tujen, TA, TB, TC, TD);
	var textSize = Graphics.MeasureText(stringList);
	var boxPos = new Vector2(textSize.X + Settings.PosX, textSize.Y + Settings.PosY);
	var boxSize = new Vector2(textSize.X, textSize.Y);
	var textPos = new Vector2(boxPos.X, boxPos.Y);
        

Graphics.DrawText(stringList, textPos, Settings.TextColor);
Graphics.DrawText(Tujen, textPos, Color.Gold);
Graphics.DrawBox(new RectangleF(boxPos.X - 5, boxPos.Y - 3, boxSize.X + 10, boxSize.Y + 6), Settings.BackgroundColor);



        }

    }
}
