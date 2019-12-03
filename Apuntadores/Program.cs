using System;

namespace Apuntadores
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //apuntadores
            //Es necesario poner el proyecto en unsafe

            unsafe
            {
                int valor = 5;

                //creo apuntador

                int* p;

                // se hace que p apunte a la direccion de valor

                p = &valor;

                Console.WriteLine(*p);

                //cambiamos el valor
                // p apunta a valor, entonces valor = 67
                *p = 67;

                Console.WriteLine(*p);
                Console.WriteLine(valor);

            }

            Console.WriteLine("Hacemos un swap");

            int a = 3;
            int b = 8;

            Console.WriteLine("a = {0}, b={1}", a, b);

            //Invocamos el metodo que usa apuntadores
            unsafe { swap(&a, &b); }
                Console.WriteLine("a = {0}, b={1}", a, b);
            

            
        }
        //un metodo que usa apuntadores
        unsafe public static void swap(int* n, int* m)
        {
            int temp = *m;

            *m = *n;
            *n = temp;
        }
    }
}
