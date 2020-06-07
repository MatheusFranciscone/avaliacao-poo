namespace AttAvaliativa_Heranca
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
            this.lbl_Texto1 = new System.Windows.Forms.Label();
            this.lbl_Texto2 = new System.Windows.Forms.Label();
            this.btn_Fisica = new System.Windows.Forms.Button();
            this.btn_Juridica = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Texto1
            // 
            this.lbl_Texto1.AutoSize = true;
            this.lbl_Texto1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Texto1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto1.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Texto1.Location = new System.Drawing.Point(152, 20);
            this.lbl_Texto1.Name = "lbl_Texto1";
            this.lbl_Texto1.Size = new System.Drawing.Size(176, 25);
            this.lbl_Texto1.TabIndex = 0;
            this.lbl_Texto1.Text = "Seja bem-vindo!";
            // 
            // lbl_Texto2
            // 
            this.lbl_Texto2.AutoSize = true;
            this.lbl_Texto2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto2.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Texto2.Location = new System.Drawing.Point(58, 62);
            this.lbl_Texto2.Name = "lbl_Texto2";
            this.lbl_Texto2.Size = new System.Drawing.Size(371, 21);
            this.lbl_Texto2.TabIndex = 1;
            this.lbl_Texto2.Text = "Escolha uma opção para fazer o cadastro";
            // 
            // btn_Fisica
            // 
            this.btn_Fisica.BackColor = System.Drawing.Color.Crimson;
            this.btn_Fisica.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fisica.ForeColor = System.Drawing.Color.White;
            this.btn_Fisica.Location = new System.Drawing.Point(12, 111);
            this.btn_Fisica.Name = "btn_Fisica";
            this.btn_Fisica.Size = new System.Drawing.Size(126, 45);
            this.btn_Fisica.TabIndex = 0;
            this.btn_Fisica.Text = "Pessoa Física";
            this.btn_Fisica.UseVisualStyleBackColor = false;
            this.btn_Fisica.Click += new System.EventHandler(this.btn_Fisica_Click);
            // 
            // btn_Juridica
            // 
            this.btn_Juridica.BackColor = System.Drawing.Color.Crimson;
            this.btn_Juridica.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Juridica.ForeColor = System.Drawing.Color.White;
            this.btn_Juridica.Location = new System.Drawing.Point(338, 111);
            this.btn_Juridica.Name = "btn_Juridica";
            this.btn_Juridica.Size = new System.Drawing.Size(133, 45);
            this.btn_Juridica.TabIndex = 1;
            this.btn_Juridica.Text = "Pessoa Jurídica";
            this.btn_Juridica.UseVisualStyleBackColor = false;
            this.btn_Juridica.Click += new System.EventHandler(this.btn_Juridica_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Crimson;
            this.btn_Sair.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(177, 111);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(126, 45);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 186);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Juridica);
            this.Controls.Add(this.btn_Fisica);
            this.Controls.Add(this.lbl_Texto2);
            this.Controls.Add(this.lbl_Texto1);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boas Vindas!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Texto1;
        private System.Windows.Forms.Label lbl_Texto2;
        private System.Windows.Forms.Button btn_Fisica;
        private System.Windows.Forms.Button btn_Juridica;
        private System.Windows.Forms.Button btn_Sair;
    }
}