using Laba3.Движок;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Engine
{
    public class RankSorting:Istrategy
    {

        public int iterationCount = 0;
        public static Form1 form1;
        
        public RankSorting()
        {

        }
        public int[] Algorithm(int[] mas, bool flag = true)
        {

            if (flag)
            {
                IOFile.FillContent();
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                

                ArrayList[] lists = new ArrayList[10];
                for (int i = 0; i < 10; ++i)
                    lists[i] = new ArrayList();

                {
                    for (int step = 0; step < 3; ++step)
                    {
                        
                        for (int i = 0; i < mas.Length; ++i)
                        {
                            this.iterationCount++;
                            IOFile.Content += this.iterationCount.ToString() + " итерация: " + '\n';
                            IOFile.InputInfoAboutComparison(mas[step], mas[i]);
                            ComparativeAnalysis.Comparison++;

                            int temp = (mas[i] % (int)Math.Pow(10, step + 1)) /
                                           (int)Math.Pow(10, step);
                            lists[temp].Add(mas[i]);
                        }
                        int k = 0;
                        for (int i = 0; i < 10; ++i)
                        {
                            for (int j = 0; j < lists[i].Count; ++j)
                            {
                                mas[k++] = (int)lists[i][j];
                                IOFile.InputInfoAboutTransposition(mas[i], mas[j]);

                                ComparativeAnalysis.NumberOfPermutations++;
                                IOFile.FillContent();
                                form1.AddItemsListBox(mas[i], mas[j]);
                            }

                        }
                        for (int i = 0; i < 10; ++i)
                            lists[i].Clear();


                       
                    }
                }
                myStopwatch.Stop();
                var resultTime = myStopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                    resultTime.Hours,
                    resultTime.Minutes,
                    resultTime.Seconds,
                    resultTime.Milliseconds);
              

                form1.labelCountComparison.Text = Convert.ToString(ComparativeAnalysis.Comparison);
                form1.labelNumberOfPermutations.Text = Convert.ToString(ComparativeAnalysis.NumberOfPermutations);
                form1.labelTimeSort.Text = elapsedTime;

                Analytic.forRankSorting = "Ср:" + Convert.ToString(ComparativeAnalysis.Comparison) + 
                    "\nПе:"+ Convert.ToString(ComparativeAnalysis.NumberOfPermutations)+"\nВр:";
                Analytic.numberofperRank = Convert.ToString(ComparativeAnalysis.NumberOfPermutations);
               




            }
            return mas;

        }
    }
}
