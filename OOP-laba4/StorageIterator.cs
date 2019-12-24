using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    public class StorageIterator<T> : IIterator<T>
    {
        StorageNode<T> current;
        StorageNode<T> first;
        StorageNode<T> last;
        public StorageIterator(StorageNode<T> first, StorageNode<T> last)
        {
            this.first = first;
            this.last = last;
            this.current = this.first;
        }

        public bool EOL { get { return current == null; } }

        public void First()
        {
            current = first;
        }

        public StorageNode<T> GetCurrent()
        {
            return current;
        }

        public void Last()
        {
            current = last;
        }

        public void SetCurrent(StorageNode<T> value)
        {
            current = value;
        }

        public void Next()
        {
            if (!EOL)
                current = current.Next;
        }
        public void Prev()
        {
            if (!EOL)
                current = current.Prev;
        }

    }
}
