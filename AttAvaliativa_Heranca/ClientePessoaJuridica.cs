using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttAvaliativa_Heranca
{
    class ClientePessoaJuridica: Cliente //uso da herança para poder utilizar as variáveis da classe Cliente
    {
        public string cnpj;
        public string nomeFantasia;
        public string razaoSocial;
    }
}
