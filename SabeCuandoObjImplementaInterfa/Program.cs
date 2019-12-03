using System;

namespace SabeCuandoObjImplementaInterfa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //como reconocer si un objeto implenta a determinada interfaz
            CTelevisor miTele = new CTelevisor("Sharpy");
            CPelota miPelota = new CPelota("Grande");
            IElectronico objeto = null;

            //metodo 1, por excepcion

            try
            {
                Console.WriteLine("Probamos la tele");
                objeto = (IElectronico)miTele;
                objeto.Encender(true);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }


            //Metodo 2

            Console.WriteLine("Probamos la tele");
            //se usa as, retorna null sino puede ser tratado como la interface a probar
            objeto = miTele as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No implementa Ielectronico");

            //Metodo 3, por is ( es p es compatible con)

            Console.WriteLine("Probamos la tele");

            if (miTele is IElectronico)
                ((IElectronico)miTele).Encender(true);

            else
                Console.WriteLine("No implementa IElectronico");

            
        }
    }
}
