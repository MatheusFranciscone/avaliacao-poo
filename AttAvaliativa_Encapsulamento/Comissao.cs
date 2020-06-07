using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AttAvaliativa_Encapsulamento
{
    class Comissao
    {
        //criação de atributos privados, ou seja, não é possível alterar os valores
        private double categoria1 = 10; 
        private double categoria2 = 15;
        private double categoria3 = 20;

        //método público para calcular a comissão com dois parâmetros, retornando o valor da comissão ao fim
        public double CalculaComissao(double valorVenda, double categoriaVendedor)
        {
            double valorComissao = 0;

            switch (categoriaVendedor) //criação de laço de repetição para calcular a comissao do vendedor
            {
                case 1:
                    valorComissao = (valorVenda * categoria1/100);
                    break;

                case 2:
                    valorComissao = (valorVenda * categoria2/100);
                    break;

                case 3:
                    valorComissao = (valorVenda * categoria3/100);
                    break;
            }
            return valorComissao;  
        }

    }
}
