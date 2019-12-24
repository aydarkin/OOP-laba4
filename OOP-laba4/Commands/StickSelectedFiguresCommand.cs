using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    class StickSelectedFiguresCommand : ICommand
    {
        Storage<Figure> figures;
        Storage<Figure> stickFigures;

        public StickSelectedFiguresCommand(Storage<Figure> figures)
        {
            this.figures = figures;
            stickFigures = new Storage<Figure>();
        }
        public ICommand Clone()
        {
            var com = new StickSelectedFiguresCommand(figures);
            com.stickFigures = stickFigures;
            return com;
        }

        public void Execute()
        {
            for (var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                if (it.GetCurrent().Value.Selected)
                {
                    var figure = it.GetCurrent().Value;
                    if(figure.isSticky)
                        Stick(figure);
                    stickFigures.AddLast(figure);
                }
            }
            figures.NotifyAll();
        }

        void Stick(Figure figure)
        {
            for (var f = figures.CreateIterator(); !f.EOL; f.Next())
            {
                var compare = f.GetCurrent().Value;
                var area1 = new System.Drawing.Rectangle(figure.X - figure.Width / 2, figure.Y - figure.Height / 2, figure.Width, figure.Height);
                var area2 = new System.Drawing.Rectangle(compare.X - compare.Width / 2, compare.Y - compare.Height / 2, compare.Width, compare.Height);

                if (!figure.isObserver(compare) && !figure.Equals(compare) && area1.IntersectsWith(area2))
                {
                    for (int i = area1.Left; i <= area1.Right; i++)
                        for (int j = area1.Top; j < area1.Bottom; j++)
                            if (figure.isPointInFigure(i, j) && compare.isPointInFigure(i, j))
                            {
                                figure.AddObserver(compare);
                                return;
                            }
                }
            }
        }

        public void Unexecute()
        {
            for(var it = stickFigures.CreateIterator(); !it.EOL; it.Next())
            {
                it.GetCurrent().Value.RemoveAllObserver();
                //for (int i = 0; i < it.GetCurrent().Value.GetSubjects().Count; i++)
                //{
                //    it.GetCurrent().Value.GetSubjects()[0].RemoveObserver(it.GetCurrent().Value);
                //}
            }           
        }
    }
}
