using System;
using System.Collections;
namespace HashTable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hashtable miTabla = new Hashtable();

            //Adicionamos elementos

            miTabla.Add(123, "hola");
            miTabla.Add(234, "saludos");
            miTabla.Add(45, "adios");

            //Mostrar los elementos
            //objeto dictionaryentry 
            foreach(DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }
            //Intentamos colocar un elemento con llave repetida
            // miTabla.Add(123, "otro mas");
            // no puede haber elementos con la mis ma llave 
            Console.WriteLine("----");

            //cantidad de elementos
            Console.WriteLine(miTabla.Count);

            Console.WriteLine("-------");

            //obtenemos el elemento de determinada llave
            //567 es la llave de determinado elemento
            Console.WriteLine(miTabla[123]);
            Console.WriteLine(miTabla[445]);

            Console.WriteLine("----------");

            miTabla[45] = "cabron";
            miTabla[10] = "aloha";
            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }
            // si existe
            Console.WriteLine(miTabla.Contains(123));
            // Eliminar elemento
            miTabla.Remove(234);

            foreach (int key in miTabla.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (string valor in miTabla.Values)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
