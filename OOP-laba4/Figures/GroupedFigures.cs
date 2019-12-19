using OOP_laba4.Factories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Figures
{
    class GroupedFigures : Figure
    {
        public Storage<Figure> figures;
       
        public GroupedFigures()
        {
            figures = new Storage<Figure>();
        }

        public int Count { get => figures.Count; }

        public void Add(Figure figure)
        {
            figure.Deselect();
            figures.AddLast(figure);
            setSize();
        }

        public void Remove(Figure figure)
        {
            figures.Remove(figure);
        }

        public override bool isPointInFigure(int x, int y)
        {
            for (figures.First(); !figures.EOL; figures.Next())
            {
                if (figures.Current().isPointInFigure(x, y))
                    return true;
            }
            return false;
        }

        public override void Load(StreamReader sr)
        {
            figures.Clear();
            var count = Convert.ToInt32(sr.ReadLine());
            IFigureFactory factory = new FigureFactory();
            Figure figure;
            for (int i = 0; i < count; i++)
            {
                var code = sr.ReadLine();
                figure = factory.CreateFigure(code);
                figure.Load(sr);
                Add(figure);
            }
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("Group");
            sw.WriteLine(figures.Count);
            for (figures.First(); !figures.EOL; figures.Next())
            {
                figures.Current().Save(sw);
            }
        }

        public override void Paint(Graphics g)
        {

            for (figures.First(); !figures.EOL; figures.Next())
                figures.Current().Paint(g);

            if (Selected)
            {
                var pen = new Pen(Color.Red, 2f);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, X - Width / 2, Y - Height / 2, Width, Height);
            }
        }

        void setSize()
        {
            int left = Int32.MaxValue, right = 0, up = Int32.MaxValue, down = 0;
            Figure figure = figures.Current();
            for (figures.First(); !figures.EOL; figures.Next())
            {
                figure = figures.Current();

                if (left > figure.X - figure.Width/2)
                    left = figure.X - figure.Width / 2;
                if (right < figure.X + figure.Width / 2)
                    right = figure.X + figure.Width / 2;
                if (up > figure.Y - figure.Height / 2)
                    up = figure.Y - figure.Height / 2;
                if (down < figure.Y + figure.Height / 2)
                    down = figure.Y + figure.Height / 2;
            }

            Width = right - left;
            Height = down - up;
            X = left + Width / 2;
            Y = up + Height / 2;
        }

        public override void Move(int dx, int dy)
        {
            for (figures.First(); !figures.EOL; figures.Next())
                figures.Current().Move(dx, dy);
            setSize();
        }

        public override void Move(int dx, int dy, int leftLimite, int upLimite, int rightLimite, int downLimite)
        {
            int oldX = X;
            int oldY = Y;
            int newX = X + dx; 
            int newY = Y + dy;
            
            if (newX < leftLimite + Width / 2)
                newX = leftLimite + Width / 2;
            if (newY < upLimite + Height / 2)
                newY = upLimite + Height / 2;
            if (newX > rightLimite - Width / 2)
                newX = rightLimite - Width / 2;
            if (newY > downLimite - Width / 2)
                newY = downLimite - Width / 2;

            for (figures.First(); !figures.EOL; figures.Next())
                figures.Current().Move(newX - oldX, newY - oldY);
            X = newX;
            Y = newY;
        }
    }
}
