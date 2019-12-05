using System;
namespace interfaces3
{
    //creamos la gerarquia de interfaces
    //ahora Icalcular aparte de calculo tiene lso metodos de IMostrar
    interface ICalcular:IMostrar
    {
        int Calculo(int a, int b);
    }
}
