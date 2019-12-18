using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Figures
{
    public abstract class Figure: ITextLoad, ITextSave
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public bool Selected;
        public bool isSticky;

        public Color Color = Color.Coral;
        public Color StrokeColor = StrokeColorDefault;

        public static Color StrokeColorDefault = Color.Black; 
        
        public void Select()
        {
            Selected = true;
        }
        public void Deselect()
        {
            Selected = false;
        }

        public virtual void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public abstract void Move(int dx, int dy, int leftLimite, int upLimite, int rightLimite, int downLimite);
        public abstract void Paint(Graphics g);
        public abstract bool isPointInFigure(int x, int y);
        public abstract void Load(StreamReader sr);
        public abstract void Save(StreamWriter sw);
    }
}
