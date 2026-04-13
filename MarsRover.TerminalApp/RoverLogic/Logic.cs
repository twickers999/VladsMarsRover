using MarsRover.TerminalApp.Input_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.TerminalApp.RoverLogic
{
    internal class Logic
    {
        public void CreatePlateau()
        {
            //new InputClasses.Plateau();

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
