using System;

namespace ISP.Vehicles
{
    class Motocycle : IVehicleMotocycle
    {
        private string color;
        private int year;
        private double engine;

        public Motocycle(string color, int year, double engine)
        {
            ConfigureMotocycle(color, year, engine);

        }

        public void ConfigureMotocycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando moto ano {year}, motor {engine} cilidradas da cor {color}.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!!!");
        }
    }
}
