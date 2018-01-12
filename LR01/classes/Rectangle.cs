using System.Collections.Generic;
using LR01.interfaces;
using LR01.structures;

namespace LR01.classes
{
    class Rectangle : Polygon, IFigure
    {
        private List<Point> listPoints = new List<Point>();

        public Rectangle(System.Drawing.Color color) : base(color)
        {
        }

        public override void DrawTo(Point point)
        {
            base.DrawTo(point);
            listPoints.Add(point);

        }

        private bool isValidRectangle()
        {
            for (int i = 1; i < listPoints.Count; i++)
            {
                bool valid = (listPoints[i - 1].X == listPoints[i].X && listPoints[i - 1].Y != listPoints[i].Y) ||
                             (listPoints[i - 1].Y == listPoints[i].Y && listPoints[i - 1].X != listPoints[i].X);
                if (!valid)
                {
                    return false;
                }
            }
            return true;
        }

        protected override bool isValidFigure()
        {
            if (line.CountLines != 4 || !base.isValidFigure())
            {
                return false;
            }

            return isValidRectangle();

        }
    }
}
