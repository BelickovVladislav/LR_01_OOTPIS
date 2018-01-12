using LR01.interfaces;
using LR01.structures;

namespace LR01.classes
{
    class Elipse : IFigure
    {
        private System.Drawing.Color color;
        private int width, height;
        private Point point;

        public Point Point { get => this.point; set => this.point = value ?? new Point(10, 10); }

        public int Width { get => this.width; set => this.width = value > 1 ? value : 10; }
        public int Height { get => this.height; set => this.height = value > 1 ? value : 10; }
        public System.Drawing.Color Color
        {
            get => this.color;
            set => this.color = value == null ? System.Drawing.Color.Black : value;
        }

        public Elipse() : this(80, 30) { }
        public Elipse(Point point, int width, int height, System.Drawing.Color color)
        {
            this.Point = point;
            this.Width = width;
            this.Height = height;
            this.Color = color;
        }

        public Elipse(int widht, int height) : this(new Point(widht, height), widht, height, System.Drawing.Color.Black) { }



        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawEllipse(new System.Drawing.Pen(this.Color), this.Point.X, this.Point.Y, this.Width, this.Height);
        }
    }
}
