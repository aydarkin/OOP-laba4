using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Commands
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
        ICommand Clone();
    }
}
