namespace OOP_laba4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьВыделенныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SetColorBtn = new System.Windows.Forms.Button();
            this.ChooseFigureBox = new System.Windows.Forms.GroupBox();
            this.RectangleRB = new System.Windows.Forms.RadioButton();
            this.EllipseRB = new System.Windows.Forms.RadioButton();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.HeightNum = new System.Windows.Forms.NumericUpDown();
            this.BeginCoordLbl = new System.Windows.Forms.Label();
            this.SetSizeBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.CheckBeyonds = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.CoordsLbl = new System.Windows.Forms.ToolStripLabel();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GroupBtn = new System.Windows.Forms.Button();
            this.UngroupBtn = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.ChooseFigureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintPanel
            // 
            this.PaintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintPanel.BackColor = System.Drawing.Color.White;
            this.PaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPanel.ContextMenuStrip = this.contextMenu;
            this.PaintPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PaintPanel.Location = new System.Drawing.Point(199, 50);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(582, 466);
            this.PaintPanel.TabIndex = 0;
            this.PaintPanel.TabStop = true;
            this.PaintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel_Paint);
            this.PaintPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseClick);
            this.PaintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseDown);
            this.PaintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьВыделенныеToolStripMenuItem,
            this.изменитьЦветToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(191, 48);
            // 
            // удалитьВыделенныеToolStripMenuItem
            // 
            this.удалитьВыделенныеToolStripMenuItem.Name = "удалитьВыделенныеToolStripMenuItem";
            this.удалитьВыделенныеToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.удалитьВыделенныеToolStripMenuItem.Text = "Удалить выделенные";
            this.удалитьВыделенныеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыделенныеToolStripMenuItem_Click);
            // 
            // изменитьЦветToolStripMenuItem
            // 
            this.изменитьЦветToolStripMenuItem.Name = "изменитьЦветToolStripMenuItem";
            this.изменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.изменитьЦветToolStripMenuItem.Text = "Изменить цвет";
            this.изменитьЦветToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветToolStripMenuItem_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Location = new System.Drawing.Point(11, 354);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(144, 30);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Удалить выделенные";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Salmon;
            // 
            // SetColorBtn
            // 
            this.SetColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetColorBtn.Location = new System.Drawing.Point(11, 318);
            this.SetColorBtn.Name = "SetColorBtn";
            this.SetColorBtn.Size = new System.Drawing.Size(144, 30);
            this.SetColorBtn.TabIndex = 1;
            this.SetColorBtn.Text = "Изменить цвет";
            this.SetColorBtn.UseVisualStyleBackColor = true;
            this.SetColorBtn.Click += new System.EventHandler(this.SetColorBtn_Click);
            // 
            // ChooseFigureBox
            // 
            this.ChooseFigureBox.Controls.Add(this.RectangleRB);
            this.ChooseFigureBox.Controls.Add(this.EllipseRB);
            this.ChooseFigureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFigureBox.Location = new System.Drawing.Point(11, 50);
            this.ChooseFigureBox.Name = "ChooseFigureBox";
            this.ChooseFigureBox.Size = new System.Drawing.Size(144, 142);
            this.ChooseFigureBox.TabIndex = 2;
            this.ChooseFigureBox.TabStop = false;
            this.ChooseFigureBox.Text = "Добавить";
            // 
            // RectangleRB
            // 
            this.RectangleRB.AutoSize = true;
            this.RectangleRB.Location = new System.Drawing.Point(19, 55);
            this.RectangleRB.Name = "RectangleRB";
            this.RectangleRB.Size = new System.Drawing.Size(105, 17);
            this.RectangleRB.TabIndex = 0;
            this.RectangleRB.Text = "Прямоугольник";
            this.RectangleRB.UseVisualStyleBackColor = true;
            // 
            // EllipseRB
            // 
            this.EllipseRB.AutoSize = true;
            this.EllipseRB.Checked = true;
            this.EllipseRB.Location = new System.Drawing.Point(19, 32);
            this.EllipseRB.Name = "EllipseRB";
            this.EllipseRB.Size = new System.Drawing.Size(62, 17);
            this.EllipseRB.TabIndex = 0;
            this.EllipseRB.TabStop = true;
            this.EllipseRB.Text = "Эллипс";
            this.EllipseRB.UseVisualStyleBackColor = true;
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(24, 245);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(46, 13);
            this.WidthLbl.TabIndex = 2;
            this.WidthLbl.Text = "Ширина";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(24, 209);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(45, 13);
            this.HeightLbl.TabIndex = 2;
            this.HeightLbl.Text = "Высота";
            // 
            // WidthNum
            // 
            this.WidthNum.Location = new System.Drawing.Point(93, 243);
            this.WidthNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.WidthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNum.Name = "WidthNum";
            this.WidthNum.Size = new System.Drawing.Size(62, 20);
            this.WidthNum.TabIndex = 1;
            this.WidthNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // HeightNum
            // 
            this.HeightNum.Location = new System.Drawing.Point(93, 207);
            this.HeightNum.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.HeightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNum.Name = "HeightNum";
            this.HeightNum.Size = new System.Drawing.Size(62, 20);
            this.HeightNum.TabIndex = 1;
            this.HeightNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // BeginCoordLbl
            // 
            this.BeginCoordLbl.AutoSize = true;
            this.BeginCoordLbl.Location = new System.Drawing.Point(196, 24);
            this.BeginCoordLbl.Name = "BeginCoordLbl";
            this.BeginCoordLbl.Size = new System.Drawing.Size(124, 13);
            this.BeginCoordLbl.TabIndex = 4;
            this.BeginCoordLbl.Text = "Начало координат: 0, 0";
            // 
            // SetSizeBtn
            // 
            this.SetSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetSizeBtn.Location = new System.Drawing.Point(10, 282);
            this.SetSizeBtn.Name = "SetSizeBtn";
            this.SetSizeBtn.Size = new System.Drawing.Size(145, 30);
            this.SetSizeBtn.TabIndex = 1;
            this.SetSizeBtn.Text = "Задать размер";
            this.SetSizeBtn.UseVisualStyleBackColor = true;
            this.SetSizeBtn.Click += new System.EventHandler(this.SetSizeBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Location = new System.Drawing.Point(787, 50);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(159, 418);
            this.treeView1.TabIndex = 5;
            // 
            // CheckBeyonds
            // 
            this.CheckBeyonds.AutoSize = true;
            this.CheckBeyonds.Location = new System.Drawing.Point(350, 23);
            this.CheckBeyonds.Name = "CheckBeyonds";
            this.CheckBeyonds.Size = new System.Drawing.Size(116, 17);
            this.CheckBeyonds.TabIndex = 6;
            this.CheckBeyonds.Text = "Проверять рамки";
            this.CheckBeyonds.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Объекты";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Фигуры";
            this.saveFileDialog.Filter = "Файл фигур | *.fgr";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(959, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Tool
            // 
            this.Tool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordsLbl});
            this.Tool.Location = new System.Drawing.Point(0, 527);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(959, 25);
            this.Tool.TabIndex = 8;
            this.Tool.Text = "toolStrip1";
            // 
            // CoordsLbl
            // 
            this.CoordsLbl.Name = "CoordsLbl";
            this.CoordsLbl.Size = new System.Drawing.Size(46, 22);
            this.CoordsLbl.Text = "x: 0, y:0";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файл фигур | *.fgr";
            // 
            // GroupBtn
            // 
            this.GroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBtn.Location = new System.Drawing.Point(10, 406);
            this.GroupBtn.Name = "GroupBtn";
            this.GroupBtn.Size = new System.Drawing.Size(144, 30);
            this.GroupBtn.TabIndex = 1;
            this.GroupBtn.Text = "Сгруппировать";
            this.GroupBtn.UseVisualStyleBackColor = true;
            this.GroupBtn.Click += new System.EventHandler(this.GroupBtn_Click);
            // 
            // UngroupBtn
            // 
            this.UngroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UngroupBtn.Location = new System.Drawing.Point(10, 442);
            this.UngroupBtn.Name = "UngroupBtn";
            this.UngroupBtn.Size = new System.Drawing.Size(144, 30);
            this.UngroupBtn.TabIndex = 1;
            this.UngroupBtn.Text = "Разгруппировать";
            this.UngroupBtn.UseVisualStyleBackColor = true;
            this.UngroupBtn.Click += new System.EventHandler(this.UngroupBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 552);
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.CheckBeyonds);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.BeginCoordLbl);
            this.Controls.Add(this.WidthNum);
            this.Controls.Add(this.HeightNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseFigureBox);
            this.Controls.Add(this.SetColorBtn);
            this.Controls.Add(this.SetSizeBtn);
            this.Controls.Add(this.UngroupBtn);
            this.Controls.Add(this.GroupBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.PaintPanel);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Text = "Abode Illuztractor CS6";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenu.ResumeLayout(false);
            this.ChooseFigureBox.ResumeLayout(false);
            this.ChooseFigureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.Tool.ResumeLayout(false);
            this.Tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PaintPanel;
        private System.Windows.Forms.Button RemoveBtn;
        public System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button SetColorBtn;
        private System.Windows.Forms.GroupBox ChooseFigureBox;
        private System.Windows.Forms.RadioButton RectangleRB;
        private System.Windows.Forms.RadioButton EllipseRB;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.NumericUpDown WidthNum;
        private System.Windows.Forms.NumericUpDown HeightNum;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделенныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветToolStripMenuItem;
        private System.Windows.Forms.Label BeginCoordLbl;
        private System.Windows.Forms.Button SetSizeBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox CheckBeyonds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip Tool;
        private System.Windows.Forms.ToolStripLabel CoordsLbl;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button GroupBtn;
        private System.Windows.Forms.Button UngroupBtn;
    }
}

