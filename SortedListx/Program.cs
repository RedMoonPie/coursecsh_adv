using System;
using System.Collections;
namespace SortedListx
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            //Adicionar, se puede adicionar cualquier objeto o instancia(deben tener la parte de IComparable, 
            // los ordena automaticamente
            sl.Add(754, "honda");
            sl.Add(734, "volvo");
            sl.Add(214, "mazda"); 
            sl.Add(354, "Nissan");
            // Iteramos 
            foreach(DictionaryEntry elelemento in sl)
            {
                Console.WriteLine("({0}, {1})", elelemento.Key, elelemento.Value);
            }
            Console.WriteLine("-----");

            //cantidad
            Console.WriteLine(sl.Count);

            //contains
            Console.WriteLine(sl.Contains(354));
            //contains key
            Console.WriteLine(sl.ContainsKey(123));
            //contains value
            Console.WriteLine(sl.ContainsValue("mazda"));

            //obtenemos por indice, varia de acuerdo a como se ordena 
            //llave en indice 0
            Console.WriteLine(sl.GetKey(0));
            //valor en indice 0
            Console.WriteLine(sl.GetByIndex(0));

        }
    }
}
