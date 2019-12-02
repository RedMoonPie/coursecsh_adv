using System;
using System.Collections.Generic;

namespace Predicados
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //indicamos el delegado
            Predicate<int> delegado = new Predicate<int>(pares);

            //invocamos metodo
            List<int> numPares = numeros.FindAll(delegado);

            //mostramos

            foreach (int n in numPares)
                Console.WriteLine(n);
        }
        //este es el delegado, debe ser bool si cumple o no
        static bool pares(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
        static bool Rango(int n)
        {
            if (n >= 3 && n <= 7)
                return true;
            else
                return false;
        }

    }
}
