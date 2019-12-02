using System;
using System.Collections;

namespace metodo_generico
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("x={0}, y={1}", x, y);
            //version intercabio T > int 
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("x={0}, y={1}", x, y);
                 
            double m = 78.9;
            double n = 98.6;


            Console.WriteLine("m={0}, n={1}", m, n);
            Intercambio<double>(ref m, ref n);
            Console.WriteLine("m={0}, n={1}", m, n);

        }

        static void Intercambio<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;


        }
    }

   






}
