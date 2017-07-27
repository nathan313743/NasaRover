using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundApps
{
    public class RoverPosition
    {
        private readonly Grid _grid;

        public RoverPosition(Grid grid)
        {
            _grid = grid;
        }

        public RoverDirection Direction { get; private set; }

        public Position CurrentPosition => new Position(_grid.CurrentPosition.X, _grid.CurrentPosition.Y);

        public void Move(Movement command)
        {
            if (IsDirectionChange(command))
            {
                ChangeDirection(command);
                return;
            }
            MoveDirection(command);
        }

        public void MoveDirection(Movement command)
        {
            if (command == Movement.Forward)
            {
                MoveForward();
            }
            else if (command == Movement.Backwards)
            {
                MoveBackwards();
            }
        }

        private void MoveForward()
        {
            if (this.Direction == RoverDirection.North)
            {
                _grid.CurrentPosition.Y = (_grid.CurrentPosition.Y + 1) % (_grid.YLimit + 1);
            }
            else if (this.Direction == RoverDirection.East)
            {
                _grid.CurrentPosition.X = (_grid.CurrentPosition.X + 1) % (_grid.XLimit + 1);
            }
            else if (this.Direction == RoverDirection.South)
            {
                _grid.CurrentPosition.Y = ((_grid.CurrentPosition.Y - 1) + _grid.YLimit) % (_grid.YLimit + 1);
            }
            else if (this.Direction == RoverDirection.West)
            {
                _grid.CurrentPosition.X = ((_grid.CurrentPosition.X - 1) + _grid.XLimit) % (_grid.XLimit + 1);
            }
        }

        private void MoveBackwards()
        {
            if (this.Direction == RoverDirection.North)
            {
                _grid.CurrentPosition.Y = ((_grid.CurrentPosition.Y - 1) + _grid.YLimit) % (_grid.YLimit + 1);
            }
            else if (this.Direction == RoverDirection.East)
            {
                _grid.CurrentPosition.X = ((_grid.CurrentPosition.X - 1) + _grid.XLimit) % (_grid.XLimit + 1);
            }
            else if (this.Direction == RoverDirection.South)
            {
                _grid.CurrentPosition.Y = (_grid.CurrentPosition.Y + 1) % (_grid.YLimit + 1);
            }
            else if (this.Direction == RoverDirection.West)
            {
                _grid.CurrentPosition.X = (_grid.CurrentPosition.X + 1) % (_grid.XLimit + 1);
            }
        }

        public void ChangeDirection(Movement command)
        {
            if (command == Movement.Left)
            {
                TurnLeft();
            }
            else if (command == Movement.Right)
            {
                TurnRight();
            }
        }

        private void TurnRight()
        {
            this.Direction = (RoverDirection)(((int)this.Direction + 1) % 4);
        }

        private void TurnLeft()
        {
            this.Direction = (RoverDirection)((((int)this.Direction - 1) + 4) % 4);
        }

        internal bool IsDirectionChange(Movement command)
        {
            if (command == Movement.Left || command == Movement.Right)
            {
                return true;
            }
            return false;
        }
    }
}