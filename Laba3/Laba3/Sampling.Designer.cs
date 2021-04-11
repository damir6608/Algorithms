
namespace Laba3
{
    partial class Sampling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sampling));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.CreateSampling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(12, 43);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(319, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // CreateSampling
            // 
            this.CreateSampling.Location = new System.Drawing.Point(27, 116);
            this.CreateSampling.Name = "CreateSampling";
            this.CreateSampling.Size = new System.Drawing.Size(102, 35);
            this.CreateSampling.TabIndex = 1;
            this.CreateSampling.Text = "Создать выборку";
            this.CreateSampling.UseVisualStyleBackColor = true;
            this.CreateSampling.Click += new System.EventHandler(this.CreateSampling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(105, 35);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Двигайте курсор для выбора объема выборки";
            // 
            // Sampling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateSampling);
            this.Controls.Add(this.trackBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sampling";
            this.Text = "Sampling";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sampling_FormClosed);
            this.Load += new System.EventHandler(this.Sampling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateSampling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TrackBar trackBar1;
    }
}