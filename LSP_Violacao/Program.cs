using LSP_Violacao.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //LSP - Principio da substituição de LISKOV
            //Prega que uma classe derivada "pensando em heração"...
            //Pode ser substituivel por sua classe base sem quebrar o nosso codigo.

            //CreditCard card = new CreditCard();
            DebitCard card = new DebitCard();
            card.Validate();
            card.CollectPayment();

            Console.ReadLine();

        }
    }
}
