using System;

namespace OCP_Interface.Vehicles
{
    class Motocycle : Vehicle
    {

        public Motocycle(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotocycle();
        }

        public void ConfigureMotocycle()
        {
            Console.WriteLine($"Criando uma Moto {color}, {year}, {engine} cilindrada.");
            StartVehicle();
        }
    }
}
