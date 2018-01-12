using System;
using System.Linq;
using LR01.interfaces;
using LR01.structures;

namespace LR01.classes
{
    /*
     * Прямая
     */
    class Straight : IFigure
    {
        private System.Drawing.Color color;

        public System.Drawing.Color Color
        {
            get => this.color;
            set => this.color = value == null ? System.Drawing.Color.Black : value;
        }
        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public Straight() : this(new Point(0, 0), new Point(1, 1)) { }
        public Straight(Point startPoint, Point endPoint, System.Drawing.Color color)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Color = color;
        }
        public Straight(Point startPoint, Point endPoint) : this(startPoint, endPoint, System.Drawing.Color.Black) { }

        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawLine(new System.Drawing.Pen(this.Color), this.StartPoint.X, this.StartPoint.Y, this.EndPoint.X, this.EndPoint.Y);
        }
    }
}
