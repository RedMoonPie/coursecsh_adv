using System;
namespace MetodosExtension
{
    public class CMiInt:ISaludador
    {
        private int a;

        public CMiInt(int pA)
        {
            a = pA;
        }
        public override string ToString()
        {
            return string.Format(" Tu int es {0}, a");

        }
        public void Saludar()
        {
            Console.WriteLine("Hola desde mi inr {0}", a);
        }
    }
}
