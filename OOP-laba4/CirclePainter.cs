using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    class CirclePainter : Painter
    {
        public CirclePainter(Graphics g) : base(g) { }

        public override void Paint(Figure figure)
        {
            var circle = figure as Circle;

            //после добавления перемещения по полотну больше требуется
            //if (circle.Radius > circle.X)
            //    circle.X = circle.Radius;
            //if (circle.Radius > circle.Y)
            //    circle.Y = circle.Radius;

            graphics.FillEllipse(new SolidBrush(circle.Color), circle.X - circle.Radius, circle.Y - circle.Radius, 2 * circle.Radius, 2 * circle.Radius);

            if (circle.Selected)
                graphics.DrawEllipse(new Pen(circle.StrokeColor, 3), circle.X - circle.Radius, circle.Y - circle.Radius, 2 * circle.Radius, 2 * circle.Radius);
        }
    }
}
