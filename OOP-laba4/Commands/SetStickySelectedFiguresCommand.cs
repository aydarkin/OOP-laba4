using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    class SetStickySelectedFiguresCommand : ICommand
    {
        Storage<Figure> figures;
        Dictionary<Figure, bool> selectedFigures;
        Dictionary<Figure, List<IObserver>> figureObservers;

        bool isSticky;

        public SetStickySelectedFiguresCommand(Storage<Figure> figures, bool isSticky)
        {
            this.figures = figures;
            this.isSticky = isSticky;
            selectedFigures = new Dictionary<Figure, bool>();
            figureObservers = new Dictionary<Figure, List<IObserver>>();
        }

        public ICommand Clone()
        {
            var com = new SetStickySelectedFiguresCommand(figures, isSticky);
            com.selectedFigures = this.selectedFigures;
            com.figureObservers = figureObservers;
            return com;
        }

        public void Execute()
        {
            for (var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                if (it.GetCurrent().Value.Selected)
                {
                    selectedFigures.Add(it.GetCurrent().Value, it.GetCurrent().Value.isSticky);
                    if (isSticky)
                        it.GetCurrent().Value.SetSticky();
                    else
                    {
                        figureObservers.Add(it.GetCurrent().Value, new List<IObserver>(it.GetCurrent().Value.GetObservers()));
                        it.GetCurrent().Value.UnsetSticky();
                    }
                        
                }
            }
            figures.NotifyAll();
        }

        public void Unexecute()
        {
            foreach (var s in selectedFigures)
            {
                if (s.Value)
                {
                    foreach (var item in figureObservers)
                        foreach (var ob in item.Value)
                            s.Key.AddObserver(ob);
                    s.Key.SetSticky();
                }
                else
                    s.Key.UnsetSticky();
            }
            figures.NotifyAll();
        }
    }
}
