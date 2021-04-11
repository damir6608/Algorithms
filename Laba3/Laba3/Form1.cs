using Laba3.Engine;
using Laba3.Движок;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public static Sampling sampling;
        public static Analytic anal ;
       
        
        Context context;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openFileDialog2.FileName;
            
            string fileText = System.IO.File.ReadAllText(filename);
            
            int[] nums = FilerReader(fileText);//заполняю массив обработанными данными
            bool flag = true;
            foreach(int i in nums)
            {
                if (i<0)
                {
                    MessageBox.Show("В введенной выборке не должны содержаться отрицательные числа!");
                    flag = false;
                }
            }
            if (flag)
            {
                Context.array = nums;
                for (int i = 0; i < 200; i++)
                {
                    RichBox.Text += "-";
                }
                RichBox.Text += "\n";

                foreach (int i in nums)
                    RichBox.Text += " " + i;//вывод на экран

                RichBox.Text += "\n";
                for (int i = 0; i < 200; i++)
                {
                    RichBox.Text += "-";
                }
                RichBox.Text += "\n\n";
                StartSorted.Enabled = true;
            }

        }

        public static int[] FilerReader(String fileText)//обратбатываю данные
        {
            int[] nums = fileText
           .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(n => int.Parse(n))
           .ToArray();

            

            return nums;
        }

        private void сгенерироватьНаборToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sampling sampling = new Sampling();
            sampling.Show();
        }
        public void AddItemsListBox(int first = -1, int second = -1)
        {
            
            RichBox.Text += "\n\n";
            foreach (var item in Context.array)
            {
                if (item == first || item == second)
                {
                    RichBox.Text += "| " + Convert.ToString(item)+ " |" + "\t";
                }
                else
                {
                    RichBox.Text +=  Convert.ToString(item) + "\t" ;
                }
            }
            }

        private void Clear_Click(object sender, EventArgs e)
        {

            RichBox.Text = " ";
            labelCountComparison.Text = " ";
            labelNumberOfPermutations.Text = " ";
            labelTimeSort.Text = " ";
            Context.array = null;
        }

        private void StartSorted_Click(object sender, EventArgs e)
        {
            if (Context.array != null)
            {
                if (radioButtonInsertSort.Checked == true)
                {
                    Splash.ShowSplashScreen();
                    form1.Enabled = false;

                    this.context   = new Context(new Insert());
                    
                    
                    context.ExecuteAlgorithm(true);
                    this.AddItemsListBox();
                    form1.Enabled = true;
                    Splash.CloseForm();

                    IOFile.SaveData();
                    StartSorted.Enabled = false;

                    

                }
                if (radioButtonRankSorting.Checked == true)
                {
                    Splash.ShowSplashScreen();
                    form1.Enabled = false;

                    this.context = new Context(new RankSorting());
                    context.ExecuteAlgorithm();
                    this.AddItemsListBox();
                    form1.Enabled = true;
                    Splash.CloseForm();

                    IOFile.SaveData();
                    StartSorted.Enabled = false;

                    
                }
                IOFile.Content = "";
                
            }
            else
            {
                MessageBox.Show("Массив пуст, сортировка невозможна");
            }
        }
        public static void LoadData()
        {
            if (form1.openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            String path = form1.openFileDialog2.FileName;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                Separator(sr);
                sr.Close();

            }
        }

        private static void Separator(StreamReader streamReader)
        {
            int CurrentFilePosition = 0;
            int TempMultiplicationResult = 0;
            int LoadedArrayElement = 0;
            int TempDigitCapacity = 0;

            ArrayList arrayList = new ArrayList();

            while (streamReader.Peek() != -1)
            {
                if (streamReader.Peek() == 32)
                {
                    char[] vs = new char[2 * CurrentFilePosition];
                    streamReader.Read(vs, CurrentFilePosition, 1);
                    CurrentFilePosition++;

                }
                else if (streamReader.Peek() >= 48 && streamReader.Peek() <= 57)
                {
                    do
                    {
                        if (streamReader.Peek() == -1)
                        {
                            break;

                        }
                        char[] listChar = new char[CurrentFilePosition];
                        streamReader.Read(listChar, CurrentFilePosition, 1);
                        int.TryParse(Convert.ToString(listChar[CurrentFilePosition]), out TempMultiplicationResult);
                        TempMultiplicationResult *= Convert.ToInt32(Math.Pow(10.0, TempDigitCapacity));
                        LoadedArrayElement += TempMultiplicationResult;
                        CurrentFilePosition++;
                        TempDigitCapacity++;

                    }
                    while (streamReader.Peek() != 32);
                    string output = new string(Convert.ToString(LoadedArrayElement).ToCharArray().Reverse().ToArray());
                    int.TryParse(output, out LoadedArrayElement);
                    arrayList.Add(Convert.ToString(LoadedArrayElement));
                    TempDigitCapacity = 0;
                    TempMultiplicationResult = 0;
                    LoadedArrayElement = 0;
                }
                else
                {
                    MessageBox.Show("Некорректный формат загружаемого файла.");
                    break;

                }

            }
            Context.array = new int[arrayList.Count];
            for (int k = 0; k < arrayList.Count; k++)
            {
                int.TryParse((String)arrayList[k], out Context.array[k]);
            }
            foreach (int j in Context.array)
            {
                IOFile.Content += Convert.ToString(j) + " ";
            }
            form1.RichBox.Text = IOFile.Content;
            form1.RichBox.Text = " ";
        }


        public static void ClearForm()
        {
            
            form1.RichBox.Text = " ";
            form1.labelCountComparison.Text = " ";
            form1.labelNumberOfPermutations.Text = " ";
            form1.labelTimeSort.Text = " ";
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sampling.form1 = this;
            Insert.form1 = this;
            IOFile.form1 = this;
            RankSorting.form1 = this;
            Analytic.form1 = this;
            CleanInsert.form1 = this;
            CleanRankSorting.form1 = this;

            Form1.form1 = this;
        }

        private void выводСтатистикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                Analytic analytic = new Analytic();
                analytic.Show();
            
        }
    }
}
