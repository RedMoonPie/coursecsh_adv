using System;
using System.Collections;

namespace Excepciones00
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CCaldera miCaldera = new CCaldera("MAtic0000", 28);
            Random rnd = new Random();

            //v1
            //for(int i = 0; i < 10; i++)
            //{
            //  miCaldera.Trabajar(20);
            //}

            //v2

            //try
            //{
            //    for (int i = 0; i < 10; i++)
            //        miCaldera.Trabajar(20);
            //}
            //catch (Exception e)
            //{
            //    //informacion de excepciones
            //    Console.WriteLine("Sucedio la excepcion \n");
            //    Console.WriteLine("El metodo que produjo la excepcion fue : {0}", e.TargetSite);
            //    Console.WriteLine("El mensaje de la excepcion fue : {0}", e.Message);
            //    Console.WriteLine("Fuente: {0}", e.Source);
            //    Console.WriteLine("La clase donde ocurrio la excepcion fue : {0}", e.TargetSite.DeclaringType);
            //    Console.WriteLine("El tipo de miembro de la excepcion es: {0}", e.TargetSite.MemberType);
            //    Console.WriteLine("Stack de ejecucion : {0}", e.StackTrace);


            //}

            //v3
            //try
            //{
            //    for (int i = 0; i < 10; i++)
            //        miCaldera.Trabajar(20);
            //}
            //catch (Exception e)
            //{
            //    //informacion de excepciones
            //    Console.WriteLine("Sucedio la excepcion \n");
            //    Console.WriteLine("El metodo que produjo la excepcion fue : {0}", e.TargetSite);
            //    Console.WriteLine("El mensaje de la excepcion fue : {0}", e.Message);
            //    Console.WriteLine("Fuente: {0}", e.Source);
            //    Console.WriteLine("La clase donde ocurrio la excepcion fue : {0}", e.TargetSite.DeclaringType);
            //    Console.WriteLine("El tipo de miembro de la excepcion es: {0}", e.TargetSite.MemberType);
            //    Console.WriteLine("Stack de ejecucion : {0}", e.StackTrace);

            //    Console.WriteLine("Help link{0}",e.HelpLink);

            //    //v4
            //    Console.WriteLine("mostramos los datos propios");
            //    //verificamos que existan datos
            //    if (e.Data != null)
            //    {
            //        // imprimimos los datos extra propios
            //        foreach (DictionaryEntry dato in e.Data)
            //            Console.WriteLine("-> {0} -> {1}", dato.Key, dato.Value);
            //    }


            //}
            // v 1 v2 v3 excepcion proia

            while (miCaldera.Funciona)
            {
                try
                {
                    miCaldera.Trabajar(rnd.Next(10));

                }
                //catch(Exception e)
                //{
                //    Console.WriteLine("El mensaje{0}", e.Message);

                //}
                catch(CalderaException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Momento);
                    Console.WriteLine(e.Causa);

                }
            }

        }
    }
}
