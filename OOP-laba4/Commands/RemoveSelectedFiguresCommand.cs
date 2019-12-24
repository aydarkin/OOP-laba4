using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    public class RemoveSelectedFiguresCommand : ICommand
    {
        Storage<Figure> figures;
        Storage<Figure> deletedFigures;
        public RemoveSelectedFiguresCommand(Storage<Figure> figures)
        {
            deletedFigures = new Storage<Figure>();
            this.figures = figures;
        }

        public ICommand Clone()
        {
            var com = new RemoveSelectedFiguresCommand(figures);
            com.deletedFigures = deletedFigures;
            return com;
        }

        public void Execute()
        {
            

            for(var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                if (it.GetCurrent().Value.Selected)
                {
                    deletedFigures.AddLast(it.GetCurrent().Value);
                    figures.Remove(it.GetCurrent().Value);
                }                            
            }
        }

        public void Unexecute()
        {
            for(var it = deletedFigures.CreateIterator(); !it.EOL; it.Next())
            {
                figures.AddLast(it.GetCurrent().Value);
            }
        }
    }
}
