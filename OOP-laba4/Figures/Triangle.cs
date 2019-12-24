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
    class Triangle : Figure
    {
        public static int DefaultWidth = 10;
        public static int DefaultHeight = 10;

        public Triangle()
        {
            X = 0;
            Y = 0;
            Height = DefaultHeight;
            Width = DefaultWidth;
        }

        public Triangle(int x, int y, int width, int height) : base(x, y, width, height) { }

        public Triangle(int x, int y, int height, int width, Color color) : base(x, y, height, width, color) { }

        float topX  { get { return X; } }
        float topY { get { return Y - Height / 2; } }
        float leftX { get { return X - Width / 2; } }
        float leftY { get { return Y + Height / 2; } }
        float rightX { get { return X + Width / 2; } }
        float rightY { get { return Y + Height / 2; } }

        public override bool isPointInFigure(int x, int y)
        {
            return (topY - leftY) * x + (leftX - topX) * y + topX * leftY - leftX * topY <= 0
                && (topY - rightY) * x + (rightX - topX) * y + topX * rightY - rightX * topY >= 0
                && (rightY - leftY) * x + (leftX - rightX) * y + rightX * leftY - leftX * rightY >= 0;
        }

        public override void Paint(Graphics g)
        {
            var color = this.Color;

            if (isSticky)
                color = Color.LightGreen;

            var path = new GraphicsPath();

            path.AddLine(topX, topY, leftX, leftY);
            path.AddLine(leftX, leftY, rightX, rightY);
            path.AddLine(rightX, rightY, topX, topY);

            g.FillPath(new SolidBrush(color), path);
            if (Selected)
                g.DrawPath(new Pen(StrokeColor, 3), path);
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Triangle");
            base.Save(sw);
        }

        public override string ToString()
        {
            return isSticky ? "Sticky Triangle" : "Triangle";
        }
    }
}
