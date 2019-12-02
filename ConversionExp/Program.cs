using System;

namespace ConversionExp
{
    class MainClass
    {
        public static void Main(string[] args)
        {  
        
             //conversion custom de tipo
            CComplejo comp1 = new CComplejo(2, 3);
            //no sep uede
            // CReal real1 = comp1;
            
            //tampoco se puede hasta que coloquemos el explicit
            CReal real2 = (CReal)comp1;
            Console.WriteLine(real2);
        }
    }
}
