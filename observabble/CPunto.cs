using System;
using System.Collections.Generic;
namespace observabble
{
    public class CPunto:IComparable<CPunto>
    {
        private int x;
        private int y;

        public CPunto(int px, int py)
        {
            x = px;
            y = py;
        }
        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", x, y);
        }

        public int CompareTo(CPunto obj)
        {   //Calculo de magnitudes para reglas
            double mg1 = Math.Sqrt(x * x + y * y);
            double mg2 = Math.Sqrt(obj.x * obj.x + obj.y * obj.y);
            //reglas comparacion
            if (mg1 < mg2) return -1;
            if (mg1 > mg2) return 1;
            if (obj == null) return 1;

            return 0;
           
        }
        //Greater operator 
        public static bool operator > (CPunto p1, CPunto p2)
        {
            return p1.CompareTo(p2) == 1;
        }
        //lees
        public static bool operator < (CPunto p1 , CPunto p2)
        {
            return p1.CompareTo(p2) == -1;
        }
        //g and e
        public static bool operator >= (CPunto p1 , CPunto p2)
        {
            return p1.CompareTo(p2) == 0;
        }
        //l an e
        public static bool operator <= (CPunto p1, CPunto p2)
        {
            return p1.CompareTo(p2) == 0;
        }
    }

}
