using System;

namespace TiposAnonimos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //creamos tipos anonimos
            //crea un tipo temporal con atributos

            //creamos el tipo anonimo
            var miCompu = new { Procesador = "i7", Memoria = 16, Graficos = "intel" };

            //imprimimos la variable
            Console.WriteLine(miCompu);

            //imprimimos un atributo
            Console.WriteLine("La computiene procesador{0}", miCompu.Procesador);
            //No podemos modificar el atributo, es de solo lectura
        }
    }
}
