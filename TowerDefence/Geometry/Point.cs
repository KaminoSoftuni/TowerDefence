

namespace TowerDefence.Geometry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public struct Point
    {
        private int x;
        private int y;

        public Point(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
