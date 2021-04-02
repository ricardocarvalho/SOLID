using LSP.Payments;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //LSP - Principio da substituição de LISKOV
            //Prega que uma classe derivada "pensando em heração"...
            //Pode ser substituivel por sua classe base sem quebrar o nosso codigo.
            //Agora temos uma demanda de um novo produto. Além de fazer pagamento o cliente pode
            //pontuar num programa de milhagem. 
            //Agora precisamos implementar essa solicitação comercial.
            //Vamos criar a classe NubankRewards

            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();

            //Aqui entra o LSP
            //Vejam em todo sistema chamamos validate e collectpayment.
            //Vamos trocar CreditCard e DebitCard pela nova classe criada.
            NubankRewards card = new NubankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();

        }
    }
}
