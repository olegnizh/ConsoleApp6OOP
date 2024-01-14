using System;

namespace ConsoleApp632
{
    class Program
    {
        static void Main(string[] args)
        {

            Bus bus = new Bus();
            bus.PrintStatus();

        }



    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {

            if ( (Load.HasValue) && (Load > 0) )
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }

        }
    }

}
