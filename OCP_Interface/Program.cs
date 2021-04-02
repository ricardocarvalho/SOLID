using OCP_Interface.Vehicles;
using System;

namespace OCP_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Outra forma de trabalhar com OCP é o uso de interface


            //TypeVehicle type = TypeVehicle.CAR;
            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);
            }
            else
            {
                Motocycle vehicle = new Motocycle("Branco", 2021, 250);
            }

            Console.ReadLine();
        }
    }
}
