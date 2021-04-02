using DIP_Violacao.Model;
using System;

namespace DIP_Violacao.Payments
{
    class PaymentProcess
    {
        //Pay meu metodo de nivel alto. Onde estão as regras de negocio
        public void Pay(string id)
        {
            //Dependendo de uma classe de nivel BAIXO. SQL Server. Não é a regra de negocio.
            SQLServerProduct product = new SQLServerProduct();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
