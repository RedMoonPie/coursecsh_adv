using System;

namespace ManejoInterfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Arreglos de interfaces lo unico que podrian tener en comun es la implementacion de interfaz por ejemplo Ctelevisor y Cradio
            IElectronico[] teles = { new CTelevisor("charp"), new CTelevisor("Zony"), new CRadio("RCB"), new CTelevisor("philips") };

            foreach ( IElectronico aparato  in teles) {

                Console.WriteLine(aparato);
            }
            Console.WriteLine("-------------------------");



            //uso de interfaces con metodos
            CTelevisor miTV = new CTelevisor("Sharp tv");
            CRadio mRadio = new CRadio("Sony Walk man");

            Muestra(miTV);
            Muestra(mRadio);


           

            Console.WriteLine("-------------------------");

            IElectronico aparatocreado = null;
            aparatocreado = CreaAparato();
            aparatocreado.Encender(true);
            Console.WriteLine(aparatocreado);
            

          
        }
      

        // metodos que pueden recibir un objeto que implemente determinada interface

        // Este metodo puede recibir cualquier objeto que implemente IELEctronico

        static void Muestra(IElectronico aparato)
        {
            //Codigo comun a todos los aparatos 
            aparato.Encender(true);
            if (aparato is CTelevisor)
                Console.WriteLine(aparato);
            if (aparato is CRadio)
                Console.WriteLine(aparato);
        }

        //Este metodo regresa o bien un tv o un radio, aprovechando el polimorfismo que nos brindan las interfaces
        static IElectronico CreaAparato()
        {
            IElectronico aparato = null;

            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("Que deseas crear? 1-Tele  -2-Radio ");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if(opcion == 1)
            {
                Console.WriteLine("Dame la marca de la tele");
                dato = Console.ReadLine();
                aparato = new CTelevisor(dato);

            }
            if(opcion == 2)
            {
                Console.WriteLine("Dame la marca de la radio");
                dato = Console.ReadLine();
                aparato = new CRadio(dato);
            }
            return aparato;

        }
    }
}
