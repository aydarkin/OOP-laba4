using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    interface IIterator<T>
    {
        void First();
        void Last();
        bool EOL { get; }
        StorageNode<T> GetCurrent();
        void SetCurrent(StorageNode<T> value);

        void Next();
        void Prev();
    }
}
