using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRover.TerminalApp.InputEnums;

namespace MarsRover.TerminalApp.Input_classes

{
    public record Position(int xPosition, int yPosition, CompassDirection direction);

    public record Plateau(int xAxis, int yAxis);

    public class InputStringObject
    {
        public string PlateauStr
        { get; set; }
        public string PositionStr
        { get; set; }
        public string InstructionStr
        { get; set; }
        public InputStringObject()
        {
            PlateauStr = "";
            PositionStr = "";
            InstructionStr = "";
        }
    }

}
