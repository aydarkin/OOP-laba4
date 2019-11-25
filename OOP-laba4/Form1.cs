using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_laba4
{
    public partial class Form1 : Form
    {
        public Storage<Figure> FigureStorage;


        public Form1()
        {
            InitializeComponent();
            FigureStorage = new Storage<Figure>();

            DoubleBuffered = true;
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TranslateTransform(OffsetPaintBox.X, OffsetPaintBox.Y);

            Figure figure;
            Painter painter;
            for(FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                figure = FigureStorage.Current();
                if(figure is Circle circle)
                {
                    painter = new CirclePainter(g);
                    painter.Paint(circle);
                }
                if (figure is Rectangle rectangle)
                {
                    painter = new RectanglePainter(g);
                    painter.Paint(rectangle);
                }
            }

            CountLbl.Text = $"Фигур: {FigureStorage.Count}";
        }

        private void PaintPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(!SelectFigure(e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y))
                {
                    if (CircleRB.Checked)
                        FigureStorage.AddLast(new Circle(e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y, (int)RadiusNum.Value));
                    if (RectangleRB.Checked)
                        FigureStorage.AddLast(new Rectangle(e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y, (int)HeightNum.Value, (int)WidthNum.Value));
                }        

                //вызов onPaint
                PaintPanel.Refresh();
            }   
        }

        protected bool SelectFigure(int x, int y)
        {
            Figure figure;
            for (FigureStorage.Last(); !FigureStorage.EOL; FigureStorage.Prev())
            {
                figure = FigureStorage.Current();

                if (figure.isPointInFigure(x, y))
                {
                    if (figure.Selected)
                        figure.Deselect();
                    else
                        figure.Select();
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
            PaintPanel.Refresh();
        }

        private void SetColorBtn_Click(object sender, EventArgs e)
        {
            SetColorSelectedFigures();
        }

        private void SetColorSelectedFigures()
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Figure figure;
                for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
                {
                    figure = FigureStorage.Current();
                    if(figure.Selected)
                        figure.Color = colorDialog.Color;
                }
                PaintPanel.Refresh();
            }
        }

        //шаг перемещения фигур (px)
        const int KEY_STEP = 5;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.A:
                case Keys.S:
                case Keys.D:
                    TransferFigures(e.KeyCode);
                    break;
                case Keys.Delete:
                    RemoveSelectedFigures();
                    break;
            }
            
        }

        public void TransferFigures(Keys keyCode)
        {
            int dx = 0;
            int dy = 0;
            switch (keyCode)
            {
                case Keys.W:
                    dy = -KEY_STEP;
                    break;
                case Keys.S:
                    dy = KEY_STEP;
                    break;
                case Keys.A:
                    dx = -KEY_STEP;
                    break;
                case Keys.D:
                    dx = KEY_STEP;
                    break;
            }

            Figure figure;
            for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                figure = FigureStorage.Current();
                if (figure.Selected)
                {
                    figure.X += dx;
                    figure.Y += dy;
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
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorSelectedFigures();
        }

        private void SetSizeBtn_Click(object sender, EventArgs e)
        {
            SetSizeSelectedFigures();
        }

        private void SetSizeSelectedFigures()
        {
            Figure figure;
            for (FigureStorage.First(); !FigureStorage.EOL; FigureStorage.Next())
            {
                figure = FigureStorage.Current();
                if (figure.Selected)
                {
                    if (figure is Circle circle)
                        circle.Radius = (int)SizeNum.Value;
                    if (figure is Rectangle rectangle)
                    {
                        rectangle.Width  = (int)SizeNum.Value;
                        rectangle.Height = (int)SizeNum.Value;
                    }
                    figure.Deselect();
                }
            }
            PaintPanel.Refresh();
        }
    }
}
