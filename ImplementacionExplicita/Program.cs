using System;

namespace ImplementacionExplicita
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Forma de implementar dos interfaces con el mismo nombre de metodo

            CCuadrado cuadro = new CCuadrado(5);

            //Cuadro

            ((IPerimetro)cuadro).Calcular();
            ((IArea)cuadro).Calcular();

        }
    }
}
