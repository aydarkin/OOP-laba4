using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Figures
{
    class Rectangle : Figure
    {
        public static int DefaultWidth = 10;
        public static int DefaultHeight = 10;

        public Rectangle()
        {
            Height = DefaultHeight;
            Width = DefaultWidth;
        }

        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height) { }

        public Rectangle(int x, int y, int height, int width, Color color) : base(x, y, height, width, color) { }

        public override bool isPointInFigure(int x, int y)
        {
            return (x >= this.X - Width / 2) && (y >= this.Y - Height / 2) && (x <= this.X + this.Width / 2) && (y <= this.Y + this.Height / 2);
        }

        public override void Paint(Graphics g)
        {
            var color = this.Color;

            if (isSticky)
                color = Color.LightGreen;

            g.FillRectangle(new SolidBrush(color), X - Width/2, Y - Height/2, Width, Height);
            if (Selected)
                g.DrawRectangle(new Pen(StrokeColor, 3), X - Width / 2, Y - Height / 2, Width, Height);
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Rectangle");
            base.Save(sw);
        }

        public override string ToString()
        {
            return isSticky ? "Sticky Rectangle" : "Rectangle";
        }
    }
}
