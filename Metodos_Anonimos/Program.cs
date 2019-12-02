using System;

namespace Metodos_Anonimos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CPunto miPunto = new CPunto(5, 6);

            //creamos el metodo anonimo para el delegado

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Estoy desde el metodo anonimo");
            };
            Console.WriteLine(miPunto.ToString());

            //invocamos 

            miPunto.mensaje();

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Soy don vergas");
            };
            miPunto.mensaje();

        }
    }
}
