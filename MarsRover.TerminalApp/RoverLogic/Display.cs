using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.TerminalApp.RoverLogic
{
    public class Display
    {
        public static void PrintRover(Rover rover)
        {
            Console.WriteLine(rover.position.ToString());
            if(rover.position.direction == InputEnums.CompassDirection.N)
            {
                Console.WriteLine(" ^"+"\n 0");
            }
            if (rover.position.direction == InputEnums.CompassDirection.W)
            {
                Console.WriteLine("<0");
            }
            if (rover.position.direction == InputEnums.CompassDirection.S)
            {
                Console.WriteLine(" 0" + "\n v");
            }
            if (rover.position.direction == InputEnums.CompassDirection.E)
            {
                Console.WriteLine("0>");
            }
            
        }
        public static void PrintExes(int xAxis, int yAxis)
        {
            char[,] arr = new char[xAxis, yAxis];


            for (int i = 0; i < xAxis; i++)
            {
                arr[i, 0] = '+';

                for (int j = 1; j < yAxis; j++)
                {
                    arr[i, j] = '+';
                }
            }
            string[] forPrinting = new string[xAxis];

            for (int i = 0; i < yAxis; i++)
            {
                string combined = "";
                for (int j = 0; j < xAxis; j++)
                {
                    combined += arr[i, j];
                }
                Console.WriteLine(combined);
            }

        }

    }
}

    
