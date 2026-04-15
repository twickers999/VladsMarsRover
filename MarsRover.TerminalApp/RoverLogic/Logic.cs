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
        public Position Move(Position position)
        {
            int d = (int)position.direction;
            int x = (int)position.xPosition;
            int y = (int)position.yPosition;
            if (d == 1)
            {
                x += 1;
                if (d == 1)
                {
                    y += 1;
                     if (d == 2)
                    {
                        x -= 1;
                         if (d == 3)
                        {
                            y -= 1;
                        }
                    }
                }
            }
            Position updatedPosition = new Position(x, y, (CompassDirection)d);
            return updatedPosition;
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
