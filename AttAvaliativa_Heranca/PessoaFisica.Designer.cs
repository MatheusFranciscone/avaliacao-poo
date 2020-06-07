namespace AttAvaliativa_Heranca
{
    partial class frm_CadastroFisica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroFisica));
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Rg = new System.Windows.Forms.TextBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Rg = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Endereco.Location = new System.Drawing.Point(86, 45);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(348, 22);
            this.txt_Endereco.TabIndex = 0;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Bairro.Location = new System.Drawing.Point(86, 74);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(116, 22);
            this.txt_Bairro.TabIndex = 1;
            this.txt_Bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Bairro_KeyPress);
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Cidade.Location = new System.Drawing.Point(269, 74);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(165, 22);
            this.txt_Cidade.TabIndex = 2;
            this.txt_Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cidade_KeyPress);
            // 
            // txt_Estado
            // 
            this.txt_Estado.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Estado.Location = new System.Drawing.Point(210, 106);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(224, 22);
            this.txt_Estado.TabIndex = 4;
            this.txt_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Estado_KeyPress);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Telefone.Location = new System.Drawing.Point(82, 178);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(139, 22);
            this.txt_Telefone.TabIndex = 7;
            this.txt_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefone_KeyPress);
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Cpf.Location = new System.Drawing.Point(56, 140);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(118, 22);
            this.txt_Cpf.TabIndex = 5;
            this.txt_Cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cpf_KeyPress);
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Nome.Location = new System.Drawing.Point(86, 106);
            this.txt_Nome.MaxLength = 2;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(45, 22);
            this.txt_Nome.TabIndex = 3;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // txt_Rg
            // 
            this.txt_Rg.ForeColor = System.Drawing.Color.Crimson;
            this.txt_Rg.Location = new System.Drawing.Point(229, 140);
            this.txt_Rg.Name = "txt_Rg";
            this.txt_Rg.Size = new System.Drawing.Size(206, 22);
            this.txt_Rg.TabIndex = 6;
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Texto.Location = new System.Drawing.Point(36, 9);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(383, 19);
            this.lbl_Texto.TabIndex = 8;
            this.lbl_Texto.Text = "Digite as suas informações para realizar o cadastro";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Endereco.Location = new System.Drawing.Point(14, 48);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(66, 14);
            this.lbl_Endereco.TabIndex = 9;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Bairro.Location = new System.Drawing.Point(14, 78);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(44, 14);
            this.lbl_Bairro.TabIndex = 10;
            this.lbl_Bairro.Text = "Bairro:";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Cidade.Location = new System.Drawing.Point(212, 78);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(52, 14);
            this.lbl_Cidade.TabIndex = 11;
            this.lbl_Cidade.Text = "Cidade:";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Estado.Location = new System.Drawing.Point(14, 109);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(50, 14);
            this.lbl_Estado.TabIndex = 12;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Telefone.Location = new System.Drawing.Point(14, 181);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(60, 14);
            this.lbl_Telefone.TabIndex = 13;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Cpf.Location = new System.Drawing.Point(14, 143);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(34, 14);
            this.lbl_Cpf.TabIndex = 14;
            this.lbl_Cpf.Text = "CPF:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Nome.Location = new System.Drawing.Point(159, 109);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(44, 14);
            this.lbl_Nome.TabIndex = 15;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Rg
            // 
            this.lbl_Rg.AutoSize = true;
            this.lbl_Rg.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Rg.Location = new System.Drawing.Point(191, 143);
            this.lbl_Rg.Name = "lbl_Rg";
            this.lbl_Rg.Size = new System.Drawing.Size(28, 14);
            this.lbl_Rg.TabIndex = 16;
            this.lbl_Rg.Text = "RG:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_Cadastrar.Location = new System.Drawing.Point(17, 244);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(94, 30);
            this.btn_Cadastrar.TabIndex = 8;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(127, 244);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(94, 30);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Crimson;
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(234, 244);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(94, 30);
            this.btn_Sair.TabIndex = 10;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Voltar.ForeColor = System.Drawing.Color.White;
            this.btn_Voltar.Location = new System.Drawing.Point(341, 244);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(94, 30);
            this.btn_Voltar.TabIndex = 11;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // frm_CadastroFisica
            // 
            this.AcceptButton = this.btn_Cadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 288);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.lbl_Rg);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Cpf);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.lbl_Cidade);
            this.Controls.Add(this.lbl_Bairro);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.txt_Rg);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.txt_Bairro);
            this.Controls.Add(this.txt_Endereco);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CadastroFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa Física";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Rg;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Rg;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Voltar;
    }
}

