using Laba3.Движок;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Engine
{
    class RankSortingAnalytic : Istrategy
    {
        public int iterationCount = 0;
        public static Form1 form1;

        public RankSortingAnalytic()
        {

        }
        public int[] Algorithm(int[] mas, bool flag = true)
        {

            if (flag)
            {
               
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
                                

                                ComparativeAnalysis.NumberOfPermutations++;
                                
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


               

                Analytic.forRankSorting = "Ср:" + Convert.ToString(ComparativeAnalysis.Comparison) +
                    "\nПе:" + Convert.ToString(ComparativeAnalysis.NumberOfPermutations) + "\nВр:";
                Analytic.numberofperRank = Convert.ToString(ComparativeAnalysis.NumberOfPermutations);

                Analytic.timeRank += (resultTime.Milliseconds) + (resultTime.Seconds * 1000) + (resultTime.Minutes * 100000);
                Analytic.timeRankformore = (resultTime.Milliseconds) + (resultTime.Seconds * 1000) + (resultTime.Minutes * 100000);



                Analytic.forRankSorting += elapsedTime;
                Analytic.timeforRank += elapsedTime + ", ";
                Analytic.timeforRanktimet = elapsedTime;



            }
            return mas;

        }
    }
}