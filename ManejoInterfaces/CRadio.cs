using System;
namespace ManejoInterfaces
{
    public class CRadio:IElectronico
    {
        string marca;
        public CRadio(string pMarca)
        {
            marca = pMarca;
        }

        public override string ToString()
        {
            return string.Format("El radio es marca {0}", marca);
        }

        public void Encender(bool pInterruptor)
        {
            if (pInterruptor)
                Console.WriteLine("Encendido");
            else
                Console.WriteLine("Apagado");
        }
    }
}
