using ISP.Vehicles;
using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Azul", 2022, 4.0, 2, 2);
            Motocycle motocycle = new Motocycle("Branca", 2021, 600);

            Console.ReadLine();
        }
    }
}
