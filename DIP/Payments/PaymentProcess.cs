using DIP.Factory;
using DIP.Model;
using System;

namespace DIP.Payments
{
    class PaymentProcess
    {
        //Pay meu metodo de nivel alto. Onde estão as regras de negocio
        public void Pay(string id)
        {
            //Dependendo de uma classe de nivel BAIXO. SQL Server. Não é a regra de negocio.
            //Nessa refatoração vamos criar uma configuração 
            //Vamos utilizar também a abstração e vamos usar factory.

            //Agora na classe de pagamento não vou depender de uma classe de baixo nivel.
            //Vamos ter uma dependencia de abstração. Não importa qual banco.
            //Vamos usar a factory do produto
            //SQLServerProduct product = new SQLServerProduct();

            DbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
