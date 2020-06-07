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
    public partial class frm_Entrada : Form
    {
        public frm_Entrada()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            frm_Categorias cat = new frm_Categorias();
            this.Hide();
            cat.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
