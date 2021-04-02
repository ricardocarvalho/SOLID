using System;

namespace OCP_Violacao
{
    class Program
    {
        //OCP - Princípio Aberto/Fechado
        //As mudanças faz parte do nosso dia-a-dia
        //Como é possível alterar alguma coisa no código sem quebrar o que já funciona.
        //Vamos pensar com o código que seja extensível e evite quebrar o que já existe.
        //Uma das maneiras é usando Herança. 
        static void Main(string[] args)
        {

            //Violação do principio.
            //Parece que tá tudo certo, mas não!
            //Alguns dos principios, por exemplo SRP, não está sendo respeitado.
            //Na mesma classe estamos tratando carro e moto.
            //Não está fechada para modificação, se precisasse de outro veiculo, teriamos que mudar.
            //Vamos aplicar o principio. Veja o projeto OCP

            //TypeVehicle type = TypeVehicle.CAR;
            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {

                Vehicle vehicle = new Vehicle("Azul", 2022, 2.0, 5, 4);
                vehicle.Car();

            }
            else
            {

                Vehicle vehicle = new Vehicle("Branco", 2021, 250, 1, 0);
                vehicle.Motorcycle();

            }

            Console.ReadLine();
        }
    }
}
