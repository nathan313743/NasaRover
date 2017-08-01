using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaRover
{
    public class Grid
    {
        private int _x;
        private int _y;
        private int _xBlock = -1;
        private int _yBlock = -1;

        public Grid(int xLimit, int yLimit, Position currentPosition)
        {
            XLimit = xLimit;
            YLimit = yLimit;
            _x = currentPosition.X;
            _y = currentPosition.Y;
        }

        public Grid(
            int xLimit,
            int yLimit,
            Position currentPosition,
            int xBlock,
            int yBlock
            ) : this(xLimit, yLimit, currentPosition)
        {
            _xBlock = xBlock;
            _yBlock = yBlock;
        }

        public Position CurrentPosition => new Position(_x, _y);

        public int XLimit { get; private set; }

        public int YLimit { get; private set; }

        public Result SetX(int x)
        {
            if (x == _xBlock)
            {
                return Result.Fail();
            }
            _x = x;

            return Result.Ok();
        }

        public Result SetY(int y)
        {
            if (y == _yBlock)
            {
                return Result.Fail();
            }

            _y = y;
            return Result.Ok();
        }
    }
}