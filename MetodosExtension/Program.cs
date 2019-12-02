using System;

namespace MetodosExtension
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // extension del int
            int numero = 55;
            bool par = numero.EsPar();// aqui se encuentra la extension


            Console.WriteLine("{0} es {1} !", numero,par);

            //Extension del double
            double valor = 55.18;
            Console.WriteLine(valor.Doubletea());

            //Extension Isaludador
            CMiInt entero = new CMiInt(7);
            entero.Sonido();


        }
    }
}
