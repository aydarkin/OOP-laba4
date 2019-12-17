﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    public class Ellipse : Figure
    {
        public int Height;
        public int Width;

        public Ellipse(int x, int y, int height, int width)
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
            g.FillEllipse(new SolidBrush(this.Color), X - (Width / 2), Y - (Height / 2), Width, Height);
            if (Selected)
                g.DrawEllipse(new Pen(this.StrokeColor, 3), X - (Width / 2), Y - (Height / 2), Width, Height);
        }
        public override void Paint(Graphics g, int leftLimite, int upLimite, int rightLimite, int downLimite)
        {
            if (Width/2 > X - leftLimite)
                X = leftLimite + Width/2;

            if (Height/2 > Y - upLimite)
                Y = upLimite + Height/2;

            if (X > rightLimite - Width/2)
                X = rightLimite - Width / 2;

            if (Y > downLimite - Height/2)
                Y = downLimite - Height/2;
            Paint(g);
        }

        public override bool isPointInFigure(int x, int y)
        {
            return Math.Pow(x - this.X, 2) / Math.Pow(Width/2, 2) + Math.Pow(y - this.Y, 2) / Math.Pow(Height/2, 2) <= 1;
        }
    }
}