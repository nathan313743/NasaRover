using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRover
{
    public class CommandTranslator
    {
        public Movement Parse(string command)
        {
            if (command == "F")
            {
                return Movement.Forward;
            }
            else if (command == "B")
            {
                return Movement.Backwards;
            }
            else if (command == "L")
            {
                return Movement.Left;
            }
            else if (command == "R")
            {
                return Movement.Right;
            }

            throw new ArgumentException($"Invalid command: {command}");
        }
    }
}