using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Violacao
{
    class Program
    {

        //SRP - Princípio da Responsabilidade Unica
        //Nesse exemplo, seguindo uma ideia de uma classe com métodos CRUD.
        //Cria, consulta, atualiza e deleta cliente
        //Observe, estamos violando o principio. Existe uma funcionalide de notificação
        static void Main(string[] args)
        {
        }

        public void CreateClient()
        {

        }

        public void ReadClient()
        {

        }

        public void UpdateClient()
        {

        }

        public void DeleteClient()
        {

        }


        public void NotifyClient()
        {
            //Aqui está a violação.
            //A partir de agora veja o projeto SRP.
            //Apresento a separação das responsabilidades, assim seguindo o objetivo do SRP.
        }
    }
}
