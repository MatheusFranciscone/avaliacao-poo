namespace AttAvaliativa_Encapsulamento
{
    partial class frm_Entrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Entrada));
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_BoasVindas = new System.Windows.Forms.Label();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.lbl_Texto2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.White;
            this.btn_Entrar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Entrar.Location = new System.Drawing.Point(57, 122);
            this.btn_Entrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(133, 51);
            this.btn_Entrar.TabIndex = 0;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Sair.Location = new System.Drawing.Point(322, 122);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(133, 51);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_BoasVindas
            // 
            this.lbl_BoasVindas.AutoSize = true;
            this.lbl_BoasVindas.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BoasVindas.ForeColor = System.Drawing.Color.White;
            this.lbl_BoasVindas.Location = new System.Drawing.Point(186, 9);
            this.lbl_BoasVindas.Name = "lbl_BoasVindas";
            this.lbl_BoasVindas.Size = new System.Drawing.Size(143, 29);
            this.lbl_BoasVindas.TabIndex = 3;
            this.lbl_BoasVindas.Text = "Bem-vindo!";
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.ForeColor = System.Drawing.Color.White;
            this.lbl_Texto.Location = new System.Drawing.Point(53, 52);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(402, 22);
            this.lbl_Texto.TabIndex = 4;
            this.lbl_Texto.Text = "Esse sistema calcula a comissão de um funcionário,";
            // 
            // lbl_Texto2
            // 
            this.lbl_Texto2.AutoSize = true;
            this.lbl_Texto2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto2.ForeColor = System.Drawing.Color.White;
            this.lbl_Texto2.Location = new System.Drawing.Point(2, 74);
            this.lbl_Texto2.Name = "lbl_Texto2";
            this.lbl_Texto2.Size = new System.Drawing.Size(509, 22);
            this.lbl_Texto2.TabIndex = 5;
            this.lbl_Texto2.Text = "para isso será necessário digitar o valor e selecionar a categoria.";
            // 
            // frm_Entrada
            // 
            this.AcceptButton = this.btn_Entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(509, 192);
            this.Controls.Add(this.lbl_Texto2);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.lbl_BoasVindas);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Entrar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boas-Vindas!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_BoasVindas;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label lbl_Texto2;
    }
}