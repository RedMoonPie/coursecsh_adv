using System;
using System.Collections;
namespace BitArray1
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            BitArray miArreglo = new BitArray(new byte[] { 1, 2, 4, 8, 16 });

            //cantidad de elementos , 5bytes * 8 = 40 bits
            Console.WriteLine(miArreglo.Count);
            MuestraArreglo(miArreglo);

            Console.WriteLine("-----");

            //obtener un bit en particular

            Console.WriteLine(miArreglo.Get(20));

            //poner un bit en particular 
            miArreglo.Set(3, true); // indice y valor en este caso true o false
            MuestraArreglo(miArreglo);
            Console.WriteLine(miArreglo.Get(3));

            Console.WriteLine("------");

            //clonar bitarray
            BitArray arreglo2 = (BitArray)miArreglo.Clone();
            MuestraArreglo(arreglo2);
            //Invertir arreglo Not
            arreglo2.Not();
            //operacion OR
            BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
            arreglo3.Or(miArreglo);

            //Operacion AND
            arreglo3.And(miArreglo);

            //Operacion XOR
            arreglo3.Xor(miArreglo);


        }
        //del mas significativo al menos significativo
        public static void MuestraArreglo(BitArray pArreglo , string pNombre = "")
        {
            int c = 0;
            Console.Write("{0}\t", pNombre);
            foreach(bool b in pArreglo)
            {
                c++;
                if (b)
                    Console.Write("1");

                else
                    Console.Write("0");
                if (c % 8 == 0)
                    Console.Write(",");
            }
        }
    }
}
