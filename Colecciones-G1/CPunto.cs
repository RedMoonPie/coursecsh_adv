using System;
namespace ColeccionesG1
{
    public class CPunto:IComparable
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

        public int CompareTo(object obj)
        {
            CPunto tmp = (CPunto)obj;

            if (x > tmp.x && y > tmp.y)
                return 1;
            if (x < tmp.x && y < tmp.y)
                return -1;
            return 0;
        }

       
    }

}
