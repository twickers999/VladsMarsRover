using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.TerminalApp.Input_classes;

namespace MarsRover.TerminalApp.RoverLogic
{
    public class Rover
    {
        public readonly InputClasses.Position position;

        public readonly InputClasses.Instruction instruction;
        public Rover(InputClasses.Position _position, InputClasses.Instruction _instruction)
        {
            this.instruction = _instruction;
            this.position = _position;
        }
    }

    public class PlateauInstance
    {
        public readonly InputClasses.Plateau plateau;

        public PlateauInstance(InputClasses.Plateau _plateau)
        {
            this.plateau = _plateau;
        }
    }
}
