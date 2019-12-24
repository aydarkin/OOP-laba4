using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    class SetSizeSelectedFiguresCommand : ICommand
    {
        struct Size
        {
            public int Width;
            public int Height;
            public Size(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }

        Storage<Figure> figures;
        Dictionary<Figure, Size> sizedFigures;
        int width;
        int height;
        bool isAdditional;


        public SetSizeSelectedFiguresCommand(Storage<Figure> figures, int width, int height, bool isAdditional = false)
        {
            this.figures = figures;
            this.width = width;
            this.height = height;
            this.isAdditional = isAdditional;
            sizedFigures = new Dictionary<Figure, Size>(); //я знаю STL :)
       }

        public ICommand Clone()
        {
            var com = new SetSizeSelectedFiguresCommand(figures, width, height, isAdditional);
            com.sizedFigures = sizedFigures;
            return com;
        }

        public void Execute()
        {
            for (var it = figures.CreateIterator(); !it.EOL; it.Next())
            {
                if (it.GetCurrent().Value.Selected)
                {
                    sizedFigures.Add(it.GetCurrent().Value, new Size(it.GetCurrent().Value.Width, it.GetCurrent().Value.Height));
                    if(it.GetCurrent().Value is GroupedFigures group)
                    {
                        ExtractGroup(group);
                    }
                    it.GetCurrent().Value.Resize(width, height, isAdditional);
                }
            }
            figures.NotifyAll();
        }

        void ExtractGroup(GroupedFigures group)
        {
            for (var grit = group.figures.CreateIterator(); !grit.EOL; grit.Next())
            {
                sizedFigures.Add(grit.GetCurrent().Value, new Size(grit.GetCurrent().Value.Width, grit.GetCurrent().Value.Height));
                if (grit.GetCurrent().Value is GroupedFigures gr)
                {
                    ExtractGroup(gr);
                }
            }
        }

        public void Unexecute()
        {
            foreach(var f in sizedFigures)
            {
                f.Key.Width = f.Value.Width;
                f.Key.Height = f.Value.Height;
            }
        }
    }
}
