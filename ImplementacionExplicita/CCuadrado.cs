using System;
namespace ImplementacionExplicita
{
    public class CCuadrado: IArea, IPerimetro
    {
        // ambos tienen el mismo metodo con el mismo nombre

        private int lado;

        public CCuadrado(int pLado)
        {
            lado = pLado;
        }

        void IArea.Calcular()
        {
            Console.WriteLine("Calcular area = {0}", lado * lado);
        }
        void IPerimetro.Calcular()
        {
            Console.WriteLine("Calcular perimetro = {0} ", lado * 4);
        }

    }
}
