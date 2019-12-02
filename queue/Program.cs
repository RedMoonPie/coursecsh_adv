using System;
using System.Collections;
namespace queue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue miQ = new Queue();

            //Adicionamos objeto
            miQ.Enqueue("Manzanda");
            miQ.Enqueue("Fresa");
            miQ.Enqueue("Pera");

            //Iteramos 
            foreach ( string fruta in miQ)
            {
                Console.WriteLine("->{0}", fruta);
            }
            Console.WriteLine("------");

            //Obtener objetos Dequeue

            Console.WriteLine("Dequeue {0}", miQ.Dequeue());
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());
            foreach (string fruta in miQ)
            {
                Console.WriteLine("->{0}", fruta);
            }
            Console.WriteLine("------");

            //Adicionar objeto
            miQ.Enqueue("limon");
            miQ.Enqueue("manco");
            miQ.Enqueue("mora");

            //observamos el primer elemento sin extraerlo
            Console.WriteLine("Peek{0}", miQ.Peek());
            foreach (string fruta in miQ)
            {
                Console.WriteLine("->{0}", fruta);
            }
            Console.WriteLine("------");

            //contar
            Console.WriteLine(miQ.Count);

            //si existe
            Console.WriteLine(miQ.Contains("pera"));
        }
    }
}
