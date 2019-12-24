using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    class UngroupSelectedFiguresCommand : ICommand
    {
        Storage<Figure> figures;
        Storage<Figure> ungroupedFigures;

        public UngroupSelectedFiguresCommand(Storage<Figure> figures)
        {
            this.figures = figures;
            ungroupedFigures = new Storage<Figure>();
        }

        public ICommand Clone()
        {
            var com = new UngroupSelectedFiguresCommand(figures);
            com.ungroupedFigures = ungroupedFigures;
            return com;
        }

        public void Execute()
        {
            for (var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                var bufferFigure = it.GetCurrent().Value;
                if (bufferFigure.Selected && bufferFigure is GroupedFigures group)
                {
                    figures.Insert(group.figures, group);
                    ungroupedFigures.Insert(group.figures);
                    figures.Remove(group);
                }   
            }
            figures.NotifyAll();
        }

        public void Unexecute()
        {
            var group = new GroupedFigures();
            group.Select();
            for (var it = ungroupedFigures.CreateIterator(); !it.EOL; it.Next())
            {
                var bufferFigure = it.GetCurrent().Value;
                if (bufferFigure.isSticky)
                {
                    bufferFigure.RemoveAllObserver();
                }
                group.Add(bufferFigure);
                figures.Remove(bufferFigure);
            }

            if (group.Count > 0)
                figures.AddLast(group);
        }
    }
}
