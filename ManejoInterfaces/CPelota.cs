using System;
namespace ManejoInterfaces
{ 
    public class CPelota
    {
        string tamano;
        public CPelota(string pTamano)
        {
            tamano = pTamano;
        }
        public override string ToString()
        {
            return string.Format("El tamano de la pelota es {0}", tamano);
        }
    }
}
