using System.Collections.Generic;
using System.Linq;
using LR01.structures;
using LR01.interfaces;

namespace LR01.classes
{
    class BrokenLine : IFigure
    {
        private List<Straight> lines = new List<Straight>();
        private System.Drawing.Color color;
        //Минус начальная точка
        public int CountLines { get { return lines.Count > 1 ? lines.Count - 1 : 0; } }
        public System.Drawing.Color Color
        {
            get => this.color;
            set => this.color = value == null? System.Drawing.Color.Black: value;
        }

        public BrokenLine() : this(System.Drawing.Color.Black) { }
        public BrokenLine(System.Drawing.Color color)
        {
            this.Color = color;
        }

        public void DrawTo(Point point)
        {
            Straight straight;
            if (lines.Count == 0)
            {
                straight = new Straight(point, point, this.Color);
            }
            else
            {
                straight = new Straight(lines.Last().EndPoint, point, this.Color);
            }
            lines.Add(straight);
        }

        public void Draw(System.Drawing.Graphics g)
        {
            foreach (var line in this.lines)
            {
                line.Draw(g);
            }
        }
    }
}
