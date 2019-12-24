using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    public class SetColorSelectedFiguresCommand : ICommand
    {
        Storage<Figure> figures;
        Storage<Figure> coloredFigures; //можно было использовать словарь
        Storage<Color> colors;          //
        Color color;
        public SetColorSelectedFiguresCommand(Storage<Figure> figures, Color color)
        {
            coloredFigures = new Storage<Figure>();
            colors = new Storage<Color>();
            this.figures = figures;
            this.color = color;
        }

        public ICommand Clone()
        {
            var com = new SetColorSelectedFiguresCommand(figures, color);
            com.coloredFigures = coloredFigures;
            return com;
        }

        public void Execute()
        {
            for(var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                if (it.GetCurrent().Value.Selected)
                {
                    colors.AddLast(it.GetCurrent().Value.Color);
                    it.GetCurrent().Value.SetColor(color);
                    coloredFigures.AddLast(it.GetCurrent().Value);
                }
            }
            figures.NotifyAll();
        }

        public void Unexecute()
        {
            var it = coloredFigures.CreateIterator();
            var col = colors.CreateIterator();
            for (it.First(), col.First(); !it.EOL; it.Next(), col.Next())
            {
                it.GetCurrent().Value.SetColor(col.GetCurrent().Value);
            }
        }
    }
}
