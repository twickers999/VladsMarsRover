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
        public void StartUp()
        {
           Rover CurrentRover = new Rover() ;

        }

        InputParser newParser = new InputParser();
        public void PlateauInput(){
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine("Please Create a plateau in format (int int) e.g. 7 7");

                string UserInputPlateau = Console.ReadLine();

                newParser.PlateauIsValidCheck(UserInputPlateau);

                if (newParser.PlateauIsValid)
                {
                    isValid = true;
                }

                else { Console.WriteLine("The input is invaid"); }
                
            }

        }
        public InputClasses.Position CreateRover()
        {
            Console.WriteLine("Please Create a rover in format (int int orientation) e.g. 2 2 W");

            string UserInputRover = Console.ReadLine();

            //TODO filter for null etc

            return InputParser.PositionParser(UserInputRover);
        }
        
    }
}
