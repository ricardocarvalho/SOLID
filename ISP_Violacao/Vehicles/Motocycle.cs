using System;

namespace ISP_Violacao.Vehicles
{
    class Motocycle : IVehicle
    {
        private string color;
        private int year;
        private double engine;

        public Motocycle(string color, int year, double engine)
        {
            ConfigureMotocycle(color, year, engine);

        }
        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            //Violação. Estamos na classe motocycle
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
