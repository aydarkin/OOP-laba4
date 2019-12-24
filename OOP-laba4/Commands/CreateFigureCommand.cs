using OOP_laba4.Factories;
using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    public class CreateFigureCommand : ICommand
    {
        Storage<Figure> figures;
        string code;
        int x;
        int y;
        int width;
        int height;
        bool isSticky;
        Figure figure;

        public CreateFigureCommand(Storage<Figure> figures, string code, int x, int y, int width, int height, bool isSticky)
        {
            this.figures = figures;
            this.code = code;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.isSticky = isSticky;
        }
        public ICommand Clone()
        {
            var com = new CreateFigureCommand(figures, code, x, y, width, height, isSticky);
            com.figure = this.figure;
            return com;
        }

        public void Execute()
        {
            var factory = new FigureFactory();
            figure = factory.CreateFigure(code, x, y, width, height);
            if (isSticky)
                figure.SetSticky();
            figures.AddLast(figure);
        }

        public void Unexecute()
        {
            figures.Remove(figure);
        }
    }
}
