using Laba3.Движок;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laba3.Engine
{
    class InsertAnalityc : Istrategy
    {
        public int iterationCount = 0;
        public static Form1 form1;

        public InsertAnalityc()
        {

        }
        public int[] Algorithm(int[] mas, bool flag = true)
        {
            if (flag)
            {
                
                System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
                myStopwatch.Start();
                //О Т С Ю Д А    Н А Д О    В С Е    М Е Н Я Т Ь ! ! !
                int newElement, location;

                for (int i = 1; i < mas.Length; i++)
                {
                    newElement = mas[i];



                    location = i - 1;

                    this.iterationCount++;
                    
                    ComparativeAnalysis.Comparison++;

                    while (location >= 0 && mas[location] > newElement)
                    {
                        

                        ComparativeAnalysis.NumberOfPermutations++;
                        
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



                

                Analytic.forInsert = "Ср:" + Convert.ToString(ComparativeAnalysis.Comparison) +
                    "\nПе:" + Convert.ToString(ComparativeAnalysis.NumberOfPermutations) + "\nВр:";
                Analytic.numberofperInsert = Convert.ToString(ComparativeAnalysis.NumberOfPermutations);

                Analytic.timeInsert += (resultTime.Milliseconds) + (resultTime.Seconds * 1000) + (resultTime.Minutes * 100000);
                Analytic.timeInsertformore = (resultTime.Milliseconds) + (resultTime.Seconds * 1000) + (resultTime.Minutes * 100000);





                Analytic.forInsert += elapsedTim;
                Analytic.timeforInsert += elapsedTim + ", ";
                Analytic.timeforInsertеtimet = elapsedTim;



            }
            return mas;

        }

    }
}
