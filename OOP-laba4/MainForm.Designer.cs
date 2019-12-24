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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьВыделенныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SetColorBtn = new System.Windows.Forms.Button();
            this.ChooseInstrumentBox = new System.Windows.Forms.GroupBox();
            this.StickyCheck = new System.Windows.Forms.CheckBox();
            this.SelectRB = new System.Windows.Forms.RadioButton();
            this.TriangleRB = new System.Windows.Forms.RadioButton();
            this.RectangleRB = new System.Windows.Forms.RadioButton();
            this.EllipseRB = new System.Windows.Forms.RadioButton();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.HeightNum = new System.Windows.Forms.NumericUpDown();
            this.BeginCoordLbl = new System.Windows.Forms.Label();
            this.SetSizeBtn = new System.Windows.Forms.Button();
            this.CheckBeyonds = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгруппироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разгруппироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool = new System.Windows.Forms.ToolStrip();
            this.CoordsLbl = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GroupBtn = new System.Windows.Forms.Button();
            this.UngroupBtn = new System.Windows.Forms.Button();
            this.SetStickyBtn = new System.Windows.Forms.Button();
            this.UnsetStickyBtn = new System.Windows.Forms.Button();
            this.сделатьЛипкимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убратьЛипкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгруппироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разгруппироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FigureCountLbl = new System.Windows.Forms.ToolStripLabel();
            this.выделитьВсехToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewObserver = new OOP_laba4.TreeViewObserver();
            this.contextMenu.SuspendLayout();
            this.ChooseInstrumentBox.SuspendLayout();
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
            this.PaintPanel.Size = new System.Drawing.Size(582, 553);
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
            this.изменитьЦветToolStripMenuItem,
            this.сделатьЛипкимToolStripMenuItem,
            this.убратьЛипкостьToolStripMenuItem,
            this.сгруппироватьToolStripMenuItem1,
            this.разгруппироватьToolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(216, 136);
            // 
            // удалитьВыделенныеToolStripMenuItem
            // 
            this.удалитьВыделенныеToolStripMenuItem.Name = "удалитьВыделенныеToolStripMenuItem";
            this.удалитьВыделенныеToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.удалитьВыделенныеToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.удалитьВыделенныеToolStripMenuItem.Text = "Удалить выделенные";
            this.удалитьВыделенныеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыделенныеToolStripMenuItem_Click);
            // 
            // изменитьЦветToolStripMenuItem
            // 
            this.изменитьЦветToolStripMenuItem.Name = "изменитьЦветToolStripMenuItem";
            this.изменитьЦветToolStripMenuItem.ShortcutKeyDisplayString = "C";
            this.изменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.изменитьЦветToolStripMenuItem.Text = "Изменить цвет";
            this.изменитьЦветToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветToolStripMenuItem_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Location = new System.Drawing.Point(12, 374);
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
            this.SetColorBtn.Location = new System.Drawing.Point(12, 338);
            this.SetColorBtn.Name = "SetColorBtn";
            this.SetColorBtn.Size = new System.Drawing.Size(144, 30);
            this.SetColorBtn.TabIndex = 1;
            this.SetColorBtn.Text = "Изменить цвет";
            this.SetColorBtn.UseVisualStyleBackColor = true;
            this.SetColorBtn.Click += new System.EventHandler(this.SetColorBtn_Click);
            // 
            // ChooseInstrumentBox
            // 
            this.ChooseInstrumentBox.Controls.Add(this.StickyCheck);
            this.ChooseInstrumentBox.Controls.Add(this.SelectRB);
            this.ChooseInstrumentBox.Controls.Add(this.TriangleRB);
            this.ChooseInstrumentBox.Controls.Add(this.RectangleRB);
            this.ChooseInstrumentBox.Controls.Add(this.EllipseRB);
            this.ChooseInstrumentBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseInstrumentBox.Location = new System.Drawing.Point(11, 50);
            this.ChooseInstrumentBox.Name = "ChooseInstrumentBox";
            this.ChooseInstrumentBox.Size = new System.Drawing.Size(144, 162);
            this.ChooseInstrumentBox.TabIndex = 1;
            this.ChooseInstrumentBox.TabStop = false;
            this.ChooseInstrumentBox.Text = "Инструмент";
            // 
            // StickyCheck
            // 
            this.StickyCheck.AutoSize = true;
            this.StickyCheck.Location = new System.Drawing.Point(19, 132);
            this.StickyCheck.Name = "StickyCheck";
            this.StickyCheck.Size = new System.Drawing.Size(64, 17);
            this.StickyCheck.TabIndex = 4;
            this.StickyCheck.Text = "Липкий";
            this.StickyCheck.UseVisualStyleBackColor = true;
            // 
            // SelectRB
            // 
            this.SelectRB.AutoSize = true;
            this.SelectRB.Checked = true;
            this.SelectRB.Location = new System.Drawing.Point(19, 32);
            this.SelectRB.Name = "SelectRB";
            this.SelectRB.Size = new System.Drawing.Size(82, 17);
            this.SelectRB.TabIndex = 0;
            this.SelectRB.TabStop = true;
            this.SelectRB.Text = "Выделение";
            this.SelectRB.UseVisualStyleBackColor = true;
            // 
            // TriangleRB
            // 
            this.TriangleRB.AutoSize = true;
            this.TriangleRB.Location = new System.Drawing.Point(19, 101);
            this.TriangleRB.Name = "TriangleRB";
            this.TriangleRB.Size = new System.Drawing.Size(90, 17);
            this.TriangleRB.TabIndex = 3;
            this.TriangleRB.Text = "Треугольник";
            this.TriangleRB.UseVisualStyleBackColor = true;
            // 
            // RectangleRB
            // 
            this.RectangleRB.AutoSize = true;
            this.RectangleRB.Location = new System.Drawing.Point(19, 78);
            this.RectangleRB.Name = "RectangleRB";
            this.RectangleRB.Size = new System.Drawing.Size(105, 17);
            this.RectangleRB.TabIndex = 2;
            this.RectangleRB.Text = "Прямоугольник";
            this.RectangleRB.UseVisualStyleBackColor = true;
            // 
            // EllipseRB
            // 
            this.EllipseRB.AutoSize = true;
            this.EllipseRB.Location = new System.Drawing.Point(19, 55);
            this.EllipseRB.Name = "EllipseRB";
            this.EllipseRB.Size = new System.Drawing.Size(62, 17);
            this.EllipseRB.TabIndex = 1;
            this.EllipseRB.Text = "Эллипс";
            this.EllipseRB.UseVisualStyleBackColor = true;
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(25, 265);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(46, 13);
            this.WidthLbl.TabIndex = 2;
            this.WidthLbl.Text = "Ширина";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(25, 229);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(45, 13);
            this.HeightLbl.TabIndex = 2;
            this.HeightLbl.Text = "Высота";
            // 
            // WidthNum
            // 
            this.WidthNum.Location = new System.Drawing.Point(94, 263);
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
            this.WidthNum.TabIndex = 5;
            this.WidthNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // HeightNum
            // 
            this.HeightNum.Location = new System.Drawing.Point(94, 227);
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
            this.HeightNum.TabIndex = 4;
            this.HeightNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // BeginCoordLbl
            // 
            this.BeginCoordLbl.AutoSize = true;
            this.BeginCoordLbl.Location = new System.Drawing.Point(196, 27);
            this.BeginCoordLbl.Name = "BeginCoordLbl";
            this.BeginCoordLbl.Size = new System.Drawing.Size(124, 13);
            this.BeginCoordLbl.TabIndex = 4;
            this.BeginCoordLbl.Text = "Начало координат: 0, 0";
            // 
            // SetSizeBtn
            // 
            this.SetSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetSizeBtn.Location = new System.Drawing.Point(11, 302);
            this.SetSizeBtn.Name = "SetSizeBtn";
            this.SetSizeBtn.Size = new System.Drawing.Size(145, 30);
            this.SetSizeBtn.TabIndex = 1;
            this.SetSizeBtn.Text = "Задать размер";
            this.SetSizeBtn.UseVisualStyleBackColor = true;
            this.SetSizeBtn.Click += new System.EventHandler(this.SetSizeBtn_Click);
            // 
            // CheckBeyonds
            // 
            this.CheckBeyonds.AutoSize = true;
            this.CheckBeyonds.Location = new System.Drawing.Point(351, 26);
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
            this.menuStrip.BackColor = System.Drawing.Color.White;
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
            this.открытьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.выделитьВсехToolStripMenuItem,
            this.цветToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.сгруппироватьToolStripMenuItem,
            this.разгруппироватьToolStripMenuItem,
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            this.повторитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.повторитьToolStripMenuItem.Text = "Повторить";
            this.повторитьToolStripMenuItem.Click += new System.EventHandler(this.повторитьToolStripMenuItem_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.ShortcutKeyDisplayString = "C";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сгруппироватьToolStripMenuItem
            // 
            this.сгруппироватьToolStripMenuItem.Name = "сгруппироватьToolStripMenuItem";
            this.сгруппироватьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G";
            this.сгруппироватьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.сгруппироватьToolStripMenuItem.Text = "Сгруппировать";
            this.сгруппироватьToolStripMenuItem.Click += new System.EventHandler(this.сгруппироватьToolStripMenuItem_Click);
            // 
            // разгруппироватьToolStripMenuItem
            // 
            this.разгруппироватьToolStripMenuItem.Name = "разгруппироватьToolStripMenuItem";
            this.разгруппироватьToolStripMenuItem.ShortcutKeyDisplayString = "Shift+G";
            this.разгруппироватьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.разгруппироватьToolStripMenuItem.Text = "Разгруппировать";
            this.разгруппироватьToolStripMenuItem.Click += new System.EventHandler(this.разгруппироватьToolStripMenuItem_Click);
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Tool
            // 
            this.Tool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoordsLbl,
            this.FigureCountLbl});
            this.Tool.Location = new System.Drawing.Point(0, 614);
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
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файл фигур | *.fgr";
            // 
            // GroupBtn
            // 
            this.GroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBtn.Location = new System.Drawing.Point(12, 537);
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
            this.UngroupBtn.Location = new System.Drawing.Point(12, 573);
            this.UngroupBtn.Name = "UngroupBtn";
            this.UngroupBtn.Size = new System.Drawing.Size(144, 30);
            this.UngroupBtn.TabIndex = 1;
            this.UngroupBtn.Text = "Разгруппировать";
            this.UngroupBtn.UseVisualStyleBackColor = true;
            this.UngroupBtn.Click += new System.EventHandler(this.UngroupBtn_Click);
            // 
            // SetStickyBtn
            // 
            this.SetStickyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetStickyBtn.Location = new System.Drawing.Point(11, 410);
            this.SetStickyBtn.Name = "SetStickyBtn";
            this.SetStickyBtn.Size = new System.Drawing.Size(144, 30);
            this.SetStickyBtn.TabIndex = 1;
            this.SetStickyBtn.Text = "Сделать липким";
            this.SetStickyBtn.UseVisualStyleBackColor = true;
            this.SetStickyBtn.Click += new System.EventHandler(this.SetStickyBtn_Click);
            // 
            // UnsetStickyBtn
            // 
            this.UnsetStickyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnsetStickyBtn.Location = new System.Drawing.Point(11, 446);
            this.UnsetStickyBtn.Name = "UnsetStickyBtn";
            this.UnsetStickyBtn.Size = new System.Drawing.Size(144, 30);
            this.UnsetStickyBtn.TabIndex = 1;
            this.UnsetStickyBtn.Text = "Убрать липкость";
            this.UnsetStickyBtn.UseVisualStyleBackColor = true;
            this.UnsetStickyBtn.Click += new System.EventHandler(this.UnsetStickyBtn_Click);
            // 
            // сделатьЛипкимToolStripMenuItem
            // 
            this.сделатьЛипкимToolStripMenuItem.Name = "сделатьЛипкимToolStripMenuItem";
            this.сделатьЛипкимToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.сделатьЛипкимToolStripMenuItem.Text = "Сделать липким";
            this.сделатьЛипкимToolStripMenuItem.Click += new System.EventHandler(this.сделатьЛипкимToolStripMenuItem_Click);
            // 
            // убратьЛипкостьToolStripMenuItem
            // 
            this.убратьЛипкостьToolStripMenuItem.Name = "убратьЛипкостьToolStripMenuItem";
            this.убратьЛипкостьToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.убратьЛипкостьToolStripMenuItem.Text = "Убрать липкость";
            this.убратьЛипкостьToolStripMenuItem.Click += new System.EventHandler(this.убратьЛипкостьToolStripMenuItem_Click);
            // 
            // сгруппироватьToolStripMenuItem1
            // 
            this.сгруппироватьToolStripMenuItem1.Name = "сгруппироватьToolStripMenuItem1";
            this.сгруппироватьToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+G";
            this.сгруппироватьToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.сгруппироватьToolStripMenuItem1.Text = "Сгруппировать";
            this.сгруппироватьToolStripMenuItem1.Click += new System.EventHandler(this.сгруппироватьToolStripMenuItem1_Click);
            // 
            // разгруппироватьToolStripMenuItem1
            // 
            this.разгруппироватьToolStripMenuItem1.Name = "разгруппироватьToolStripMenuItem1";
            this.разгруппироватьToolStripMenuItem1.ShortcutKeyDisplayString = "Shift+G";
            this.разгруппироватьToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.разгруппироватьToolStripMenuItem1.Text = "Разгруппировать";
            this.разгруппироватьToolStripMenuItem1.Click += new System.EventHandler(this.разгруппироватьToolStripMenuItem1_Click);
            // 
            // FigureCountLbl
            // 
            this.FigureCountLbl.Name = "FigureCountLbl";
            this.FigureCountLbl.Size = new System.Drawing.Size(53, 22);
            this.FigureCountLbl.Text = "Фигур: 0";
            // 
            // выделитьВсехToolStripMenuItem
            // 
            this.выделитьВсехToolStripMenuItem.Name = "выделитьВсехToolStripMenuItem";
            this.выделитьВсехToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.выделитьВсехToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.выделитьВсехToolStripMenuItem.Text = "Выделить всех";
            this.выделитьВсехToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсехToolStripMenuItem_Click);
            // 
            // treeViewObserver
            // 
            this.treeViewObserver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewObserver.CheckBoxes = true;
            this.treeViewObserver.Location = new System.Drawing.Point(787, 50);
            this.treeViewObserver.Name = "treeViewObserver";
            this.treeViewObserver.Size = new System.Drawing.Size(160, 466);
            this.treeViewObserver.TabIndex = 9;
            this.treeViewObserver.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewObserver_AfterCheck);
            this.treeViewObserver.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewObserver_NodeMouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 639);
            this.Controls.Add(this.treeViewObserver);
            this.Controls.Add(this.Tool);
            this.Controls.Add(this.CheckBeyonds);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.BeginCoordLbl);
            this.Controls.Add(this.WidthNum);
            this.Controls.Add(this.HeightNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseInstrumentBox);
            this.Controls.Add(this.SetColorBtn);
            this.Controls.Add(this.SetSizeBtn);
            this.Controls.Add(this.UngroupBtn);
            this.Controls.Add(this.GroupBtn);
            this.Controls.Add(this.UnsetStickyBtn);
            this.Controls.Add(this.SetStickyBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.PaintPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Text = "My little paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenu.ResumeLayout(false);
            this.ChooseInstrumentBox.ResumeLayout(false);
            this.ChooseInstrumentBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox ChooseInstrumentBox;
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
        private System.Windows.Forms.RadioButton TriangleRB;
        private System.Windows.Forms.RadioButton SelectRB;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгруппироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разгруппироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private TreeViewObserver treeViewObserver;
        private System.Windows.Forms.CheckBox StickyCheck;
        private System.Windows.Forms.Button SetStickyBtn;
        private System.Windows.Forms.Button UnsetStickyBtn;
        private System.Windows.Forms.ToolStripMenuItem сделатьЛипкимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убратьЛипкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгруппироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem разгруппироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripLabel FigureCountLbl;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсехToolStripMenuItem;
    }
}

