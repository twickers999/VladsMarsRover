using MarsRover.TerminalApp.Input_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRover.TerminalApp.Input_classes.InputClasses;
using static MarsRover.TerminalApp.InputEnums;

namespace MarsRover.TerminalApp.Input_classes
{
    public class InputParser
    {
        public static List<Instructs> InstructionParser(string inputString) 
        {
            List<Instructs> instructsList = inputString.ToUpper().Where(x => x == 'L' || x == 'R' || x == 'M')
            .Select(x => Enum.Parse<Instructs>(x.ToString()))
            .ToList();

            List<Instruction> instructionList = new List<Instruction>();
            foreach (var instruct in instructsList)
            {
                instructionList.Add(new Instruction(instruct));
            }
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
        

        //public InputClasses.Plateau PlateauParser(string inputString)
        //{
        //    string[] splitInput = inputString.Split(' ');
        //    int xCoord = (int)splitInput[0];
        //    int yCoord = (int)splitInput[1];
        //   return InputClasses.Plateau(xCoord, yCoord);
           
        //}
    }
}
