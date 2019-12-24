using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    class TransferFiguresCommand : ICommand
    {
        struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        Storage<Figure> figures;
        Dictionary<Figure, Point> transferedFigures;
        int dx;
        int dy;
        bool isFit;
        int left;
        int right;
        int up;
        int down;
        public TransferFiguresCommand(Storage<Figure> figures, int dx, int dy)
        {
            transferedFigures = new Dictionary<Figure, Point>();
            this.figures = figures;
            this.dx = dx;
            this.dy = dy;
        }

        public TransferFiguresCommand(Storage<Figure> figures, int step, Directions direction)
        {
            transferedFigures = new Dictionary<Figure, Point>();
            this.figures = figures;
            this.dx = 0;
            this.dy = 0;
            switch (direction)
            {
                case Directions.Up:
                    this.dy = -step;
                    break;
                case Directions.Down:
                    this.dy = step;
                    break;
                case Directions.Left:
                    this.dx = -step;
                    break;
                case Directions.Right:
                    this.dx = step;
                    break;
            }
            this.isFit = false;
        }
        public TransferFiguresCommand(Storage<Figure> figures, int step, Directions direction, int left, int up, int right, int down) : this(figures, step, direction)
        {
            this.isFit = true;
            this.left = left;
            this.up = up;
            this.right = right;
            this.down = down;

        }

        public ICommand Clone()
        {
            var com = new TransferFiguresCommand(figures, dx, dy);
            com.isFit = isFit;
            com.left = left;
            com.up = up;
            com.right = right;
            com.down = down;
            com.transferedFigures = transferedFigures;
            return com;
        }

        List<IObserver> bufferObservers = new List<IObserver>();
        public void Execute()
        {
            for (var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                if (it.GetCurrent().Value.Selected)
                {
                    var figure = it.GetCurrent().Value;

                    for (int i = 0; i < figure.GetSubjects().Count; i++)
                    {
                        figure.GetSubjects()[0].RemoveObserver(figure);
                    }

                    transferedFigures.Add(figure, new Point(figure.X, figure.Y));
                    figure.Move(dx, dy);
                    if (isFit)
                        figure.Fit(left, up, right, down);
                }
            }
            figures.NotifyAll();
        }


        public void Unexecute()
        {
            foreach(var f in transferedFigures)
            {
                if(f.Key is GroupedFigures)
                    //здесь проблема, временное решение
                    f.Key.Move(f.Value.X - f.Key.X, f.Value.Y - f.Key.Y);
                else
                {
                    f.Key.X = f.Value.X;
                    f.Key.Y = f.Value.Y;
                }
                
            }
            figures.NotifyAll();
        }
    }
}
