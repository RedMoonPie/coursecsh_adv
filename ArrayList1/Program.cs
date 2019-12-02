using System;
using System.Collections;

namespace ArrayList1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //colecciones dentro de System.Collection
            // ArrayList
            //BitArray
            //HashTable (k,v)
            //queue
            //sortedList (k,v), k[]
            //stack

            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            // Adicionar con rango - pasar arreglo comun y corriento a un arraylist
            palabras.AddRange(new string[] {"hola","como" ,"Estan"}); // se pasa una coleccion como parametros

            Console.WriteLine("Cantidad de eleetos en el ArrayList es {0}", palabras.Count);

            //recorremos con ciclo for

            for (n = 0; n < palabras.Count; n++)
                Console.Write("{0}", palabras[n]);


            Console.WriteLine();
            Console.WriteLine("---------");
            // otra forma de agragar elementos
            palabras. Add("putos");

            //recorremos con foreach

            foreach(string palabra in palabras)
            {
                Console.Write("{0}", palabra);
            }
            Console.WriteLine();
            Console.WriteLine("----------------");


            // varios valores

            ArrayList valores = new ArrayList();
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            //Recorremos con ciclo for
            for(n=0; n < valores.Count; n++)
            {
                // es necesario hacer typecast puesto que las colecciones siempre se guardan como objects
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            // verificar si un elemento existe dentro del ArrayList
            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));
            Console.WriteLine("-----");

            valores.Insert(2, 99);
            for (n = 0; n < valores.Count; n++)
            {
                // es necesario hacer typecast puesto que las colecciones siempre se guardan como objects
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("-----");

        }
    }
}
