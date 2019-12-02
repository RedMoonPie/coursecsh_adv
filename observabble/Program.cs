using System;
using System.Collections.ObjectModel;
namespace observabble
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ObservableCollection<CPunto> pt = new ObservableCollection<CPunto>()
            {
                new CPunto (5,33), new CPunto(20,20)};

            //Adicionamos el handler

            pt.CollectionChanged += pt_CollectionChanged;

            pt.Add(new CPunto(3, 3));

            CPunto miPunto = new CPunto(5, 4);

            pt.Add(miPunto);
            pt.Remove(miPunto);


        }
        static void pt_CollectionChanged(object send,System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //vemos el tipo evento que ocurrio

            Console.WriteLine("El evento es {0}", e.Action);

            //Si la accion es adicionar

            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos");
                foreach(CPunto p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());

                }
            }
            //si la accion es remover
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos afectados por el cambio");
                foreach (CPunto p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());

                }
                Console.WriteLine();
            }
        }
    }
}
