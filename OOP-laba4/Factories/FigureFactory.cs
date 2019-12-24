using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Factories
{
    class FigureFactory : IFigureFactory
    {
        public Figure CreateFigure(string nameFigure, int x = 0, int y = 0, int width = 1, int height = 1)
        {
            Figure figure;
            switch (nameFigure)
            {
                case "R":
                case "Rectangle":
                    figure =  new Rectangle();
                    break;
                case "E":
                case "Ellipse":
                    figure =  new Ellipse();
                    break;
                case "Group":
                    figure = new GroupedFigures();
                    break;
                case "T":
                case "Triangle":
                    figure = new Triangle();
                    break;
                default:
                    return null;
            }
            figure.X = x;
            figure.Y = y;
            figure.Width = width;
            figure.Height = height;
            return figure;
        }
    }
}
