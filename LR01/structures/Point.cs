using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR01.structures
{
    class Point
    {

        private int x;
        private int y;


        public int X { get => this.x; set => this.x = value >= 0 ? value : 0; }
        public int Y { get => this.y; set => this.y = value >= 0 ? value : 0; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

      
    }
}
