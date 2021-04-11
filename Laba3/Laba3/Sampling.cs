using Laba3.Движок;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Sampling : Form
    {
        public static Form1 form1;
        public static Sampling sampling;
        public Sampling()
        {
            InitializeComponent();
        }
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value);
        }

        private void CreateSampling_Click(object sender, EventArgs e)
        {
             
            int [] arr =  generate(trackBar1.Value);
            //  В Ы В О Д
            for(int i = 0;i<200;i++)
            {
                form1.RichBox.Text += "-";
            }
            form1.RichBox.Text += "\n";

            for (int i = 0;i<trackBar1.Value;i++)
            {
                form1.RichBox.Text+=arr[i] + " ";
            }
            form1.RichBox.Text += "\n";
            for (int i = 0; i < 200; i++)
            {
                form1.RichBox.Text += "-";
            }
            form1.RichBox.Text += "\n\n";
            // закрытие формы
            sampling.Visible = false;
            form1.Visible = true;
            form1.StartSorted.Enabled = true;
            
        }

        public static int [] generate(int value)
        {
            Random rand = new Random();
            int[] arr = new int[value];
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] =rand.Next(0,1000);
            }
            Context.array = arr;


            return arr;


        }

        private void Sampling_Load(object sender, EventArgs e)
        {
            form1.Visible = false;
            Sampling.sampling = this;
        }

        private void Sampling_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }
    }
}
