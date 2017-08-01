using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRover
{
    public class OrientationMove
    {
        public MoveDirection ChangeOrientation(Movement command, MoveDirection currentDirection)
        {
            if (command == Movement.Left)
            {
                return TurnLeft(currentDirection);
            }
            else if (command == Movement.Right)
            {
                return TurnRight(currentDirection);
            }

            throw new ArgumentException();
        }

        private MoveDirection TurnRight(MoveDirection currentDirection)
        {
            return (MoveDirection)(((int)currentDirection + 1) % 4);
        }

        private MoveDirection TurnLeft(MoveDirection currentDirection)
        {
            return (MoveDirection)((((int)currentDirection - 1) + 4) % 4);
        }

        public bool IsOrientationChange(Movement command)
        {
            if (command == Movement.Left || command == Movement.Right)
            {
                return true;
            }
            return false;
        }
    }
}