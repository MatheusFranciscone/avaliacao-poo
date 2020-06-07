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
    public partial class frm_Entrada : Form
    {
        public frm_Entrada()
        {
            InitializeComponent();
        }

        private void btn_Fisica_Click(object sender, EventArgs e)
        {
            //ao clicar nesse botao ele é direcionado ao formulario da pessoa fisica
            frm_CadastroFisica fisica = new frm_CadastroFisica();
            this.Hide();
            fisica.Show();
        }

        private void btn_Juridica_Click(object sender, EventArgs e)
        {
            //ao clicar nesse botao ele é direcionado ao formulario da pessoa juridica
            frm_CadastroJuridica juridica = new frm_CadastroJuridica();
            this.Hide();
            juridica.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
