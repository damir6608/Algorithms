using Laba3.Engine;
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
    public partial class Analytic : Form
    {
        public static Form1 form1;
        Context context;
        public static string forInsert;
        public static string forRankSorting;
        public static Analytic anal;
        public static bool dobro = false;

        public static double timeInsert;
        public static double timeRank;

        public static double timeInsertformore;
        public static double timeRankformore;

        public static string numberofperInsert;
        public static string timeforInsert;
        public static string timeforInsertеtimet;

        public static string numberofperRank;
        public static string timeforRank;
        public static string timeforRanktimet;


        public static bool flag;
        int t = 40000;
        public Analytic()
        {
            InitializeComponent();
        }
        
        

        private void Analytic_Load(object sender, EventArgs e)
        {
            dobro = false;
            form1.Visible = false;
            Analytic.anal = this;
            Form1.anal = this;
            flag = false;
            MessageBox.Show("В целях уменьшения нагрузки разработчик разделил анализ на два этапа:\n " +
                "Для начала нажмите кнопку 'Начать анализ' чтобы продолжить нажмите кнопку 'Продолжить с более объемной выборкой'");

            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
            this.Focus(); this.Show();

        }
        [STAThread]
        private void StartAnalytic_Click(object sender, EventArgs e)
        {



            if (!dobro)
            {
                Splash.ShowSplashScreen();
                anal.Enabled = false;


               // MessageBox.Show("Ожидайте очень долгое время окончания сортировок");
                aboutInsert.Text += "\nИспользуя выборки 1000, 10000, 30000, с количетсвом перестановок ";
                aboutRankSorting.Text += "\nИспользуя выборки 1000, 10000, 30000, с количетсвом перестановок ";

                CreateLine(1000);
                aboutInsert.Text += numberofperInsert + ", ";

                aboutRankSorting.Text += numberofperRank + ", ";

                CreateLine(10000);
                aboutInsert.Text += numberofperInsert + ", ";

                aboutRankSorting.Text += numberofperRank + ", ";

                CreateLine(30000);
               

                if (timeInsert < timeRank)
                {
                    aboutInsert.Text += numberofperInsert;
                    aboutInsert.Text += " соответственно, показано лучшее время равное \n" + timeforInsert + " для первой, второй и третьей выборки";

                    aboutRankSorting.Text += numberofperRank;
                    aboutRankSorting.Text += " соответственно, показано худшее время равное \n" + timeforRank + " для первой, второй и третьей выборки";
                }
                else if (timeRank < timeInsert)
                {
                    aboutInsert.Text += numberofperInsert;
                    aboutInsert.Text += " соответственно, показано худшее время равное \n" + timeforInsert + " для первой, второй и третьей выборки";

                    aboutRankSorting.Text += numberofperRank;
                    aboutRankSorting.Text += " соответственно, показано лучшее время равное \n" + timeforRank + " для первой, второй и третьей выборки";
                }
                else
                {
                    aboutInsert.Text += "Все произошло одинаково быстро";
                    aboutRankSorting.Text += "Все произошло одинаково быстро";
                }



                ClearForm1();

                flag = true;
                dobro = true;

                anal.Enabled = true;
                Splash.CloseForm();
                
            }
               

            
        }

        public static void CreateLine(int value)
        {
           

            Sampling.generate(value);


            anal.context = new Context(new InsertAnalityc());
            anal.context.ExecuteAlgorithm(true);


            anal.context = new Context(new RankSortingAnalytic());
            anal.context.ExecuteAlgorithm(true);


            anal.dataGridView1.Rows.Add(""+value, forInsert, forRankSorting);

        }

        public static void ClearForm1()
        {
            form1.RichBox.Text = " ";
            form1.labelCountComparison.Text = " ";
            form1.labelNumberOfPermutations.Text = " ";
            form1.labelTimeSort.Text = " ";
        }

        [STAThread]
        private void Continue_Click(object sender, EventArgs e)
        {
            
            if (flag)
            {
                Splash.ShowSplashScreen();
                anal.Enabled = false;


                CreateLine(t);
                if (timeInsertformore < timeRankformore)
                {
                    aboutInsert.Text += ", используя выборку " + t + ", количество перестановок равное \n" + numberofperInsert +
                    " и время " + timeforInsertеtimet + " показано лучшее время по этой выборке";

                    aboutRankSorting.Text += ", используя выборку " + t + ", количество перестановок равное \n" + numberofperRank +
                        " и время " + timeforRanktimet + " показано худшее время по этой выборке";
                }
                else if (timeInsertformore > timeRankformore)
                {
                    aboutInsert.Text += ", используя выборку " + t + ", количество перестановок равное \n" + numberofperInsert +
                   " и время " + timeforInsertеtimet + " показано худшее время по этой выборке";
                    aboutRankSorting.Text += ", используя выборку " + t + ", количество перестановок равное \n" + numberofperRank +
                        " и время " + timeforRanktimet + " показано лучшее время по этой выборке";
                }
                if (timeRank < timeInsert)
                {
                    label2.Text = "Общее время по всем выборкам оказалось меньше у метода поразрядных сортировок\n "
                        + timeforRank + ", \nчем у метода сортировок вствками где время \n" + timeforInsert;
                }
                else if (timeRank > timeInsert)
                {
                    label2.Text = "Общее время по всем выборкам оказалось меньше у метода сортировок вставками\n" + timeforInsert +
                        ", \nчем у метода поразрядных сортировок где время \n" + timeforRank;
                }

                ClearForm1();

                anal.Enabled = true;
                Splash.CloseForm();
            }

            else
            {
                MessageBox.Show("Для начала нажмите на кнопку 'Начать анализ'");
            }
            t += 20000;
               
        }

        private void Analytic_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Visible = true;
        }
    }
}
