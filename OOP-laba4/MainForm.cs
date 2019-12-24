using OOP_laba4.Commands;
using OOP_laba4.Factories;
using OOP_laba4.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OOP_laba4
{
    public partial class MainForm : Form
    {
        public Storage<Figure> FigureStorage;
        Stack<ICommand> doneCommands;
        Stack<ICommand> undoneCommands;

        public MainForm()
        {
            InitializeComponent();
            FigureStorage = new Storage<Figure>();
            doneCommands = new Stack<ICommand>();
            undoneCommands = new Stack<ICommand>();

            treeViewObserver.Figures = FigureStorage;
            FigureStorage.AddObserver(treeViewObserver);

            //PaintPanel.DoubleBuffered = true;
            //механизм рефлексии
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                | BindingFlags.Instance | BindingFlags.NonPublic, null, PaintPanel, new object[] { true });

            //событие в конструктуре отсутствовало
            PaintPanel.MouseWheel += PaintPanel_MouseWheel;
        }

        void DoCommand(ICommand command)
        {
            undoneCommands.Clear();
            command.Execute();
            doneCommands.Push(command);

            PaintPanel.Refresh();
        }

        void Undo()
        {
            if(doneCommands.Count > 0)
            {
                var command = doneCommands.Pop();
                command.Unexecute();
                undoneCommands.Push(command);
                PaintPanel.Refresh();
            }
            
        }

        void Redo()
        {
            if (undoneCommands.Count > 0)
            {
                var command = undoneCommands.Pop();
                command.Execute();
                doneCommands.Push(command);
                PaintPanel.Refresh();
            }
        }

        private void PaintPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            DoCommand(new SetSizeSelectedFiguresCommand(FigureStorage, e.Delta / 10, e.Delta/10, true));
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
                if (SelectRB.Checked)
                {
                    DoCommand(new SelectFigureCommand(FigureStorage, e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y));
                    return;
                }
                if(EllipseRB.Checked || RectangleRB.Checked || TriangleRB.Checked)
                {
                    CreateFigureOperation(e.X - OffsetPaintBox.X, e.Y - OffsetPaintBox.Y);
                }     
            } 
        }

        protected void CreateFigureOperation(int x, int y)
        {
            string code = string.Empty;

            if (EllipseRB.Checked)
                code = "Ellipse";
            else if (RectangleRB.Checked)
                code = "Rectangle";
            else if (TriangleRB.Checked)
                code = "Triangle";

            if (!string.IsNullOrEmpty(code))
            {
                DoCommand(new CreateFigureCommand(FigureStorage, code, x, y, (int)WidthNum.Value, (int)HeightNum.Value, StickyCheck.Checked));

            }
                
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            DoCommand(new RemoveSelectedFiguresCommand(FigureStorage));
            //RemoveSelectedFigures();
        }

        protected void RemoveSelectedFigures()
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

        protected void SetColorSelectedFigures()
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                DoCommand(new SetColorSelectedFiguresCommand(FigureStorage, colorDialog.Color));
            }
        }

        
        int FigureStep = 5; //шаг перемещения фигур (px)
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    SelectRB.Checked = true;
                    break;
                case Keys.F2:
                    EllipseRB.Checked = true;
                    break;
                case Keys.F3:
                    RectangleRB.Checked = true;
                    break;
                case Keys.F4:
                    TriangleRB.Checked = true;
                    break;
                case Keys.W:
                    if(CheckBeyonds.Checked)
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Up, -OffsetPaintBox.X, -OffsetPaintBox.Y, -OffsetPaintBox.X + PaintPanel.Width, -OffsetPaintBox.Y + PaintPanel.Height));
                    else
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Up));
                    DoCommand(new StickSelectedFiguresCommand(FigureStorage));
                    break;
                case Keys.A:
                    if (CheckBeyonds.Checked)
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Left, -OffsetPaintBox.X, -OffsetPaintBox.Y, -OffsetPaintBox.X + PaintPanel.Width, -OffsetPaintBox.Y + PaintPanel.Height));
                    else
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Left));
                    DoCommand(new StickSelectedFiguresCommand(FigureStorage));
                    break;
                case Keys.S:
                    if (e.Control)
                        SaveFigures();
                    else if (CheckBeyonds.Checked)
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Down, -OffsetPaintBox.X, -OffsetPaintBox.Y, -OffsetPaintBox.X + PaintPanel.Width, -OffsetPaintBox.Y + PaintPanel.Height));
                    else
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Down));
                    DoCommand(new StickSelectedFiguresCommand(FigureStorage));
                    break;
                case Keys.D:
                    if (CheckBeyonds.Checked)
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Right, -OffsetPaintBox.X, -OffsetPaintBox.Y, -OffsetPaintBox.X + PaintPanel.Width, -OffsetPaintBox.Y + PaintPanel.Height));
                    else
                        DoCommand(new TransferFiguresCommand(FigureStorage, FigureStep, Directions.Right));
                    DoCommand(new StickSelectedFiguresCommand(FigureStorage));
                    break;
                case Keys.C:
                    SetColorSelectedFigures();
                    break;
                case Keys.Delete:
                    DoCommand(new RemoveSelectedFiguresCommand(FigureStorage));
                    break;
                case Keys.Z:
                    if (e.Control)
                        Undo();
                    break;
                case Keys.Y:
                    if (e.Control)
                        Redo();
                    break;
                case Keys.G:
                    if (e.Control)
                        DoCommand(new GroupSelectedFiguresCommand(FigureStorage));
                    else if(e.Shift)
                        DoCommand(new UngroupSelectedFiguresCommand(FigureStorage));
                    break;
            }
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
            CoordsLbl.Text = $"x:{OffsetPaintBox.X + e.Location.X}, y:{OffsetPaintBox.Y + e.Location.Y}";
        }

        private void PaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            PaintPanel.Select();
            startDrag.X = e.Location.X;
            startDrag.Y = e.Location.Y;
            startPointOffset.X = OffsetPaintBox.X;
            startPointOffset.Y = OffsetPaintBox.Y;
        }

        private void удалитьВыделенныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoCommand(new RemoveSelectedFiguresCommand(FigureStorage));
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
        }

        private void SetSizeSelectedFigures()
        {
            DoCommand(new SetSizeSelectedFiguresCommand(FigureStorage, (int)WidthNum.Value, (int)HeightNum.Value));
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
        }

        private void GroupBtn_Click(object sender, EventArgs e)
        {
            DoCommand(new GroupSelectedFiguresCommand(FigureStorage));
        }

        private void UngroupBtn_Click(object sender, EventArgs e)
        {
            DoCommand(new UngroupSelectedFiguresCommand(FigureStorage));
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorSelectedFigures();
            PaintPanel.Refresh();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoCommand(new RemoveSelectedFiguresCommand(FigureStorage));
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void сгруппироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoCommand(new GroupSelectedFiguresCommand(FigureStorage));
        }

        private void разгруппироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoCommand(new UngroupSelectedFiguresCommand(FigureStorage));
        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoCommand(new SetSizeSelectedFiguresCommand(FigureStorage, 20, 20, true));
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoCommand(new SetSizeSelectedFiguresCommand(FigureStorage, -20, -20, true));
        }

        private void treeViewObserver_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
        }

        private void treeViewObserver_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.Checked = false;
                return;
            }
            var it = treeViewObserver.Figures.CreateIterator();
            for (int i = 0; i < e.Node.Index; i++)
            {
                it.Next();
            }
            DoCommand(new SelectFigureCommand(treeViewObserver.Figures, it.GetCurrent().Value, e.Node.Checked));
            PaintPanel.Refresh();
        }

        private void SetStickyBtn_Click(object sender, EventArgs e)
        {
            DoCommand(new SetStickySelectedFiguresCommand(FigureStorage, true));
        }

        private void UnsetStickyBtn_Click(object sender, EventArgs e)
        {
            DoCommand(new SetStickySelectedFiguresCommand(FigureStorage, false));
        }
    }
}
