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
            X = 0;
            Y = 0;
            Height = DefaultHeight;
            Width = DefaultWidth;
        }

        public Rectangle(int x, int y, int width, int height)
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
            return (x >= this.X - Width / 2) && (y >= this.Y - Height / 2) && (x <= this.X + this.Width / 2) && (y <= this.Y + this.Height / 2);
        }

        public override void Paint(Graphics g)
        {
            var strokeColor = this.StrokeColor;

            if (isSticky)
                strokeColor = Color.LightGreen;

            g.FillRectangle(new SolidBrush(this.Color), X - Width/2, Y - Height/2, Width, Height);
            if (Selected)
                g.DrawRectangle(new Pen(strokeColor, 3), X - Width / 2, Y - Height / 2, Width, Height);
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
            if (X < leftLimite + Width / 2)
                X = leftLimite + Width / 2;
            if (Y < upLimite + Height / 2)
                Y = upLimite + Height / 2;
            if (X > rightLimite - Width / 2)
                X = rightLimite - Width / 2;
            if (Y > downLimite - Width / 2)
                Y = downLimite - Width / 2;
        }
    }
}
