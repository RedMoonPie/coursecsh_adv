using System;

namespace Delegado_generico_Action
{
    public delegate void miDelegado<T>(T p);
    class MainClass
    {

        public static void Main(string[] args)
        {
            //Registramos y usamos el string
            miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
            delCadena("Hola a todos");

            //regustramos y usamos el double
            miDelegado<double> delDouble = new miDelegado<double>(HandlerDouble);
            delDouble(58.7);
        }

        static void HandlerString(string p)
        {
            Console.WriteLine("uso string como tipo y el valor {0} es ", p);

        }
        //handler para double

        static void HandlerDouble(double p)
        {
            Console.WriteLine("Uso double como tipo y el valor es {0}", p);
        }
    }
}
