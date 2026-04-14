using MarsRover.TerminalApp.Input_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRover.TerminalApp.Input_classes.InputClasses;

namespace MarsRover.TerminalApp.RoverLogic
{
    public class Rover
    {
        public readonly Position position;

        public readonly Instruction instruction;

        public readonly Plateau plateau;
        public Rover(InputClasses.Position _position, InputClasses.Instruction _instruction, InputClasses.Plateau _plateau)
        {
            this.instruction = _instruction;
            this.position = _position;
            this.plateau = _plateau;
        }
    }

    public class PlateauInstance
    {
        public readonly Plateau plateau;

        public PlateauInstance(Plateau _plateau)
        {
            this.plateau = _plateau;
        }
    }
}
