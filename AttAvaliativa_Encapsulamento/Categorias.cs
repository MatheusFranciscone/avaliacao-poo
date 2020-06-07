using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttAvaliativa_Encapsulamento
{
    public partial class frm_Categorias : Form
    {
        public frm_Categorias()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (txt_ValorVenda.Text == "" || rdb_Categoria1.Checked == false && rdb_Categoria2.Checked == false && rdb_Categoria3.Checked == false)
            {
                MessageBox.Show("Digite todas as informações para terminar o cálculo!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Comissao cat = new Comissao(); //chamada da classe comissao

                double precoVenda = double.Parse(txt_ValorVenda.Text); //atribuicao do texto em uma variavel

                double categoria = 0;

                //criação de condição caso o usuario clique em um radio button
                if (rdb_Categoria1.Checked)
                {
                    categoria = 1;
                }
                else if (rdb_Categoria2.Checked)
                {
                    categoria = 2;
                }
                else if (rdb_Categoria3.Checked)
                {
                    categoria = 3;
                }

                //atribuição do metodo calcularcomissao para a variavel result
                double result = cat.CalculaComissao(precoVenda, categoria);

                txt_ValorComissao.Text = result.ToString();
            }

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

            rdb_Categoria1.Checked = false;
            rdb_Categoria2.Checked = false;
            rdb_Categoria3.Checked = false;
            txt_ValorComissao.Text = "0";
            txt_ValorVenda.Clear();
            txt_ValorVenda.Focus();
        }
    }
}
