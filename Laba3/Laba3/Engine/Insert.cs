using Laba3.Engine;
using Laba3.Движок;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Engine
{
   public class Insert:Istrategy
    {
        public int iterationCount = 0;
        public static Form1 form1;

        public Insert()
        {

        }
        public int[] Algorithm(int[] mas, bool flag = true)
        {
            if (flag)
            {
                IOFile.FillContent();
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                //О Т С Ю Д А    Н А Д О    В С Е    М Е Н Я Т Ь ! ! !
                int newElement, location;

                for (int i = 1; i < mas.Length; i++)
                {
                    newElement = mas[i];

                    
                    
                    location = i - 1;

                    this.iterationCount++;
                    IOFile.Content += this.iterationCount.ToString() + " итерация: " + '\n';
                    IOFile.InputInfoAboutComparison(mas[i], mas[location]);
                    ComparativeAnalysis.Comparison++;

                    while (location >= 0 && mas[location] > newElement)
                    {
                        IOFile.InputInfoAboutTransposition(mas[i], mas[location]);

                        ComparativeAnalysis.NumberOfPermutations++;
                        IOFile.FillContent();
                        form1.AddItemsListBox(mas[i], mas[location]);
                        mas[location + 1] = mas[location];
                        location = location - 1;

                        
                    }
                    mas[location + 1] = newElement;
                    


                        
                    
                }
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTim = String.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
                


                form1.labelCountComparison.Text = Convert.ToString(ComparativeAnalysis.Comparison);
                form1.labelNumberOfPermutations.Text =Convert.ToString(ComparativeAnalysis.NumberOfPermutations);
                form1.labelTimeSort.Text = elapsedTim;

                Analytic.forInsert = "Ср:" + Convert.ToString(ComparativeAnalysis.Comparison) +
                    "\nПе:" + Convert.ToString(ComparativeAnalysis.NumberOfPermutations) + "\nВр:" ;
                Analytic.numberofperInsert = Convert.ToString(ComparativeAnalysis.NumberOfPermutations);
                




            }
            return mas;

        }
        
    }
}
