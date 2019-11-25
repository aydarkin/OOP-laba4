using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    class RectanglePainter : Painter
    {
        public RectanglePainter(Graphics g) : base(g) { }

        public override void Paint(Figure figure)
        {
            var rectangle = figure as Rectangle;

            graphics.FillRectangle(new SolidBrush(rectangle.Color), rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            if (rectangle.Selected)
                graphics.DrawRectangle(new Pen(rectangle.StrokeColor, 3), rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
    }
}
