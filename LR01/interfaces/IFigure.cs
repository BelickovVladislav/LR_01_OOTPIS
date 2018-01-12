using LR01.classes;
using LR01.structures;

namespace LR01.interfaces
{
    interface IFigure
    {
        System.Drawing.Color Color { get; set; }


        void Draw(System.Drawing.Graphics g);
    }
}
