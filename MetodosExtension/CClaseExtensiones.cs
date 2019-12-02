using System;
namespace MetodosExtension
{
    //la calse donde se guardan las extension debe ser estatica
    public static class CClaseExtensiones
    {
        // el metodo que extiende debe ser estatico
        //el primer parametro lleva this y represnta al tipo que
        //estamos extendiendo
        public static bool EsPar(this int i)
        {
            if (i % 2 == 2)
                return true;
            else
                return false;

        }
        //este extienda un doble
        public static double Doubletea(this double d)
        {
            return d * 2.0;
        }
        public static void Sonido (this ISaludador s)
        {
            Console.Beep();
        }

    }
}
