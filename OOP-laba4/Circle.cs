using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    public class Circle : Figure
    {
        public int Radius;

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public Circle(int x, int y, int radius, Color color) : this(x, y, radius)
        {
            Color = color;
        }

        public override bool isPointInFigure(int x, int y)
        {
            return Math.Pow(x - this.X, 2) + Math.Pow(y - this.Y, 2) <= Math.Pow(this.Radius, 2);
        }
    }
}
