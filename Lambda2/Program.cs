using System;
using System.Collections.Generic;
namespace Lambda2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //hacemos uso de la expresion lambda

            List<int> numpares = numeros.FindAll((i)=>
           {
               if(i % 2 == 0)
               {
                   Console.WriteLine("Un par");
                   return true;
               }
               else
               {
                   Console.WriteLine("Un impar");
                   return false;
               }

           });

            //mostramos los numeros
            foreach (int n in numpares)
                Console.WriteLine(n);

        }
    }
}
