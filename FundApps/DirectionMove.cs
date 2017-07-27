using System;

namespace FundApps
{
    public class DirectionMove
    {
        private Grid _grid;

        public DirectionMove(Grid grid)
        {
            _grid = grid;
        }

        public Result Move(Movement command, MoveDirection direction)
        {
            if (command == Movement.Forward)
            {
                return MoveForward(direction);
            }
            else if (command == Movement.Backwards)
            {
                return MoveBackwards(direction);
            }

            throw new ArgumentException();
        }

        private Result DecrementXAxis()
        {
            int x = ((_grid.CurrentPosition.X - 1) + _grid.XLimit) % (_grid.XLimit);
            return _grid.SetX(x);
        }

        private Result DecrementYAxis()
        {
            int y = ((_grid.CurrentPosition.Y - 1) + _grid.YLimit) % (_grid.YLimit);
            return _grid.SetY(y);
        }

        private Result IncrementXAxis()
        {
            int x = (_grid.CurrentPosition.X + 1) % (_grid.XLimit);
            return _grid.SetX(x);
        }

        private Result IncrementYAxis()
        {
            int y = (_grid.CurrentPosition.Y + 1) % (_grid.YLimit);
            return _grid.SetY(y);
        }

        private Result MoveBackwards(MoveDirection direction)
        {
            if (direction == MoveDirection.North)
            {
                return DecrementYAxis();
            }
            else if (direction == MoveDirection.East)
            {
                return DecrementXAxis();
            }
            else if (direction == MoveDirection.South)
            {
                return IncrementYAxis();
            }
            else if (direction == MoveDirection.West)
            {
                return IncrementXAxis();
            }

            throw new ArgumentException();
        }

        private Result MoveForward(MoveDirection direction)
        {
            if (direction == MoveDirection.North)
            {
                return IncrementYAxis();
            }
            else if (direction == MoveDirection.East)
            {
                return IncrementXAxis();
            }
            else if (direction == MoveDirection.South)
            {
                return DecrementYAxis();
            }
            else if (direction == MoveDirection.West)
            {
                return DecrementXAxis();
            }

            throw new ArgumentException();
        }
    }
}