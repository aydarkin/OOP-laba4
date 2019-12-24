using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4
{ 
    public class StorageNode<T>
    {
        public StorageNode<T> Next;
        public StorageNode<T> Prev;
        public T Value;

        public StorageNode(T value)
        {
            Value = value;
        }
    }

    public class Storage<T> : IObservable
    {

        public StorageIterator<T> CreateIterator()
        {
            return new StorageIterator<T>(first, last);
        }

        private StorageNode<T> first;
        public StorageNode<T> First()
        {
            current = first;
            return first;
        }

        private StorageNode<T> last;
        public StorageNode<T> Last()
        {
            current = last;
            return last;
        }

        private StorageNode<T> current;
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
            var newNode = new StorageNode<T>(item);
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
            NotifyAll();
        }

        /// <summary>
        /// Добавляет новый элемент в конец списка
        /// </summary>
        /// <param name="item">Новый элемент списка</param>
        public void AddLast(T item)
        {
            var newNode = new StorageNode<T>(item);
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
            NotifyAll();
        }

        /// <summary>
        /// Вставляет элемента после указанного
        /// </summary>
        /// <param name="item">вставляемый элемент</param>
        /// <param name="itemAfter">элемент, после которого идет вставка</param>
        public void Insert(T item, T itemAfter)
        {
            var iter = CreateIterator();
            for (iter.First(); !iter.EOL; iter.Next())
            {
                if (iter.GetCurrent().Value.Equals(itemAfter))
                {
                    var temp = current; 
                    current = iter.GetCurrent();
                    Insert(item);
                    current = temp;
                    NotifyAll();
                    return;
                }
            }
            NotifyAll();
        }

        /// <summary>
        /// Вставляет элемента после текущего
        /// </summary>
        /// <param name="item">вставляемый элемент</param>
        public void Insert(T item)
        {
            var newNode = new StorageNode<T>(item);
            if (count == 0)
            {
                AddLast(item);
                return;
            }

            if (current.Next != null)
            {
                current.Next.Prev = newNode;
                newNode.Next = current.Next;

            }
            else
                last = newNode;

            newNode.Prev = current;
            current.Next = newNode;
            count++;
            NotifyAll();
        }

        /// <summary>
        /// Вставляет список элементов после указанного
        /// </summary>
        /// <param name="items">список вставляемых элементов</param>
        /// <param name="itemAfter">элемент, после которого идет вставка</param>
        public void Insert(Storage<T> items, T itemAfter)
        {
            for(items.Last(); !items.EOL; items.Prev())
            {
                Insert(items.current.Value, itemAfter);
            }
        }

        /// <summary>
        /// Вставляет список элементов после текущего
        /// </summary>
        /// <param name="items">список вставляемых элементов</param>
        public void Insert(Storage<T> items)
        {
            for (items.Last(); !items.EOL; items.Prev())
            {
                Insert(items.current.Value);
            }
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
                NotifyAll();
            }
        }

        /// <summary>
        /// Удаляет указанный элемент из списка
        /// </summary>
        /// <param name="item">удаляемый элемент</param>
        public void Remove(T item)
        {
            var iter = CreateIterator();
            for (iter.First(); !iter.EOL; iter.Next())
            {
                if (iter.GetCurrent().Value.Equals(item))
                {
                    if (current == null)
                        current = first;
                    var temp = current;
                    current = iter.GetCurrent();
                    Remove();
                    current = temp;
                    NotifyAll();
                    return;
                }
            }
        }

        /// <summary>
        /// Заменить элемент другим
        /// </summary>
        /// <param name="oldItem">старый</param>
        /// <param name="newItem">новый</param>
        public void Replace(T oldItem, T newItem)
        {
            var newNode = new StorageNode<T>(newItem);
            var iter = CreateIterator();
            for (iter.First(); !iter.EOL; iter.Next())
            {
                if (iter.GetCurrent().Value.Equals(oldItem))
                {
                    var temp = current;
                    current = iter.GetCurrent();
                    current.Value = newItem;
                    current = temp;
                    NotifyAll();
                    return;
                }
            }

        }

        /// <summary>
        /// Очистить хранилище
        /// </summary>
        public void Clear()
        {
            First();
            while (!EOL)
                Remove();
        }

        List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
            observer.GetSubjects().Add(this);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
            observer.GetSubjects().Remove(this);
        }

        public void NotifyAll(string property = null, object[] args = null)
        {
            foreach (var ob in observers)
            {
                ob.OnPropertyChanged(this);
            }
        }

        public bool isObserver(IObserver observer)
        {
            return observers.Contains(observer);
        }

        public void RemoveAllObserver()
        {
            observers.Clear();
        }
        public List<IObserver> GetObservers()
        {
            return observers;
        }
    }
}
