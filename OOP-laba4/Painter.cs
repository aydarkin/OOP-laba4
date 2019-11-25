using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    public abstract class Painter
    {
        protected Graphics graphics;
        public Painter(Graphics g)
        {
            graphics = g;
        }

        public virtual void Paint(Figure figure)
        {
            //do nothing =)
        }

    }
}
