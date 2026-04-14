using MarsRover.TerminalApp.Input_classes;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Diagnostics.CodeAnalysis;
using static MarsRover.TerminalApp.InputEnums;
using Shouldly;

namespace MarsRover.Test
{
    public class Tests
    {

        [Test]

        public void TurnsStringIntoInstruction()
        {
            string testString = "LLLRRMM";
            
            List<Instructs> expectedList = 
                new List<Instructs> { Instructs.L, Instructs.L, Instructs.L, Instructs.R, Instructs.R, Instructs.M, Instructs.M };

            var output = InputParser.InstructionParser(testString);

            Assert.That(output, Is.EquivalentTo(expectedList));
        }
        [Test]
        public void TurnsStringIntoInstruction2()
        {
            string testString = "LLqLRb RMM 3";

            List<Instructs> expectedList =
                 new List<Instructs> { Instructs.L, Instructs.L, Instructs.L, Instructs.R, Instructs.R, Instructs.M, Instructs.M };

            var output = InputParser.InstructionParser(testString);

            Assert.That(output, Is.EquivalentTo(expectedList));
        }
        [Test]
        public void TurnsStringIntopostion()
        {
            string testString = "1 1 N";
            InputClasses.Position output =
            InputParser.PositionParser(testString);

            InputClasses.Position expectedval = new
            InputClasses.Position(1, 1, CompassDirection.N);

            Assert.That(output, Is.EqualTo(expectedval));
        }

        [Test]
        public void TurnsStringIntoPlateau()
        {
            string testString = "10 10";
            InputClasses.Plateau output =
            InputParser.PlateauParser(testString);

            InputClasses.Plateau expectedval = new
            InputClasses.Plateau(10, 10);

            Assert.That(output, Is.EqualTo(expectedval));
        }

        [Test]

        public void ParserReturns2Rovers()
        {
           string testPlateau = " 5 5 ";
           string firstRover = "1 2 N";
           string firstInstructions = "LMLMLMLMM";
           string secondRover = "3 3 E";
           string secondInstructions =  "MMRMMRMRRM";

           string output1 = "1 3 N";
           string output2 = "5 1 E";





        }
    }

}
