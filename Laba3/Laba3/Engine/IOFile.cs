using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba3.Движок;

namespace Laba3.Engine
{
    
    public static class IOFile
    {
        public static Form1 form1;
        public static string Content;
        public static void FillContent()
        {
            foreach(var i in Context.array)
            {
                Content += Convert.ToString(i) + ' ';
            }
            Content += '\n';
        }
        public static string InputInfoAboutComparison(int first,int second)
        {
            Content += "Сравниваем " + Convert.ToString(first) + " и " + Convert.ToString(second) + '\n';
            return "Сравниваем " + Convert.ToString(first) + " и " + Convert.ToString(second) + '\n';
            
        }
        public static string InputInfoAboutTransposition(int first, int second)
        {
            Content += "Перестановка " + Convert.ToString(first) + " и " + Convert.ToString(second) + '\n';
            return "Перестановка " + Convert.ToString(first) + " и " + Convert.ToString(second) + '\n';
        }
        public static void SaveData()
        {
            
           if (form1.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
              return;
            String path = form1.saveFileDialog1.FileName;
            System.IO.File.WriteAllText(path, IOFile.Content);  


        }
    }
}
