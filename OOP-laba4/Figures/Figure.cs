using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba4.Figures
{
    public abstract class Figure: ITextLoad, ITextSave, IObservable, IObserver
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public bool Selected;
        public bool isSticky { get; protected set; }

        public Color Color = Color.Coral;
        public Color StrokeColor = StrokeColorDefault;

        public static Color StrokeColorDefault = Color.Black;

        public Figure()
        {
            X = 0;
            Y = 0;
            Width = 0;
            Height = 0;
        }


        public Figure(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public Figure(int x, int y, int height, int width, Color color) : this(x, y, height, width)
        {
            Color = color;
        }

        public void Select()
        {
            Selected = true;
        }
        public void Deselect()
        {
            Selected = false;
        }

        public virtual void SetSticky()
        {
            isSticky = true;
        }
        public virtual void UnsetSticky()
        {
            RemoveAllObserver();
            isSticky = false;
        }

        public void RevertSelection()
        {
            Selected = !Selected;
        }

        public virtual void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
            NotifyAll("Move", new object[] { dx, dy });
        }

        public virtual void SetColor(Color color)
        {
            this.Color = color;
        }

        public virtual void Fit(int leftLimite, int upLimite, int rightLimite, int downLimite) 
        {
            int oldX = X;
            int oldY = Y;

            if (X < leftLimite + Width / 2)
                X = leftLimite + Width / 2;
            if (Y < upLimite + Height / 2)
                Y = upLimite + Height / 2;
            if (X > rightLimite - Width / 2)
                X = rightLimite - Width / 2;
            if (Y > downLimite - Width / 2)
                Y = downLimite - Width / 2;

            NotifyAll("Move", new object[] { X - oldX, Y - oldY });
        }

        public virtual void Resize(int width, int height, bool isAdditional = false)
        {
            if (isAdditional)
            {
                Width += width;
                Height += height;
            }
            else
            {
                Width = width;
                Height = height;
            }

            Width = Math.Abs(Width);
            Height = Math.Abs(Height);
        }

        public abstract void Paint(Graphics g);
        public abstract bool isPointInFigure(int x, int y);
        public virtual void Load(StreamReader sr)
        {
            X = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            Y = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            Width = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            Height = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            Color = Color.FromArgb(Convert.ToInt32(sr.ReadLine().Split('=')[1]));
            StrokeColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine().Split('=')[1]));
            isSticky = Convert.ToBoolean(sr.ReadLine().Split('=')[1]);
        }
        public virtual void Save(StreamWriter sw)
        {
            sw.WriteLine($"x={X}");
            sw.WriteLine($"y={Y}");
            sw.WriteLine($"width={Width}");
            sw.WriteLine($"height={Height}");
            sw.WriteLine($"color={Color.ToArgb()}");
            sw.WriteLine($"stroke={StrokeColor.ToArgb()}");
            sw.WriteLine($"is_sticky={isSticky}");
        }

        List<IObserver> observers = new List<IObserver>();
        List<IObservable> subjects = new List<IObservable>();

        public List<IObservable> GetSubjects()
        {
            return subjects;
        }


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
                ob.OnPropertyChanged(this, property, args);
            }
        }

        public virtual void OnPropertyChanged(IObservable subject, string property = null, object[] args = null)
        {
            if(property == "Move")
            {
                int dx = (int)args[0];
                int dy = (int)args[1];

                Move(dx, dy);
            }
        }

        public bool isObserver(IObserver observer)
        {
            return observers.Contains(observer);
        }

        public void RemoveAllObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                RemoveObserver(observers[0]);
            }
        }

        public List<IObserver> GetObservers()
        {
            return observers;
        }
    }
}
