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
            this.WidthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.HeightNum = new System.Windows.Forms.NumericUpDown();
            this.RectangleRB = new System.Windows.Forms.RadioButton();
            this.EllipseRB = new System.Windows.Forms.RadioButton();
            this.CountLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.BeginCoordLbl = new System.Windows.Forms.Label();
            this.SetSizeBtn = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.ChooseFigureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintPanel
            // 
            this.PaintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPanel.ContextMenuStrip = this.contextMenu;
            this.PaintPanel.Location = new System.Drawing.Point(258, 12);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(639, 510);
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
            this.RemoveBtn.Location = new System.Drawing.Point(12, 382);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(210, 30);
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
            this.SetColorBtn.Location = new System.Drawing.Point(12, 346);
            this.SetColorBtn.Name = "SetColorBtn";
            this.SetColorBtn.Size = new System.Drawing.Size(210, 30);
            this.SetColorBtn.TabIndex = 1;
            this.SetColorBtn.Text = "Изменить цвет";
            this.SetColorBtn.UseVisualStyleBackColor = true;
            this.SetColorBtn.Click += new System.EventHandler(this.SetColorBtn_Click);
            // 
            // ChooseFigureBox
            // 
            this.ChooseFigureBox.Controls.Add(this.RectangleRB);
            this.ChooseFigureBox.Controls.Add(this.EllipseRB);
            this.ChooseFigureBox.Location = new System.Drawing.Point(12, 65);
            this.ChooseFigureBox.Name = "ChooseFigureBox";
            this.ChooseFigureBox.Size = new System.Drawing.Size(210, 142);
            this.ChooseFigureBox.TabIndex = 2;
            this.ChooseFigureBox.TabStop = false;
            this.ChooseFigureBox.Text = "Выберите фигуру для добавления";
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Location = new System.Drawing.Point(28, 259);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(46, 13);
            this.WidthLbl.TabIndex = 2;
            this.WidthLbl.Text = "Ширина";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(28, 223);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(45, 13);
            this.HeightLbl.TabIndex = 2;
            this.HeightLbl.Text = "Высота";
            // 
            // WidthNum
            // 
            this.WidthNum.Location = new System.Drawing.Point(97, 257);
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
            this.HeightNum.Location = new System.Drawing.Point(97, 221);
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
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Location = new System.Drawing.Point(13, 12);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(60, 13);
            this.CountLbl.TabIndex = 3;
            this.CountLbl.Text = "Фигур: {0}";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Location = new System.Drawing.Point(14, 509);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(123, 13);
            this.InfoLbl.TabIndex = 4;
            this.InfoLbl.Text = "СКМ - двигать полотно";
            // 
            // BeginCoordLbl
            // 
            this.BeginCoordLbl.AutoSize = true;
            this.BeginCoordLbl.Location = new System.Drawing.Point(13, 38);
            this.BeginCoordLbl.Name = "BeginCoordLbl";
            this.BeginCoordLbl.Size = new System.Drawing.Size(124, 13);
            this.BeginCoordLbl.TabIndex = 4;
            this.BeginCoordLbl.Text = "Начало координат: 0, 0";
            // 
            // SetSizeBtn
            // 
            this.SetSizeBtn.Location = new System.Drawing.Point(11, 310);
            this.SetSizeBtn.Name = "SetSizeBtn";
            this.SetSizeBtn.Size = new System.Drawing.Size(211, 30);
            this.SetSizeBtn.TabIndex = 1;
            this.SetSizeBtn.Text = "Задать размер";
            this.SetSizeBtn.UseVisualStyleBackColor = true;
            this.SetSizeBtn.Click += new System.EventHandler(this.SetSizeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 537);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.BeginCoordLbl);
            this.Controls.Add(this.WidthNum);
            this.Controls.Add(this.HeightNum);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.CountLbl);
            this.Controls.Add(this.ChooseFigureBox);
            this.Controls.Add(this.SetColorBtn);
            this.Controls.Add(this.SetSizeBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.PaintPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Abode Illuztractor CS6";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.contextMenu.ResumeLayout(false);
            this.ChooseFigureBox.ResumeLayout(false);
            this.ChooseFigureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).EndInit();
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
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделенныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветToolStripMenuItem;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label BeginCoordLbl;
        private System.Windows.Forms.Button SetSizeBtn;
    }
}

