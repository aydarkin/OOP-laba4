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
            var it = figures.CreateIterator();
            for (it.Last(); !it.EOL; it.Prev())
            {
                figure = it.GetCurrent().Value;
                if (figure.isPointInFigure(x, y))
                {
                    selected = !figure.Selected;
                    return;
                }          
            }

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
            com.selected = selected;
            com.oldSelected = oldSelected;
            com.figure = figure;
            return com;
        }

        public void Execute()
        {
            if(figure != null)
            {
                oldSelected = figure.Selected;
                figure.Selected = selected;
                figures.NotifyAll();
            }  
        }

        public void Unexecute()
        {
            if (figure != null)
            {
                figure.Selected = oldSelected;
                figures.NotifyAll();
            }
                
        }
    }
}