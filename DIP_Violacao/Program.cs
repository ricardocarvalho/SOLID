using DIP_Violacao.Payments;
using System;

namespace DIP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {

            //DIP - Principio da inversão da dependência
            //Criar modulos que não estão ligados
            //Um modulo de alto nivel nao pode depender de um modulo de baixo nivel
            //Ambos precisam depender apenas de abstrações

            //Modulos de alto nivel, é o lugar onde estão as regras de negocio.
            //Modulos de baixo nivel, são as tarefas realizadas pela nossa aplicação. São os detalhes. Data access SQL, Auteticação...

            //Nesse exemplo vamos dizer que precisam usar banco de dados MongoDB e MYSQL

            PaymentProcess payment = new PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();



        }
    }
}
