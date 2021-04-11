
namespace Laba3
{
    partial class Analytic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytic));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankSortingMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAnalytic = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.aboutRankSorting = new System.Windows.Forms.Label();
            this.aboutInsert = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sample,
            this.InsertMethod,
            this.RankSortingMethod});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sample
            // 
            this.Sample.HeaderText = "Объем выборки";
            this.Sample.Name = "Sample";
            this.Sample.ReadOnly = true;
            this.Sample.Width = 50;
            // 
            // InsertMethod
            // 
            this.InsertMethod.HeaderText = "Метод вставок";
            this.InsertMethod.Name = "InsertMethod";
            this.InsertMethod.ReadOnly = true;
            this.InsertMethod.Width = 250;
            // 
            // RankSortingMethod
            // 
            this.RankSortingMethod.HeaderText = "Метод поразрядной сортировки";
            this.RankSortingMethod.Name = "RankSortingMethod";
            this.RankSortingMethod.ReadOnly = true;
            this.RankSortingMethod.Width = 250;
            // 
            // StartAnalytic
            // 
            this.StartAnalytic.Location = new System.Drawing.Point(646, 12);
            this.StartAnalytic.Name = "StartAnalytic";
            this.StartAnalytic.Size = new System.Drawing.Size(164, 43);
            this.StartAnalytic.TabIndex = 1;
            this.StartAnalytic.Text = "Начать анализ";
            this.StartAnalytic.UseVisualStyleBackColor = true;
            this.StartAnalytic.Click += new System.EventHandler(this.StartAnalytic_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(646, 75);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(164, 43);
            this.Continue.TabIndex = 4;
            this.Continue.Text = "Продолжить с более объемной выборкой";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // aboutRankSorting
            // 
            this.aboutRankSorting.AutoSize = true;
            this.aboutRankSorting.Location = new System.Drawing.Point(9, 313);
            this.aboutRankSorting.Name = "aboutRankSorting";
            this.aboutRankSorting.Size = new System.Drawing.Size(304, 13);
            this.aboutRankSorting.TabIndex = 5;
            this.aboutRankSorting.Text = "Информация по анализу метода поразрядных сортировок";
            // 
            // aboutInsert
            // 
            this.aboutInsert.AutoSize = true;
            this.aboutInsert.Location = new System.Drawing.Point(12, 177);
            this.aboutInsert.Name = "aboutInsert";
            this.aboutInsert.Size = new System.Drawing.Size(286, 13);
            this.aboutInsert.TabIndex = 6;
            this.aboutInsert.Text = "Информация по анализу метода сортировок вствками";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Статистика по более объемным выборкам";
            // 
            // Analytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutInsert);
            this.Controls.Add(this.aboutRankSorting);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.StartAnalytic);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Analytic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Analytic_FormClosed);
            this.Load += new System.EventHandler(this.Analytic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StartAnalytic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sample;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankSortingMethod;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label aboutRankSorting;
        private System.Windows.Forms.Label aboutInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}