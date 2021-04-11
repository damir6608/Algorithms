
namespace Laba3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьНаборToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводСтатистикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartSorted = new System.Windows.Forms.Button();
            this.radioButtonRankSorting = new System.Windows.Forms.RadioButton();
            this.radioButtonInsertSort = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.labelTimeSort = new System.Windows.Forms.TextBox();
            this.labelNumberOfPermutations = new System.Windows.Forms.TextBox();
            this.labelCountComparison = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.RichBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileDialog,
            this.сгенерироватьНаборToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Name = "OpenFileDialog";
            this.OpenFileDialog.Size = new System.Drawing.Size(194, 22);
            this.OpenFileDialog.Text = "Открыть файл";
            this.OpenFileDialog.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сгенерироватьНаборToolStripMenuItem
            // 
            this.сгенерироватьНаборToolStripMenuItem.Name = "сгенерироватьНаборToolStripMenuItem";
            this.сгенерироватьНаборToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.сгенерироватьНаборToolStripMenuItem.Text = "Сгенерировать набор";
            this.сгенерироватьНаборToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьНаборToolStripMenuItem_Click);
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводСтатистикиToolStripMenuItem});
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // выводСтатистикиToolStripMenuItem
            // 
            this.выводСтатистикиToolStripMenuItem.Name = "выводСтатистикиToolStripMenuItem";
            this.выводСтатистикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выводСтатистикиToolStripMenuItem.Text = "Вывод статистики";
            this.выводСтатистикиToolStripMenuItem.Click += new System.EventHandler(this.выводСтатистикиToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartSorted);
            this.groupBox1.Controls.Add(this.radioButtonRankSorting);
            this.groupBox1.Controls.Add(this.radioButtonInsertSort);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрать метод сортировки";
            // 
            // StartSorted
            // 
            this.StartSorted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartSorted.Location = new System.Drawing.Point(43, 105);
            this.StartSorted.Name = "StartSorted";
            this.StartSorted.Size = new System.Drawing.Size(118, 24);
            this.StartSorted.TabIndex = 5;
            this.StartSorted.Text = "Начать сортировку";
            this.StartSorted.UseVisualStyleBackColor = true;
            this.StartSorted.Click += new System.EventHandler(this.StartSorted_Click);
            // 
            // radioButtonRankSorting
            // 
            this.radioButtonRankSorting.AutoSize = true;
            this.radioButtonRankSorting.Location = new System.Drawing.Point(6, 64);
            this.radioButtonRankSorting.Name = "radioButtonRankSorting";
            this.radioButtonRankSorting.Size = new System.Drawing.Size(155, 17);
            this.radioButtonRankSorting.TabIndex = 4;
            this.radioButtonRankSorting.TabStop = true;
            this.radioButtonRankSorting.Text = "Поразрядная сортировка";
            this.radioButtonRankSorting.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsertSort
            // 
            this.radioButtonInsertSort.AutoSize = true;
            this.radioButtonInsertSort.Location = new System.Drawing.Point(6, 32);
            this.radioButtonInsertSort.Name = "radioButtonInsertSort";
            this.radioButtonInsertSort.Size = new System.Drawing.Size(143, 17);
            this.radioButtonInsertSort.TabIndex = 4;
            this.radioButtonInsertSort.TabStop = true;
            this.radioButtonInsertSort.Text = "Сортировка вставками";
            this.radioButtonInsertSort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clear);
            this.groupBox2.Controls.Add(this.labelTimeSort);
            this.groupBox2.Controls.Add(this.labelNumberOfPermutations);
            this.groupBox2.Controls.Add(this.labelCountComparison);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 159);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о сортировке";
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Location = new System.Drawing.Point(43, 129);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(118, 24);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // labelTimeSort
            // 
            this.labelTimeSort.Location = new System.Drawing.Point(88, 95);
            this.labelTimeSort.Name = "labelTimeSort";
            this.labelTimeSort.ReadOnly = true;
            this.labelTimeSort.Size = new System.Drawing.Size(100, 20);
            this.labelTimeSort.TabIndex = 5;
            // 
            // labelNumberOfPermutations
            // 
            this.labelNumberOfPermutations.Location = new System.Drawing.Point(88, 57);
            this.labelNumberOfPermutations.Name = "labelNumberOfPermutations";
            this.labelNumberOfPermutations.ReadOnly = true;
            this.labelNumberOfPermutations.Size = new System.Drawing.Size(100, 20);
            this.labelNumberOfPermutations.TabIndex = 5;
            // 
            // labelCountComparison
            // 
            this.labelCountComparison.Location = new System.Drawing.Point(88, 22);
            this.labelCountComparison.Name = "labelCountComparison";
            this.labelCountComparison.ReadOnly = true;
            this.labelCountComparison.Size = new System.Drawing.Size(100, 20);
            this.labelCountComparison.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Время\r\nсортировки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество \r\nперестановок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество \r\nсравнений";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog";
            // 
            // RichBox
            // 
            this.RichBox.Location = new System.Drawing.Point(238, 39);
            this.RichBox.Name = "RichBox";
            this.RichBox.ReadOnly = true;
            this.RichBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichBox.Size = new System.Drawing.Size(614, 408);
            this.RichBox.TabIndex = 6;
            this.RichBox.Text = "";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 478);
            this.Controls.Add(this.RichBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировки выборок";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьНаборToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводСтатистикиToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button StartSorted;
        private System.Windows.Forms.RadioButton radioButtonRankSorting;
        private System.Windows.Forms.RadioButton radioButtonInsertSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Clear;
        public System.Windows.Forms.TextBox labelTimeSort;
        public System.Windows.Forms.TextBox labelNumberOfPermutations;
        public System.Windows.Forms.TextBox labelCountComparison;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        public System.Windows.Forms.RichTextBox RichBox;
        public  System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

