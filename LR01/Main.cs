using LR01.classes;
using LR01.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LR01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private BrokenLine initBrokenLine()
        {
            var broken = new BrokenLine(Color.Red);
            broken.DrawTo(new structures.Point(10, 10));
            broken.DrawTo(new structures.Point(20, 20));
            broken.DrawTo(new structures.Point(30, 10));
            broken.DrawTo(new structures.Point(40, 20));
            return broken;
        }
        private Straight initStraight()
        {
            return new Straight(new structures.Point(40, 40), new structures.Point(100, 40), Color.Yellow);
        }

        private Elipse initElipse()
        {
            return new Elipse(new structures.Point(100, 100), 80, 40, Color.Black);
        }

        private Polygon initPolygon()
        {
            var polygon = new Polygon(Color.Brown);
            polygon.DrawTo(new structures.Point(40, 40));
            polygon.DrawTo(new structures.Point(50, 20));
            polygon.DrawTo(new structures.Point(60, 10));
            polygon.DrawTo(new structures.Point(70, 20));
            polygon.DrawTo(new structures.Point(40, 40));
            return polygon;
        }

        private LR01.classes.Rectangle initRectangle()
        {
            var rectangle = new LR01.classes.Rectangle(Color.Chocolate);
            rectangle.DrawTo(new structures.Point(20,20));
            rectangle.DrawTo(new structures.Point(40, 20));
            rectangle.DrawTo(new structures.Point(40, 40));
            rectangle.DrawTo(new structures.Point(20, 40));
            rectangle.DrawTo(new structures.Point(20, 20));
            return rectangle;
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            List<IFigure> figures = new List<IFigure>();

            figures.Add(initBrokenLine());
            figures.Add(initStraight());
            figures.Add(initElipse());
            figures.Add(initPolygon());
            figures.Add(initRectangle());

            foreach (var figure in figures)
            {
                figure.Draw(g);
            }
        }
    }
}
