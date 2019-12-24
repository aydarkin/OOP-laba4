using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Factories
{
    interface IFigureFactory
    {
        Figure CreateFigure(string nameFigure, int x = 0, int y = 0, int width = 1, int height = 1);
    }
}
