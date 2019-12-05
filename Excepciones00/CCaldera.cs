using System;
namespace Excepciones00
{
    public class CCaldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public int Temperatura {get { return tempActual; } set { tempActual = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public bool Funciona { get { return funciona; } }

        public CCaldera(string pMarca , int pTemp)
        {
            tempActual = pTemp;
            marca = pMarca;
        }

        //hacemos trabajar la caldera, sin usar excepciones
        //v1

        //public void Trabajar (int pAumento)
        //{
        //    if (funciona == false)
        //        Console.WriteLine("La caldera {0} esta descompuesta", marca);
        //    else
        //    {
        //        tempActual += pAumento;
        //        Console.WriteLine("La temperatura actual es de {0}", tempActual);

        //        if(tempActual > tempMax)
        //        {
        //            Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
        //            tempActual = tempMax;
        //            funciona = false;
        //        }
        //    }
        //}

        //v2 levantamos una excepcion cuando sucede el problema
        public void Trabajar( int pAumento)
        {
            //if (funciona == false)
            //    Console.WriteLine("La caldera {0} esta descompuesta", marca);
            //else
            //{
            //    tempActual += pAumento;
            //    Console.WriteLine("La temperatura actual es de {0}", tempActual);

            //    if (tempActual > tempMax)
            //    {
            //        Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
            //        tempActual = tempMax;
            //        funciona = false;

            //        //Lanzamos la excepcion

            //        throw new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
            //    }
            //}
            //v3
            //if(funciona == false)
            //    Console.WriteLine("La caldera {0} esta descompuesta", marca);
            //else
            //{
            //    tempActual += pAumento;
            //    Console.WriteLine("La temperatura actual es de {0}", tempActual);

            //    if (tempActual > tempMax)
            //    {
            //        Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
            //        tempActual = tempMax;
            //        funciona = false;

            //        //Lanzamos la excepcion
            //        //y tenemos una variable para la instancia
            //        Exception ex = new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
            //        //helo link nos permite ligar eso a donde se encuentra la documentacion etc direccion url....
            //        ex.HelpLink = "http://www.nicosio.com";

            //        throw ex;



            //    }
            //}

            //v4
            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura, tiene {1}", marca, tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    //Lanzamos la excepcion
                    //y tenemos una variable para la instancia
                    //Exception ex = new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
                    ////helo link nos permite ligar eso a donde se encuentra la documentacion etc direccion url....
                    //ex.HelpLink = "http://www.nicosio.com";

                    //// Adicionamos datos propios a la excepcion
                    //ex.Data.Add("Momento: ", string.Format("ocurrio en {0}", DateTime.Now));
                    //ex.Data.Add("Temperatura actual: ", string.Format("{0} grados", tempActual));
                    //ex.Data.Add("Incremento dado:", string.Format(" {0} grados", pAumento));

                    //v1 propia excecion
                    //creamos instancia de nuestra excepcion
                    CalderaException ex = new CalderaException(string.Format("La caldera{0} se ha sobrecalentado", marca), "Ha trabajado demasiado tiempo",DateTime.Now);

                    //colocamos link de ayuda
                    ex.HelpLink = "http://www.nicosio.com";
                    throw ex;



                }
            }
        }
    }

    //v1 de la clase de excepcion
    //todas las clases de excepcion propias deben de tener acceso publico

    public class CalderaException : ApplicationException
    {
        private string mensaje = "";
        private DateTime momento;
        private string causa;

        public DateTime Momento { get { return momento; } set { momento = value; } }
        public string Causa { get { return causa; } set { causa = value; } }

        public CalderaException(string pMensaje, string pCausa, DateTime pMomento)
        {
            mensaje = pMensaje;
            causa = pCausa;
            momento = pMomento;
        }

        //hacemos un override a la propiedad Exception.Message

        public override string Message
        {
            get
            {

                return string.Format("Mensaje de la excepcion => {0}",mensaje);

            }

        }
    }
}
