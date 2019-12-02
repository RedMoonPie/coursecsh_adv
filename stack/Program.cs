using System;
using System.Collections;
namespace stack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack miStack =new Stack();

            //Agregamos elementos 

            miStack.Push("Manzana");
            miStack.Push("pera");
            miStack.Push("Mora");

            //iteramos 

            foreach( string fruta in miStack)
            {
                Console.WriteLine("Fruta {0}", fruta);
            }

            //LiFO  sacar 
            miStack.Pop();
            //devuelve el objeto que esta en el top del stack sin sacarlo
            Console.WriteLine(miStack.Peek());


        }
    }
}
