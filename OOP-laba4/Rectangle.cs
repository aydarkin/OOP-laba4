using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    class Rectangle : Figure
    {
        public int Height;
        public int Width;

        public Rectangle(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public Rectangle(int x, int y, int height, int width, Color color) : this(x, y, height, width)
        {
            Color = color;
        }

        public override bool isPointInFigure(int x, int y)
        {
            if ((x >= this.X) && (y >= this.Y) && (x <= this.X + this.Width) && (y <= this.Y + this.Height))
                return true;
            else
                return false;
        }

        public override void Paint(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.Color), X, Y, Width, Height);
            if (Selected)
                g.DrawRectangle(new Pen(this.StrokeColor, 3), X, Y, Width, Height);
        }

        public override void Paint(Graphics g, int leftLimite, int upLimite, int rightLimite, int downLimite)
        {
            //TODO
            Paint(g);
        }
    }
}
