﻿using System;
namespace ManejoInterfaces
{
    public class CTelevisor:IElectronico
    {
        string marca;
        public CTelevisor(string pMarca)
        {
            marca = pMarca;
        }

        public override string ToString()
        {
            return string.Format("El televisor es marca {0}", marca);
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
