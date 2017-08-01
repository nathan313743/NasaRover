using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRover
{
    public class MovementService
    {
        private readonly DirectionMove _direction;
        private readonly OrientationMove _orientation;
        private readonly Grid _grid;

        public MovementService(Grid grid, DirectionMove direction, OrientationMove orientation)
        {
            _grid = grid;
            _direction = direction;
            _orientation = orientation;
        }

        public MoveDirection Direction { get; private set; }

        public Position CurrentPosition => _grid.CurrentPosition;

        public Result Move(Movement command)
        {
            if (_orientation.IsOrientationChange(command))
            {
                Direction = _orientation.ChangeOrientation(command, this.Direction);
                return Result.Ok();
            }

            return _direction.Move(command, this.Direction);
        }
    }
}