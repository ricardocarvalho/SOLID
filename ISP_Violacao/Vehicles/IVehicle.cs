using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Violacao.Vehicles
{
    interface IVehicle
    {
        //Aqui começa a violação. Na mesma interface falando de carro e moto.
        //Na classe Motocycle classe será obrigatório implementar o metódo ConfigureCar
        //BAIXA COESAO
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
        void ConfigureMotocycle(string color, int year, double engine);
        void StartVehicle();
        
    }
}
