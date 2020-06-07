using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttAvaliativa_Heranca
{
    public partial class frm_CadastroJuridica : Form
    {
        public frm_CadastroJuridica()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Bairro.Text == "" || txt_Cidade.Text == "" || txt_Cnpj.Text == "" || txt_Endereco.Text == "" || txt_Estado.Text == "" || txt_NomeFantasia.Text == "" || txt_RazaoSocial.Text == "" || txt_Telefone.Text == "")
            {
                MessageBox.Show("Digite todos os dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //chamada da classe ClientePessoaJuridica e atribuição das variaveis nas textbox
                ClientePessoaJuridica cjud = new ClientePessoaJuridica();

                cjud.bairro = txt_Bairro.Text;
                cjud.cidade = txt_Cidade.Text;
                cjud.cnpj = txt_Cnpj.Text;
                cjud.endereco = txt_Endereco.Text;
                cjud.estado = txt_Estado.Text;
                cjud.nomeFantasia = txt_NomeFantasia.Text;
                cjud.razaoSocial = txt_RazaoSocial.Text;
                cjud.telefone = txt_Telefone.Text;

                MessageBox.Show("Bairro: " + cjud.bairro + "\nCidade: " + cjud.cidade + "\nCNPJ: " + cjud.cnpj + "\nEndereço: " + cjud.endereco + "\nEstado: " + cjud.estado + "\nNome Fantasia: " + cjud.nomeFantasia + "\nRazão Social: " + cjud.razaoSocial + "\nTelefone: " + cjud.telefone, "Dados cadastrados com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Bairro.Clear();
            txt_Cidade.Clear();
            txt_Cnpj.Clear();
            txt_Endereco.Clear();
            txt_Estado.Clear();
            txt_NomeFantasia.Clear();
            txt_RazaoSocial.Clear();
            txt_Telefone.Clear();
            txt_Endereco.Focus();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frm_Entrada ent = new frm_Entrada();
            this.Close();
            ent.Show();
        }

        private void txt_Bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_Cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_Estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
