using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    class GroupSelectedFiguresCommand : ICommand
    {
        Storage<Figure> figures;
        GroupedFigures group;
        Dictionary<Figure, List<IObserver>> figureObservers;

        public GroupSelectedFiguresCommand(Storage<Figure> figures)
        {
            this.figures = figures;
        }

        public ICommand Clone()
        {
            var com = new GroupSelectedFiguresCommand(figures);
            com.group = group;
            com.figureObservers = figureObservers;
            return com;
        }

        public void Execute()
        {
            group = new GroupedFigures();
            figureObservers = new Dictionary<Figure, List<IObserver>>();
            group.Select();
            for (var it = figures.CreateIterator(); !it.EOL; )
            {
                var bufferFigure = it.GetCurrent().Value;
                if (bufferFigure.Selected)
                {
                    if (bufferFigure.isSticky)
                    {
                        figureObservers.Add(bufferFigure, new List<IObserver>(bufferFigure.GetObservers()));
                        bufferFigure.RemoveAllObserver();
                    }  
                    group.Add(bufferFigure);
                    figures.Remove(bufferFigure);
                }
                else
                    it.Next();
            }
            if (group.Count > 0)
                figures.AddLast(group);
            else
                group = null;
            figures.NotifyAll();
        }

        public void Unexecute()
        {
            for (var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                var bufferFigure = it.GetCurrent().Value;
                if (bufferFigure.Equals(group))
                {
                    figures.Insert(group.figures, group);
                    for (var f = group.figures.CreateIterator(); !f.EOL; f.Next())
                    {
                        if (f.GetCurrent().Value.isSticky)
                        {
                            foreach (var item in figureObservers)
                            {
                                foreach (var ob in item.Value)
                                {
                                    item.Key.AddObserver(ob);
                                }
                            }
                        }
                        f.GetCurrent().Value.Select();
                    }     
                    figures.Remove(group);
                }
            }
        }
    }
}
