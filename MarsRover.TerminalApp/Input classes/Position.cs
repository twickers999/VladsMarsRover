using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRover.TerminalApp.InputEnums;

namespace MarsRover.TerminalApp.Input_classes
{
    public record Position (int xPosition, int yPosition, CompassDirection direction);

    public record Plateau(int xAxis, int yAxis, string PlateauID);

    public record Instruction(int xMovement, int yMovement, Instruction Rotate);

}
