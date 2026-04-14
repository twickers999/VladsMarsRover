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
        public Rover(Position _position,Instruction _instruction, Plateau _plateau)
        {
            this.instruction = _instruction;
            this.position = _position;
            this.plateau = _plateau;
        }

        public class Builder
        {
            public Position Position { get; set; }

            public Instruction Instruction { get; set; }

            public Plateau Plateau { get; set; }

            public Builder() { }
           
            public Builder AddPlateau(Plateau plateau)
            {
                this.Plateau =  plateau;
                return this;
            }
            public Builder AddPosition(Position position)
            {
                this.Position = position;
                return this;
            }
            public Builder AddInstruction(Instruction instruction)
            {
                this.Instruction = instruction;
                return this;
            }
            public Rover Build()
            {
                return new Rover (this.Position, this.Instruction, this.Plateau);
            }
        }
    }
}