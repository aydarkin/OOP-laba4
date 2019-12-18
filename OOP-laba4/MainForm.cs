using OOP_laba4.Factories;
using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = OOP_laba4.Figures.Rectangle;

namespace OOP_laba4
{
    public partial class MainForm : Form
    {
        public Storage<Figure> FigureStorage;
        Figure bufferFigure;

        public MainForm()
        {
            InitializeComponent();
            FigureStorage = new Storage<Figure>();

            DoubleBuffered = true;

            //PaintPanel.DoubleBuffered = true;
            //механизм рефлексии
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null, PaintPanel, new object[] { true });
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TranslateTransform(OffsetPaintBox.X, OffsetPaintBox.Y);

            for(FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                FigureStorage.Current().Paint(g);
            }
        }

        private void PaintPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(!SelectFigure(e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y))
                {
                    if (EllipseRB.Checked)
                        FigureStorage.AddLast(new Ellipse(e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y, (int)WidthNum.Value, (int)HeightNum.Value));
                    if (RectangleRB.Checked)
                        FigureStorage.AddLast(new Rectangle(e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y, (int)WidthNum.Value, (int)HeightNum.Value));
                }        

                //вызов onPaint
                PaintPanel.Refresh();
            }   
        }

        

        protected bool SelectFigure(int x, int y)
        {
            for (FigureStorage.Last(); !FigureStorage.EOL; FigureStorage.Prev())
            {
                bufferFigure = FigureStorage.Current();

                if (bufferFigure.isPointInFigure(x, y))
                {
                    if (bufferFigure.Selected)
                        bufferFigure.Deselect();
                    else
                        bufferFigure.Select();
                    PaintPanel.Refresh();
                    return true;
                }
            }
            return false;
        }  

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveSelectedFigures();
        }

        private void RemoveSelectedFigures()
        {
            FigureStorage.First();

            while (!FigureStorage.EOL)
            {
                if (FigureStorage.Current().Selected)
                    FigureStorage.Remove();
                else
                    FigureStorage.Next();
            }
        }

        private void SetColorBtn_Click(object sender, EventArgs e)
        {
            SetColorSelectedFigures();
        }

        private void SetColorSelectedFigures()
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
                {
                    bufferFigure = FigureStorage.Current();
                    if(bufferFigure.Selected)
                        bufferFigure.Color = colorDialog.Color;
                }
                PaintPanel.Refresh();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    TransferFigures(Directions.Up);
                    break;
                case Keys.A:
                    TransferFigures(Directions.Left);
                    break;
                case Keys.S:
                    TransferFigures(Directions.Down);
                    break;
                case Keys.D:
                    TransferFigures(Directions.Right);
                    break;
                case Keys.Delete:
                    RemoveSelectedFigures();
                    break;
            }
        }

        public enum Directions
        {
            Left,
            Right,
            Up,
            Down
        }

        //шаг перемещения фигур (px)
        int FigureStep = 5;
        public void TransferFigures(Directions direction)
        {
            int dx = 0;
            int dy = 0;
            switch (direction)
            {
                case Directions.Up:
                    dy = -FigureStep;
                    break;
                case Directions.Down:
                    dy = FigureStep;
                    break;
                case Directions.Left:
                    dx = -FigureStep;
                    break;
                case Directions.Right:
                    dx = FigureStep;
                    break;
            }

            for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                bufferFigure = FigureStorage.Current();
                if (bufferFigure.Selected)
                {
                    if(CheckBeyonds.Checked)
                        bufferFigure.Move(dx, dy, -OffsetPaintBox.X, -OffsetPaintBox.Y, -OffsetPaintBox.X + PaintPanel.Width, -OffsetPaintBox.Y + PaintPanel.Height);
                    else
                        bufferFigure.Move(dx, dy);
                }
            }
            PaintPanel.Refresh();
        }

        private Point startPointOffset; //начальный сдвиг при движении
        private Point startDrag; //начало движения на панели

        public Point OffsetPaintBox = Point.Empty; //сдвиг начала кординат полотна рисования

        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Middle)
            {
                OffsetPaintBox.X = startPointOffset.X + (e.Location.X - startDrag.X);
                OffsetPaintBox.Y = startPointOffset.Y + (e.Location.Y - startDrag.Y);

                BeginCoordLbl.Text = $"Начало координат: {OffsetPaintBox.X}, {OffsetPaintBox.Y}";

                PaintPanel.Refresh();
            }
            CoordsLbl.Text = $"x:{startPointOffset.X + e.Location.X}, y:{startPointOffset.Y + e.Location.Y}";
        }

        private void PaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startDrag.X = e.Location.X;
            startDrag.Y = e.Location.Y;
            startPointOffset.X = OffsetPaintBox.X;
            startPointOffset.Y = OffsetPaintBox.Y;
        }

        private void удалитьВыделенныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedFigures();
            PaintPanel.Refresh();
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorSelectedFigures();
            PaintPanel.Refresh();
        }

        private void SetSizeBtn_Click(object sender, EventArgs e)
        {
            SetSizeSelectedFigures();
            PaintPanel.Refresh();
        }

        private void SetSizeSelectedFigures()
        {
            for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                bufferFigure = FigureStorage.Current();
                if (bufferFigure.Selected)
                {
                    if (bufferFigure is Ellipse ellipse)
                    {
                        ellipse.Width = (int)WidthNum.Value;
                        ellipse.Height = (int)HeightNum.Value;
                    }     
                    if (bufferFigure is Rectangle rectangle)
                    {
                        rectangle.Width  = (int)WidthNum.Value;
                        rectangle.Height = (int)HeightNum.Value;
                    }
                }
            } 
        }

        public void LoadFigures()
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    FigureStorage.Clear();
                    var count = Convert.ToInt32(sr.ReadLine());
                    IFigureFactory factory = new FigureFactory();
                    Figure figure;
                    for (int i = 0; i < count; i++)
                    {
                        var code = sr.ReadLine();
                        figure = factory.CreateFigure(code);
                        figure.Load(sr);
                        FigureStorage.AddLast(figure);
                    }
                }
            }
   
        }

        public void SaveFigures()
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(FigureStorage.Count);
                    for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
                        FigureStorage.Current().Save(sw);
                }
            }
        }

        public void GroupFigures()
        {
            var group = new GroupedFigures();
            group.Select();
            for (FigureStorage.First(); !FigureStorage.EOL; )
            {
                bufferFigure = FigureStorage.Current();
                if (bufferFigure.Selected)
                {
                    group.Add(bufferFigure);
                    FigureStorage.Remove();
                }
                else
                    FigureStorage.Next();
            }

            if (group.Count > 0)
                FigureStorage.AddLast(group);
        }

        public void UngroupFigures()
        {
            for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                bufferFigure = FigureStorage.Current();
                if (bufferFigure.Selected)
                {
                    if (bufferFigure is GroupedFigures group)
                    {
                        FigureStorage.Insert(group.figures, bufferFigure);
                    }
                }
            }
            //вынужденная мера, нужно некое подобие итератора
            for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                if (FigureStorage.Current().Selected)
                {
                    if (FigureStorage.Current() is GroupedFigures group)
                    {
                        FigureStorage.Remove();
                    }
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            PaintPanel.Refresh();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message =
                "Средняя кнопка мыши - перемещение по холсту \n" +
                "Del - удалить выделенные объекты \n" +
                "Crtl+Z - отмена последнего действия \n" +
                "Crtl+Y - повтор отмененного действия \n";
            MessageBox.Show(message, "Справка");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFigures();
            PaintPanel.Refresh();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFigures();
            PaintPanel.Refresh();
        }

        private void GroupBtn_Click(object sender, EventArgs e)
        {
            GroupFigures();
            PaintPanel.Refresh();
        }

        private void UngroupBtn_Click(object sender, EventArgs e)
        {
            UngroupFigures();
            PaintPanel.Refresh();
        }
    }
}
