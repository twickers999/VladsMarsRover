using MarsRover.TerminalApp.Input_classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsRover.TerminalApp.InputEnums;

namespace MarsRover.TerminalApp.RoverLogic
{
    public class Logic
    {
        public void Move(Position position)
        {
            int d = position.direction;
            if (position.direction = 0)
            {
                position.xPosition += 1;
                if (position.direction = 1)
                {
                    position.yPosition += 1;
                    if (position.direction = 2)
                    {
                        position.xPosition -= 1;
                        if (position.direction = 3)
                        {
                            position.yPosition -= 1;
                        }
                    }
                }
            }
        }

        public void CreatePlateau(Rover rover) 
        {
           

        }
        public Rover BlackBox(Rover rover)
        {
            Plateau plateau = rover.plateau;
            Position position = rover.position;
            List<Instructs> i = rover.instruction;

           
            foreach (Instructs inst in rover.instruction)
            {
                Rotate(inst);
            }
                    
        
       public CompassDirection Rotate(CompassDirection point, Instructs instructs)
        {
            int pointIndex = (int)point;
            int directionIndex = (int)instructs;
            if (instructs == Instructs.M)
            {
                directionIndex = 0;
                if (instructs == Instructs.L)
                {
                    directionIndex = -1;
                    if (instructs == Instructs.R)
                    {
                        directionIndex = 1;
                    }
                }
            }

            int NewIndex = directionIndex + pointIndex;

            if (NewIndex == 4) //west
            {
                NewIndex = 0;//north
            }
            if (NewIndex == -1)//north to west
            {
                NewIndex = 3;//west
            }
            var newDirection = (CompassDirection)NewIndex;
            return newDirection;
        }
         return rover;

    }


}
        
            //public static void PrintExes(int xAxis, int yAxis)
            //{
            //char[,] arr = new char[xAxis, yAxis];


            //for (int i = 0; i < xAxis; i++)
            //{
            //    arr[i, 0] = '+';

            //    for (int j = 1; j < yAxis; j++)
            //    {
            //        arr[i, j] = '+';
            //    }
            //}
            //string[] forPrinting = new string[xAxis];

            //for (int i = 0; i < yAxis; i++)
            //{
            //    string combined = "";
            //    for (int j = 0; j < xAxis; j++)
            //    {
            //        combined += arr[i, j];
            //    }
            //    Console.WriteLine(combined);
            //}

            //}
        
   // }
//}
