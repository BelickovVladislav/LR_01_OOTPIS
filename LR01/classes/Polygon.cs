using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR01.structures;
using LR01.interfaces;

namespace LR01.classes
{
    class Polygon : IFigure
    {
        protected BrokenLine line;

        protected Point startPoint;
        protected Point endPoint;

        private System.Drawing.Color color;

        public System.Drawing.Color Color
        {
            get => color;
            set => color = value == null? System.Drawing.Color.Black: value;
        }

        public Polygon() : this(System.Drawing.Color.Black) { }
        public Polygon(System.Drawing.Color color)
        {
            this.Color = color;
            this.line = new BrokenLine(this.Color);
        }

        public virtual void DrawTo(Point point)
        {
            if (this.startPoint == null)
            {
                this.startPoint = point;
            }
            else
            {
                this.endPoint = point;
            }
            this.line.DrawTo(point);
        }

        protected virtual bool isValidFigure()
        {
            return this.startPoint != null && this.endPoint != null && this.startPoint.X == this.endPoint.X && this.startPoint.Y == this.endPoint.Y;
        }

        public void Draw(System.Drawing.Graphics g)
        {
            if (!this.isValidFigure())
            {
                throw new Exception("Invalid figure");
            }
            this.line.Draw(g);
        }
    }
}
