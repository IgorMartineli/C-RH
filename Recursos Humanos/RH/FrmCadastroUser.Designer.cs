namespace RH
{
    partial class FrmCadastroUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dados = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar_Cadastro = new System.Windows.Forms.Button();
            this.Btn_Salvar_Cadastro = new System.Windows.Forms.Button();
            this.CMB_ID_Perfil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Status_Cadastro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Senha_Cadastro = new System.Windows.Forms.TextBox();
            this.Txt_Usuario_Cadastro = new System.Windows.Forms.TextBox();
            this.Txt_Email_Cadastro = new System.Windows.Forms.TextBox();
            this.Txt_Nome_Cadastro = new System.Windows.Forms.TextBox();
            this.Txt_ID_Cadastro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.Btn_Cancelar_Cadastro);
            this.Dados.Controls.Add(this.Btn_Salvar_Cadastro);
            this.Dados.Controls.Add(this.CMB_ID_Perfil);
            this.Dados.Controls.Add(this.label7);
            this.Dados.Controls.Add(this.Txt_Status_Cadastro);
            this.Dados.Controls.Add(this.label6);
            this.Dados.Controls.Add(this.Txt_Senha_Cadastro);
            this.Dados.Controls.Add(this.Txt_Usuario_Cadastro);
            this.Dados.Controls.Add(this.Txt_Email_Cadastro);
            this.Dados.Controls.Add(this.Txt_Nome_Cadastro);
            this.Dados.Controls.Add(this.Txt_ID_Cadastro);
            this.Dados.Controls.Add(this.label5);
            this.Dados.Controls.Add(this.label4);
            this.Dados.Controls.Add(this.label3);
            this.Dados.Controls.Add(this.label1);
            this.Dados.Controls.Add(this.label2);
            this.Dados.Location = new System.Drawing.Point(12, 6);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(385, 226);
            this.Dados.TabIndex = 2;
            this.Dados.TabStop = false;
            this.Dados.Text = "Cadastro de Usuário";
            // 
            // Btn_Cancelar_Cadastro
            // 
            this.Btn_Cancelar_Cadastro.Location = new System.Drawing.Point(197, 188);
            this.Btn_Cancelar_Cadastro.Name = "Btn_Cancelar_Cadastro";
            this.Btn_Cancelar_Cadastro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar_Cadastro.TabIndex = 15;
            this.Btn_Cancelar_Cadastro.Text = "Cancelar";
            this.Btn_Cancelar_Cadastro.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar_Cadastro
            // 
            this.Btn_Salvar_Cadastro.Location = new System.Drawing.Point(102, 188);
            this.Btn_Salvar_Cadastro.Name = "Btn_Salvar_Cadastro";
            this.Btn_Salvar_Cadastro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar_Cadastro.TabIndex = 14;
            this.Btn_Salvar_Cadastro.Text = "Salvar";
            this.Btn_Salvar_Cadastro.UseVisualStyleBackColor = true;
            this.Btn_Salvar_Cadastro.Click += new System.EventHandler(this.Btn_Salvar_Cadastro_Click);
            // 
            // CMB_ID_Perfil
            // 
            this.CMB_ID_Perfil.FormattingEnabled = true;
            this.CMB_ID_Perfil.Location = new System.Drawing.Point(56, 111);
            this.CMB_ID_Perfil.Name = "CMB_ID_Perfil";
            this.CMB_ID_Perfil.Size = new System.Drawing.Size(179, 21);
            this.CMB_ID_Perfil.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID Perfil:";
            // 
            // Txt_Status_Cadastro
            // 
            this.Txt_Status_Cadastro.Location = new System.Drawing.Point(287, 113);
            this.Txt_Status_Cadastro.Name = "Txt_Status_Cadastro";
            this.Txt_Status_Cadastro.Size = new System.Drawing.Size(81, 20);
            this.Txt_Status_Cadastro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            // 
            // Txt_Senha_Cadastro
            // 
            this.Txt_Senha_Cadastro.Location = new System.Drawing.Point(244, 143);
            this.Txt_Senha_Cadastro.Name = "Txt_Senha_Cadastro";
            this.Txt_Senha_Cadastro.Size = new System.Drawing.Size(124, 20);
            this.Txt_Senha_Cadastro.TabIndex = 9;
            // 
            // Txt_Usuario_Cadastro
            // 
            this.Txt_Usuario_Cadastro.Location = new System.Drawing.Point(58, 143);
            this.Txt_Usuario_Cadastro.Name = "Txt_Usuario_Cadastro";
            this.Txt_Usuario_Cadastro.Size = new System.Drawing.Size(121, 20);
            this.Txt_Usuario_Cadastro.TabIndex = 8;
            // 
            // Txt_Email_Cadastro
            // 
            this.Txt_Email_Cadastro.Location = new System.Drawing.Point(56, 81);
            this.Txt_Email_Cadastro.Name = "Txt_Email_Cadastro";
            this.Txt_Email_Cadastro.Size = new System.Drawing.Size(313, 20);
            this.Txt_Email_Cadastro.TabIndex = 7;
            // 
            // Txt_Nome_Cadastro
            // 
            this.Txt_Nome_Cadastro.Location = new System.Drawing.Point(55, 52);
            this.Txt_Nome_Cadastro.Name = "Txt_Nome_Cadastro";
            this.Txt_Nome_Cadastro.Size = new System.Drawing.Size(313, 20);
            this.Txt_Nome_Cadastro.TabIndex = 6;
            // 
            // Txt_ID_Cadastro
            // 
            this.Txt_ID_Cadastro.Location = new System.Drawing.Point(56, 19);
            this.Txt_ID_Cadastro.Name = "Txt_ID_Cadastro";
            this.Txt_ID_Cadastro.Size = new System.Drawing.Size(94, 20);
            this.Txt_ID_Cadastro.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // FrmCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.Controls.Add(this.Dados);
            this.Name = "FrmCadastroUser";
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastroUser_Load);
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Dados;
        private System.Windows.Forms.TextBox Txt_Email_Cadastro;
        private System.Windows.Forms.TextBox Txt_Nome_Cadastro;
        private System.Windows.Forms.TextBox Txt_ID_Cadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Cancelar_Cadastro;
        private System.Windows.Forms.Button Btn_Salvar_Cadastro;
        private System.Windows.Forms.ComboBox CMB_ID_Perfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Status_Cadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Senha_Cadastro;
        private System.Windows.Forms.TextBox Txt_Usuario_Cadastro;
    }
}