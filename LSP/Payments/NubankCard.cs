using System;

namespace LSP.Payments
{
    abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
        }

        public virtual void Validate()
        {
            //Validação básica do cartão
        }
    }
}
