using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NasaRover;

namespace Presentation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = string.Empty;
            var translator = new CommandTranslator();
            Grid grid = new Grid(10, 10, new Position(0, 0));
            DirectionMove direction = new DirectionMove(grid);
            OrientationMove orientation = new OrientationMove();
            var movementService = new MovementService(grid, direction, orientation);
            var rover = new Rover(movementService);
            PrintStatus(movementService);

            while (input != "x")
            {
                input = Console.ReadLine();
                var command = translator.Parse(input);
                var result = rover.Move(command);

                if (result.IsFail)
                {
                    Console.WriteLine("Obstacle detected.");
                }

                PrintStatus(movementService);
            }
        }

        private static void PrintStatus(MovementService movementService)
        {
            Console.WriteLine($"Current Position is: {movementService.CurrentPosition.X}, {movementService.CurrentPosition.Y}");
            Console.Write("Please enter a command (x to exit): ");
        }
    }
}