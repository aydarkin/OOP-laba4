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
            X = 0;
            Y = 0;
            Height = DefaultHeight;
            Width = DefaultWidth;
        }

        public Ellipse(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public Ellipse(int x, int y, int height, int width, Color color) : this(x, y, height, width)
        {
            Color = color;
        }

        public override void Paint(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var strokeColor = this.StrokeColor;

            if (isSticky)
                strokeColor = Color.LightGreen;

            g.FillEllipse(new SolidBrush(this.Color), X - (Width / 2), Y - (Height / 2), Width, Height);
            if (Selected)
                g.DrawEllipse(new Pen(strokeColor, 3), X - (Width / 2), Y - (Height / 2), Width, Height);
        }


        public override bool isPointInFigure(int x, int y)
        {
            return Math.Pow(x - this.X, 2) / Math.Pow(Width/2, 2) + Math.Pow(y - this.Y, 2) / Math.Pow(Height/2, 2) <= 1;
        }

        public override void Load(StreamReader sr)
        {
            X = Convert.ToInt32(sr.ReadLine());
            Y = Convert.ToInt32(sr.ReadLine());
            Width = Convert.ToInt32(sr.ReadLine());
            Height = Convert.ToInt32(sr.ReadLine());
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("E");
            sw.WriteLine(X);
            sw.WriteLine(Y);
            sw.WriteLine(Width);
            sw.WriteLine(Height);
        }

        public override void Move(int dx, int dy, int leftLimite, int upLimite, int rightLimite, int downLimite)
        {
            Move(dx, dy);
            if (Width / 2 > X - leftLimite)
                X = leftLimite + Width / 2;

            if (Height / 2 > Y - upLimite)
                Y = upLimite + Height / 2;

            if (X > rightLimite - Width / 2)
                X = rightLimite - Width / 2;

            if (Y > downLimite - Height / 2)
                Y = downLimite - Height / 2;
        }
    }
}
