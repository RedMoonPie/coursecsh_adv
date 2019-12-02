using System;
namespace Metodos_Anonimos
{
    public class CPunto
    {
        public delegate void DelMensaje();

        public DelMensaje mensaje;
        private int x;
        private int y;
        public CPunto(int px, int py)
        {
            x = px;
            y = py;
        }
        public override string ToString()
        {
            return string.Format("x={0}, y{1}", x, y);
        }
    }
}
