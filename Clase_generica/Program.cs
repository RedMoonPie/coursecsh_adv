using System;

namespace Clase_generica
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CPunto<int> puntoI = new CPunto<int>(3, 4);

            //para puntoD, T trabaja como double
            CPunto<double> puntoD = new CPunto<double>(2.56, 1.87);

            CPunto<float> puntoG = new CPunto<float>(8.98f, 7.69f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoG);

            //colocamos el valor de default
            puntoI.Reset();
            Console.WriteLine(puntoI);

            //Verificamos si esta trabajado con entero
            puntoI.EncuentraTipo();
            puntoD.EncuentraTipo();

        } 
    }
}
