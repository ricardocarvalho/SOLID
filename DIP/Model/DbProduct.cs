namespace DIP.Model
{
    interface DbProduct
    {
        //Aqui seria todas as regras, todas as assinaturas necessarias do produto
        // Essa é a abstração
        string GetProductById(string id);
    }
}
