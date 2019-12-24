using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Figures
{
    public class Ellipse : Figure
    {
        public static int DefaultWidth = 10;
        public static int DefaultHeight = 10;

        public Ellipse()
        {
            Height = DefaultHeight;
            Width = DefaultWidth;
        }

        public Ellipse(int x, int y, int width, int height): base(x, y, width, height) { }

        public Ellipse(int x, int y, int height, int width, Color color) : base(x, y, height, width, color) { }

        public override void Paint(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var color = this.Color;

            if (isSticky)
                color = Color.LightGreen;

            g.FillEllipse(new SolidBrush(color), X - (Width / 2), Y - (Height / 2), Width, Height);
            if (Selected)
                g.DrawEllipse(new Pen(StrokeColor, 3), X - (Width / 2), Y - (Height / 2), Width, Height);
        }


        public override bool isPointInFigure(int x, int y)
        {
            return Math.Pow(x - this.X, 2) / Math.Pow(Width/2, 2) + Math.Pow(y - this.Y, 2) / Math.Pow(Height/2, 2) <= 1;
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Ellipse");
            base.Save(sw);
        }

        public override string ToString()
        {
            return isSticky ? "Sticky Ellipse" : "Ellipse";
        }
    }
}
