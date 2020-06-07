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
    public partial class frm_CadastroFisica : Form
    {
        public frm_CadastroFisica()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Bairro.Text == "" || txt_Cidade.Text == "" || txt_Cpf.Text == "" || txt_Endereco.Text == "" || txt_Estado.Text == "" || txt_Nome.Text == "" || txt_Rg.Text == "" || txt_Telefone.Text == "")
            {
                MessageBox.Show("Digite todos os dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //chamada da classe ClientePessoaFisica e atribuição das variaveis nas textbox
                ClientePessoaFisica cfis = new ClientePessoaFisica();

                cfis.bairro = txt_Bairro.Text;
                cfis.cidade = txt_Cidade.Text;
                cfis.cpf = txt_Cpf.Text;
                cfis.endereco = txt_Endereco.Text;
                cfis.estado = txt_Estado.Text;
                cfis.nome = txt_Nome.Text;
                cfis.rg = txt_Rg.Text;
                cfis.telefone = txt_Telefone.Text;

                MessageBox.Show("Bairro: " + cfis.bairro + "\nCidade: " + cfis.cidade + "\nCPF: " + cfis.cpf + "\nEndereço: " + cfis.endereco + "\nEstado: " + cfis.estado + "\nNome: " + cfis.nome + "\nRG: " + cfis.rg + "\nTelefone: " + cfis.telefone, "Dados cadastrados com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Bairro.Clear();
            txt_Cidade.Clear();
            txt_Cpf.Clear();
            txt_Endereco.Clear();
            txt_Estado.Clear();
            txt_Nome.Clear();
            txt_Rg.Clear();
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

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
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
