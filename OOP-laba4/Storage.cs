using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{
    public class Storage<T>
    {
        public class StorageNode
        {
            public StorageNode Next;
            public StorageNode Prev;
            public T Value;

            public StorageNode(T value)
            {
                Value = value;
            }
        }

        private StorageNode first;
        public void First()
        {
            current = first;
        }

        private StorageNode last;
        public void Last()
        {
            current = last;
        }

        private StorageNode current;
        /// <summary>
        /// Получить текущий элемент списка
        /// </summary>
        /// <returns></returns>
        public T Current()
        {
            if (!EOL)
                return current.Value;
            else
                return default(T);
        }

        private int count = 0;
        public int Count { get => count; }

        /// <summary>
        /// Проверка на выход за границы конца/начала списка
        /// </summary>
        public bool EOL => current == null;

        /// <summary>
        /// Сделать текущим следущий элемент списка
        /// </summary>
        public void Next()
        {
            if (!EOL)
                current = current.Next;
        }

        /// <summary>
        /// Сделать текущим предыдущий элемент списка
        /// </summary>
        public void Prev()
        {
            if (!EOL)
                current = current.Prev;
        }

        /// <summary>
        /// Добавляет новый элемент в начало списка
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(T item)
        {
            var newNode = new StorageNode(item);
            if (count == 0)
            {
                current = newNode;
                last = newNode;
            }
            else
            {
                first.Prev = newNode;
                newNode.Next = first;
            }
            first = newNode;
            count++;
        }

        /// <summary>
        /// Добавляет новый элемент в конец списка
        /// </summary>
        /// <param name="item">Новый элемент списка</param>
        public void AddLast(T item)
        {
            var newNode = new StorageNode(item);
            if (count == 0)
            {
                first = newNode;
                current = newNode;
            }
            else
            {
                last.Next = newNode;
                newNode.Prev = last;
            }
            last = newNode;
            count++;
        }

        /// <summary>
        /// Удаляет текущий элемент списка
        /// </summary>
        public void Remove()
        {
            if (!EOL)
            {
                count--;
                if (count == 0)
                {
                    first = null;
                    last = null;
                    current = null;
                }
                else if (current == last)
                {
                    Prev();
                    current.Next = null;
                    last = current;
                }

                else if (current == first)
                {
                    Next();
                    current.Prev = null;
                    first = current;
                }
                else
                {
                    current.Next.Prev = current.Prev;
                    current.Prev.Next = current.Next;
                    Next();
                }
            }
        }

    }
}
