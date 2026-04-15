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
            public InputStringObject StringObject = new InputStringObject();

            public InputParser newParser = new InputParser();

            public TestingToggle toggle = new TestingToggle(false);

        public void StartUp()
        {
            if (!newParser.PlateauIsValid)
            {
                 PlateauInput(newParser.PlateauIsValid, StringObject);

                if (newParser.PlateauIsValid && !newParser.PositionIsValid)
                {
                     PositionInput(newParser.PositionIsValid, StringObject);

                    if (newParser.PositionIsValid)
                    {
                         InstructionInput(newParser.InstructionIsValid, StringObject);

                        if (newParser.InstructionIsValid)
                        {
                            BuildRover();
                        }
                    }
                }
            }
        }
        public string RequestUserInput(int code)
        {
            string[] textPrompts =
            [
                "Hello",
                "Please Create a plateau in format (int int) e.g. 7 7",
                "Please Select a rover position in format (int int orientation) e.g. 2 2 W",
                "Please input instructions as a string of Characters e.g. LLRRMMM",
            ];

            Console.WriteLine(textPrompts[code]);
            string UserInput = "";
            if (toggle.TestingOn) { UserInput = toggle.inputMocks[code-1]; }
            else { UserInput = Console.ReadLine(); }
            return UserInput;

            //var inputTask = Task.Run(() => Console.ReadLine());
            //var delayTask = Task.Delay(10000); // 10 seconds
            //var completedTask = await Task.WhenAny(inputTask, delayTask);
            //if (completedTask == inputTask)
            //{
            //    return inputTask.Result;
            //}
            //else
            //{
            //    Console.WriteLine("You are taking too long");
            //    return "";
            //}
        }
        public string PlateauInput(bool plateauIsValid, InputStringObject stringObject ) {
            while (plateauIsValid == false)
            {
                string userInput =  RequestUserInput(1);
                if(userInput == "")
                {
                    userInput = "9 9";
                }
                stringObject.PlateauStr = userInput;
                if (newParser.PlateauIsValidCheck(stringObject.PlateauStr))
                {
                    plateauIsValid = true;
                    newParser.PlateauIsValid = true;
                }
                else { Console.WriteLine("The input is invalid"); }
            }
            return stringObject.PlateauStr;
        }
        public string PositionInput(bool isValidPosition, InputStringObject stringObject)
        {
            while (isValidPosition == false)
            {
                string userInput =  RequestUserInput(2);
                if (userInput == "")
                {
                    userInput = "0 0 N";
                }
                stringObject.PositionStr = userInput;

                if (newParser.PositionIsValidCheck(StringObject.PositionStr))
                {
                    isValidPosition = true;
                    newParser.PositionIsValid = true;
                }
                else { Console.WriteLine("The input is invalid"); }
            }
            return StringObject.PositionStr;
        }
        public string InstructionInput(bool isValidInstruction, InputStringObject stringObject)
        {
            while (isValidInstruction == false)
            {
                string userInput = RequestUserInput(3);
                if (userInput == "")
                {
                    userInput = "MMRRMMLL";
                }
                stringObject.InstructionStr = userInput;

                if (newParser.InstructionIsValidCheck(StringObject.InstructionStr))
                {
                    isValidInstruction = true;
                    newParser.InstructionIsValid = true;
                }
                else { Console.WriteLine("The input is invalid"); }
            }
            return StringObject.InstructionStr;
        }
        public Rover BuildRover()
        {
            Rover RoverA = new Rover.Builder()
                            .AddPlateau(newParser.PlateauParser(StringObject.PlateauStr))
                            .AddPosition(newParser.PositionParser(StringObject.PositionStr))
                            .AddInstruction(newParser.InstructionParser(StringObject.InstructionStr))
                            .Build();
            return RoverA;
        }
    }
}
