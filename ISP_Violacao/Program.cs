using ISP_Violacao.Vehicles;
using System;

namespace ISP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISP - Principio da Segregação de Interface
            //Primeiro é importante identificar dentro das nossas interfaces
            //quais são aquelas que estão "infladas", muitos metodos declarados e códigos que dependem dessas interfaces
            //Os clientes não devem ser forçados a depender de métodos que eles não utilizam
            

            Car car = new Car("Azul", 2022, 4.0, 2, 2);
            Motocycle motocycle = new Motocycle("Branca", 2021, 600);

            Console.ReadLine(); 

        }
    }
}
