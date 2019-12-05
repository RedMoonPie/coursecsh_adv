using System;
namespace interfaces3
{
    //Ahora implementamos ICalcular que al tener la jerarquia tambien nos forza a implementar IMostrar
    public class CSuma:ICalcular
    {
        private int a;
        private int b;
        private int r;
   

        public int Calculo(int pa, int pb)
        {
            a = pa;
            b = pb;
            r = a + b;
            return r;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, r);
        }
    }
}
