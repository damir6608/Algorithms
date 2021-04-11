using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3.Движок
{
    public interface Istrategy
    {
        int[] Algorithm(int[] mas, bool flag = true);
    }
    public class Context
    {
        public Istrategy ContextStrategy;
        public static int[] array;
        public Context(Istrategy Strategy)
        {
            this.ContextStrategy = Strategy;
        }
        public Context()
        {

        }
        public void ExecuteAlgorithm(bool flag = true)
        {
            ContextStrategy.Algorithm(array, flag);
        }
    }

     
}
