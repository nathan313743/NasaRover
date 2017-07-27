using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundApps
{
    public class Grid
    {
        public Grid(int xLimit, int yLimit, Position currentPosition)
        {
            XLimit = xLimit;
            YLimit = yLimit;
            this.CurrentPosition = currentPosition;
        }

        public Position CurrentPosition { get; set; }

        public int XLimit { get; private set; }

        public int YLimit { get; private set; }
    }
}