using MarsRover.TerminalApp.Input_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MarsRover.TerminalApp.Input_classes;
using static MarsRover.TerminalApp.InputEnums;

namespace MarsRover.TerminalApp.Input_classes
{
    public class InputParser
    {
        public bool PlateauIsValid { get; set; } 
        public bool PositionIsValid { get; set; } 
        public bool InstructionIsValid { get; set; } 

        public InputParser()
        {
            PlateauIsValid = false;
            PositionIsValid = false;
            InstructionIsValid = false;
        }

        public bool PlateauIsValidCheck(string input)
        {
            bool check = Regex.IsMatch(input, @"^\d+\s+\d+$");

            PlateauIsValid = check;

            return check;
        }
        public bool PositionIsValidCheck(string input)
        {
            bool check = Regex.IsMatch(input, @"^(\d+)\s+(\d+)\s+([NSEWnesw])$");
        
            PositionIsValid = check;

            return check;
        }
        public bool InstructionIsValidCheck(string input)
        {
            bool check = Regex.IsMatch(input, @"^\s*([LRMlrm]+)\s*,?\s*$");

            InstructionIsValid = check;

            return check;
        }

        public  List<Instructs> InstructionParser(string inputString)
        {
            List<Instructs> instructsList = inputString.ToUpper().Where(x => x == 'L' || x == 'R' || x == 'M')
            .Select(x => Enum.Parse<Instructs>(x.ToString()))
            .ToList();
            //List<Instruction> instructionList = new List<Instruction>();
            //foreach (var instruct in instructsList)
            //{
            //    instructionList.Add(new Instruction(instruct));
            //}
            return instructsList;
            //foreach (var item in letterArray)
            //{
            //    if (item == 'L')
            //    {
            //        enumList.Add(Instructs.L);
            //    }
            //    if (item == 'R')
            //    {
            //        enumList.Add(Instructs.R);
            //    }
            //    if (item == 'M')
            //    {
            //        enumList.Add(Instructs.M);
            //    }
            //}
        }
        public Plateau PlateauParser(string inputString)
        {
              string[] splitInput = inputString.Split(' ');
                int xAxis = int.Parse(splitInput[0]);
                int yAxis = int.Parse(splitInput[1]);

                return new Plateau(xAxis, yAxis);
        }
        public  Position PositionParser(string inputString)
        {
            string[] splitInput = inputString.Split(' ');
            int xCoord = int.Parse(splitInput[0]);
            int yCoord = int.Parse(splitInput[1]);
            CompassDirection orientation = CompassDirection.Parse<CompassDirection>(splitInput[2]);

            return new Position(xCoord, yCoord, orientation);

        }
    }
}
