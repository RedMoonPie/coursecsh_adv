using System;

namespace ConversionImplicita
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //conversion implicita
            CReal r3 = new CReal(3.5);
            // el compilador la reconoce sin necesidad de type cat
            CComplejo im2 = r3;
            Console.WriteLine(im2);
        }
    }
}
