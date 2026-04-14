using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 using MarsRover.TerminalApp.RoverLogic;

namespace MarsRover.TerminalApp.Input_classes
{
    public class UI
    {
            bool isValidPlateau = false;
            string UserInputPlateau = "";

            bool isValidPosition = false;
            string UserInputPosition = "";

            bool isValidInstruction = false;
            string UserInputinstruction = "";

            InputParser newParser = new InputParser();
        public void StartUp()
        {
            PlateauInput();
            if (isValidPlateau)
            {
                PositionInput();
            }
            if (isValidPosition)
            {
                InstructionInput();
            }
            if (isValidInstruction)
            {
                BuildRover();
            }
        }
            
        public void PlateauInput() {

            while (isValidPlateau == false)
            {
                Console.WriteLine("Please Create a plateau in format (int int) e.g. 7 7");

                string UserInputPlateau = Console.ReadLine();

                newParser.PlateauIsValidCheck(UserInputPlateau);

                if (newParser.PlateauIsValid)
                {
                    isValidPlateau = true;
                }
                else { Console.WriteLine("The input is invalid"); }
            }
           

        }
        public void PositionInput()
        {
            while (isValidPosition == false)
            {
                Console.WriteLine("Please Select a rover position in format (int int orientation) e.g. 2 2 W");

                string UserInputPosition = Console.ReadLine();

                newParser.PlateauIsValidCheck(UserInputPosition);

                if (newParser.PositionIsValid)
                {
                    isValidPosition = true;
                }
                else { Console.WriteLine("The input is invalid"); }
            }

        }
        public void InstructionInput()
        {
            while (isValidInstruction == false)
            {
                Console.WriteLine("Please input instructions in format (LLLL) e.g. LLRRMMM");

                string UserInputinstruction = Console.ReadLine();

                newParser.PlateauIsValidCheck(UserInputinstruction);

                if (newParser.InstructionIsValid)
                {
                    isValidInstruction = true;
                }
                else { Console.WriteLine("The input is invalid"); }
            }

        }

        public Rover BuildRover()
        {
            Rover RoverA = new Rover.Builder()
                            .AddPlateau(newParser.PlateauParser(UserInputPlateau))
                            .AddPosition(newParser.PositionParser(UserInputPosition))
                            .AddInstruction(newParser.InstructionParser(UserInputinstruction))
                            .Build();
            return RoverA;  
          
        }
    

    }
}
