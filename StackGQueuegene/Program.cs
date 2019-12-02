using System;
using System.Collections.Generic;


namespace StackGQueuegene
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<CPunto> pt = new Stack<CPunto>();
            pt.Push(new CPunto(2, 4));
            pt.Push(new CPunto(5, 4));
            pt.Push(new CPunto(8, 2));
            pt.Push(new CPunto(3, 4));

            foreach(CPunto p in pt)
            {
                Console.WriteLine("->{0}", p);
            }
            Console.WriteLine("--------");

            //hacemos peek
            Console.WriteLine(pt.Peek());
            //pop
            Console.WriteLine(pt.Pop());

            Queue<CPunto> qpt = new Queue<CPunto>();
            //Encolar
            qpt.Enqueue(new CPunto(2, 3));
            qpt.Enqueue(new CPunto(3, 3));
            qpt.Enqueue(new CPunto(4, 3));
            //mostrar top
            qpt.Peek();
            //desencolar
            qpt.Dequeue();
             

        }
    }
}
