using MarsRover.TerminalApp.Input_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static MarsRover.TerminalApp.InputEnums;


namespace MarsRover.TerminalApp.RoverLogic
{
    public class Rover
    {//This should probably be readonly but i cant get it to work otherwise.
        public Position position;

        public  List<Instructs> instruction;

        public readonly Plateau plateau;
        
        public Position? StoredPosition {get;set;}

        public Rover(Position _position, List<Instructs> _instruction, Plateau _plateau)
        {
            this.instruction = _instruction;
            this.position = _position;
            this.plateau = _plateau;
        }

        public class Builder
        {
            public Position Position { get; set; }

            public List<Instructs> Instruction { get; set; }

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
            public Builder AddInstruction(List<Instructs> instruction)
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