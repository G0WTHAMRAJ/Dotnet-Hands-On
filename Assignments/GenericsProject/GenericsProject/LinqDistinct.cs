using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class LinqDistinct
    {
        public void linqDistinct()
        {
            Console.WriteLine("Distinct Example");
            List<int> listCollection = new List<int>() { 1,23,4,5,6,7,89,9,54,5,};
            listCollection.Sort();
            {
                Console.WriteLine(listCollection);
            }

            var MS = listCollection.Where(x => x%5== 0).Distinct();
            int maxnum=listCollection.Max();
            int minnum=listCollection.Min();

            var QS=(from num in listCollection select num).Distinct();
            foreach(var item in MS) {
                Console.WriteLine(item);
                    }
            Console.WriteLine("Distinct Example using Query Syntax");
            foreach(var item in QS)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Maximum num {maxnum}");
            Console.WriteLine($"Minimun num {minnum}");

            //Query Syntax
            var MS1 = (from num in MS select num).Distinct();
            foreach(int i in MS1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
