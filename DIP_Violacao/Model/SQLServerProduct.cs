﻿namespace DIP_Violacao.Model
{
    class SQLServerProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
