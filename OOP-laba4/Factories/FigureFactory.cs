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
        public Figure CreateFigure(string nameFigure)
        {
            switch (nameFigure)
            {
                case "R":
                case "Rectangle":
                    return new Rectangle();
                case "E":
                case "Ellipse":
                    return new Ellipse();
                case "Group":
                    return new GroupedFigures();
                case "T":
                case "Triangle":
                    //
                default:
                    return null;
            }
        }
    }
}
