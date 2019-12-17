﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    public abstract class Figure
    {
        public int X;
        public int Y;

        public bool Selected;
        public void Select()
        {
            Selected = true;
        }
        public void Deselect()
        {
            Selected = false;
        }

        public Color Color = Color.Coral;
        public Color StrokeColor = StrokeColorDefault;

        public static Color StrokeColorDefault = Color.Black;

        public abstract void Paint(Graphics g);
        public abstract void Paint(Graphics g, int leftLimite, int upLimite, int rightLimite, int downLimite);
        public abstract bool isPointInFigure(int x, int y);
    }
}
