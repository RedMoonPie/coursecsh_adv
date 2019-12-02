using System;
using System.Collections.Generic;
namespace ColeccionesG1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> valores = new List<int>();


            valores.Add(1);
            valores.Add(7);
            valores.Add(12);
            valores.Add(5);

            foreach (int val in valores)
            {
                Console.WriteLine(val);
            }
            //si lo contiene
            Console.WriteLine(valores.Contains(5));
            // el indice de un elemento/ sino existe -1
            Console.WriteLine(valores.IndexOf(1));
            Console.WriteLine("--------------");
            valores.Insert(2, 67);
            foreach (int val in valores)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("--------------");
            //Eliminar elemente en un indice especifico
            valores.RemoveAt(3);
            foreach (int val in valores)
            {
                Console.WriteLine(val);
            }
            //ELimina la primera ocurrencia de un valor
            valores.Remove(12);

            //lista en sentido contrario
            valores.Reverse();
            Console.WriteLine("--------------");
            foreach (int val in valores)
            {
                Console.WriteLine(val);
            }
            //ordenar la lista icomparable es necesario que se implemente con algun oobjeto propio
            valores.Sort();

            //crear lista para clase

            List<CPunto> listaPuntos = new List<CPunto> {
                //adicion explicita 
                new CPunto(2,3),
                new CPunto(3, 3),
                new CPunto(4, 3),
                new CPunto(2, 6)

        };
            //listaPuntos.Add(new CPunto(2,3));
            //listaPuntos.Add(new CPunto(5, 6));
            //listaPuntos.Add(new CPunto(3, 7));
            //listaPuntos.Add(new CPunto(2, 8));

            foreach( CPunto punto in listaPuntos)
            {
                Console.WriteLine(punto);
            }
            Console.WriteLine("--------------");
            listaPuntos.Sort();
            foreach(CPunto pt in listaPuntos)
            {
                Console.WriteLine(pt);
            }

            //Copiar de lista a arreglo

            CPunto[] arreglop = listaPuntos.ToArray();

        }
    }
}
