using System;
namespace Clase_generica
{
    class CPunto<T>
    {
        // se crean variable de tipo de T
        private T x;
        private T y;

        // podemos recibir parametros de tipo T

        public CPunto(T px, T py)
        {
            x = px;
            y = py;

        }
        public override string ToString()
        {
            return string.Format("x={0}, y={1}", x, y);
        }
        //resetear al valor T
        public void Reset()
        {
            //regresa el valor default de un tipo en particular 
            x = default(T);
            y = default(T);
        }
        public void EncuentraTipo() 
        {
            if (typeof(T) == typeof(int))
                Console.WriteLine("Trabajo como entero");

            else
                Console.WriteLine("soy otro tipo");
        }


    }
}
