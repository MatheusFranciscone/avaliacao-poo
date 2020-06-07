namespace AttAvaliativa_Encapsulamento
{
    partial class frm_Categorias
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Categorias));
            this.gpb_Categoria = new System.Windows.Forms.GroupBox();
            this.rdb_Categoria3 = new System.Windows.Forms.RadioButton();
            this.rdb_Categoria2 = new System.Windows.Forms.RadioButton();
            this.rdb_Categoria1 = new System.Windows.Forms.RadioButton();
            this.txt_ValorVenda = new System.Windows.Forms.TextBox();
            this.txt_ValorComissao = new System.Windows.Forms.TextBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.lbl_ValorComissao = new System.Windows.Forms.Label();
            this.lbl_ValorVenda = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.gpb_Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Categoria
            // 
            this.gpb_Categoria.Controls.Add(this.rdb_Categoria3);
            this.gpb_Categoria.Controls.Add(this.rdb_Categoria2);
            this.gpb_Categoria.Controls.Add(this.rdb_Categoria1);
            this.gpb_Categoria.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Categoria.ForeColor = System.Drawing.Color.White;
            this.gpb_Categoria.Location = new System.Drawing.Point(16, 55);
            this.gpb_Categoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Categoria.Name = "gpb_Categoria";
            this.gpb_Categoria.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Categoria.Size = new System.Drawing.Size(193, 214);
            this.gpb_Categoria.TabIndex = 1;
            this.gpb_Categoria.TabStop = false;
            this.gpb_Categoria.Text = "Categorias:";
            // 
            // rdb_Categoria3
            // 
            this.rdb_Categoria3.AutoSize = true;
            this.rdb_Categoria3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Categoria3.Location = new System.Drawing.Point(9, 170);
            this.rdb_Categoria3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_Categoria3.Name = "rdb_Categoria3";
            this.rdb_Categoria3.Size = new System.Drawing.Size(125, 27);
            this.rdb_Categoria3.TabIndex = 2;
            this.rdb_Categoria3.Text = "Categoria 3";
            this.rdb_Categoria3.UseVisualStyleBackColor = true;
            // 
            // rdb_Categoria2
            // 
            this.rdb_Categoria2.AutoSize = true;
            this.rdb_Categoria2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Categoria2.Location = new System.Drawing.Point(9, 108);
            this.rdb_Categoria2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_Categoria2.Name = "rdb_Categoria2";
            this.rdb_Categoria2.Size = new System.Drawing.Size(125, 27);
            this.rdb_Categoria2.TabIndex = 1;
            this.rdb_Categoria2.Text = "Categoria 2";
            this.rdb_Categoria2.UseVisualStyleBackColor = true;
            // 
            // rdb_Categoria1
            // 
            this.rdb_Categoria1.AutoSize = true;
            this.rdb_Categoria1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Categoria1.Location = new System.Drawing.Point(9, 45);
            this.rdb_Categoria1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_Categoria1.Name = "rdb_Categoria1";
            this.rdb_Categoria1.Size = new System.Drawing.Size(125, 27);
            this.rdb_Categoria1.TabIndex = 0;
            this.rdb_Categoria1.Text = "Categoria 1";
            this.rdb_Categoria1.UseVisualStyleBackColor = true;
            // 
            // txt_ValorVenda
            // 
            this.txt_ValorVenda.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorVenda.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_ValorVenda.Location = new System.Drawing.Point(252, 73);
            this.txt_ValorVenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ValorVenda.Name = "txt_ValorVenda";
            this.txt_ValorVenda.Size = new System.Drawing.Size(132, 25);
            this.txt_ValorVenda.TabIndex = 0;
            this.txt_ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_ValorComissao
            // 
            this.txt_ValorComissao.Enabled = false;
            this.txt_ValorComissao.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorComissao.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_ValorComissao.Location = new System.Drawing.Point(252, 244);
            this.txt_ValorComissao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ValorComissao.Name = "txt_ValorComissao";
            this.txt_ValorComissao.Size = new System.Drawing.Size(132, 25);
            this.txt_ValorComissao.TabIndex = 4;
            this.txt_ValorComissao.Text = "0";
            this.txt_ValorComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(72, 9);
            this.lbl_Texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(255, 24);
            this.lbl_Texto.TabIndex = 3;
            this.lbl_Texto.Text = "Digite o valor de sua venda";
            // 
            // lbl_ValorComissao
            // 
            this.lbl_ValorComissao.AutoSize = true;
            this.lbl_ValorComissao.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorComissao.Location = new System.Drawing.Point(226, 219);
            this.lbl_ValorComissao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ValorComissao.Name = "lbl_ValorComissao";
            this.lbl_ValorComissao.Size = new System.Drawing.Size(138, 20);
            this.lbl_ValorComissao.TabIndex = 4;
            this.lbl_ValorComissao.Text = "Valor da Comissão:";
            // 
            // lbl_ValorVenda
            // 
            this.lbl_ValorVenda.AutoSize = true;
            this.lbl_ValorVenda.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorVenda.Location = new System.Drawing.Point(226, 48);
            this.lbl_ValorVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ValorVenda.Name = "lbl_ValorVenda";
            this.lbl_ValorVenda.Size = new System.Drawing.Size(120, 20);
            this.lbl_ValorVenda.TabIndex = 5;
            this.lbl_ValorVenda.Text = "Valor da venda:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.White;
            this.btn_Calcular.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Calcular.Location = new System.Drawing.Point(252, 146);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(132, 35);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Sair.Location = new System.Drawing.Point(230, 289);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(117, 34);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.White;
            this.btn_Limpar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Limpar.Location = new System.Drawing.Point(54, 289);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(117, 34);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // frm_Categorias
            // 
            this.AcceptButton = this.btn_Calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(399, 337);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_ValorVenda);
            this.Controls.Add(this.lbl_ValorComissao);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.txt_ValorComissao);
            this.Controls.Add(this.txt_ValorVenda);
            this.Controls.Add(this.gpb_Categoria);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.gpb_Categoria.ResumeLayout(false);
            this.gpb_Categoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_Categoria;
        private System.Windows.Forms.RadioButton rdb_Categoria3;
        private System.Windows.Forms.RadioButton rdb_Categoria2;
        private System.Windows.Forms.RadioButton rdb_Categoria1;
        private System.Windows.Forms.TextBox txt_ValorVenda;
        private System.Windows.Forms.TextBox txt_ValorComissao;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label lbl_ValorComissao;
        private System.Windows.Forms.Label lbl_ValorVenda;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

