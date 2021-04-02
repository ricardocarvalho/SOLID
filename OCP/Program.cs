using OCP.Vehicles;
using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vamos aplicar o conceito da herança;
            //Por exemplo, a moto não tem porta e/ou quantidade de assentos, vamos tratar isso.

            TypeVehicle type = TypeVehicle.CAR;
            //TypeVehicle type = TypeVehicle.MOTORCYCLE;

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
