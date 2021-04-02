namespace LSP_Violacao.Payments
{
    interface IPaymentInstrument
    {

        void Validate();
        void CollectPayment();

    }
}
