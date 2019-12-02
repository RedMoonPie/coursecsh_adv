using System;
using System.Collections.Generic;
namespace Lambdas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Hacemos uso de la expresion lambda
            // i puede tener cualquier otro nombre, es el parametro
            //puede ser colocado explicita (int i) o implicita (i) 

            List<int> numPares = numeros.FindAll(i => (i % 2) == 0);

            //Mostramos los numeros
            foreach (int n in numPares)
                Console.WriteLine(n);
        }
    }
}
