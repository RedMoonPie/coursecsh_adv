using System;
using System.Collections.Generic;

namespace Sortedset
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SortedSet<CPunto> pt = new SortedSet<CPunto>();
            pt.Add(new CPunto(5, 2));
            pt.Add(new CPunto(4, 2));
            pt.Add(new CPunto(3, 2));


            foreach(CPunto j in pt)
            {
                Console.WriteLine(j);
            }


        }
    
    }
}
