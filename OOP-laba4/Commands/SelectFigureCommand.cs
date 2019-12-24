using OOP_laba4.Factories;
using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    public class SelectFigureCommand : ICommand
    {
        Storage<Figure> figures;
        int x;
        int y;
        Figure figure;
        bool selected;
        bool oldSelected;

        public SelectFigureCommand(Storage<Figure> figures, int x, int y)
        {
            this.figures = figures;
            this.x = x;
            this.y = y;
        }
        public SelectFigureCommand(Storage<Figure> figures, Figure figure, bool selected)
        {
            this.figures = figures;
            this.figure = figure;
            this.selected = selected;
        }

        public ICommand Clone()
        {
            var com = new SelectFigureCommand(figures, x, y);
            com.figure = this.figure;
            return com;
        }

        public void Execute()
        {
            if(figure != null)
            {
                oldSelected = figure.Selected;
                figure.Selected = selected;
                return;
            }

            var it = figures.CreateIterator();
            for (it.Last(); !it.EOL; it.Prev())
            {
                figure = it.GetCurrent().Value;
                if (figure.isPointInFigure(x, y))
                {
                    oldSelected = figure.Selected;
                    figure.RevertSelection();
                    figures.NotifyAll();
                    return;
                }
            }
        }

        public void Unexecute()
        {
            figure.Selected = oldSelected;
            figures.NotifyAll();
        }
    }
}