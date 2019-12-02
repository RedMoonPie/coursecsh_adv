using System;

namespace Action_func
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ////Action nos permite crear delegados en el momento, para un maximo de 16 parametros
            ////pero el tipo de retorno debe de ser void

            //int n = 5;
            //string m = "Hola a todos"; 

            ////usamos action para registrar el handler con el delegado

            //Action<string, int> delAction = new Action<string, int>(RepiteMensaje);

            ////Invocamos el delegado
            //delAction(m, n);
            int x = 5;
            int y = 9;

            Func<int, int, int> delFunc = new Func<int, int, int>(Suma);

            Console.WriteLine(delFunc(x, y)); 

        }
        static void RepiteMensaje(string pMensaje, int pVeces)
        {
            int n = 0;
            for (n = 0; n < pVeces; n++)
            {
                Console.WriteLine(pMensaje);
            }
        }
        //Este metodo es el handler para func

        static int Suma(int a , int b)
        {
            int r = 0;
            r = a + b;
            return r;
        }
    }
}
