// See https://aka.ms/new-console-template for more information

using MarsRover.TerminalApp.Input_classes;
using MarsRover.TerminalApp.RoverLogic;


UI ui = new UI();
ui.StartUp();
Display.PrintRover(ui.activeSpace.Rovers[0]);
Logic logic = new Logic();
logic.BlackBox(ui.activeSpace.Rovers[0]);
Display.PrintRover(ui.activeSpace.Rovers[0]);