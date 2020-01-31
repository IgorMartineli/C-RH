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
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.Txt_Email_Cadastro);
            this.Dados.Controls.Add(this.Txt_Nome_Cadastro);
            this.Dados.Controls.Add(this.Txt_ID_Cadastro);
            this.Dados.Controls.Add(this.label5);
            this.Dados.Controls.Add(this.label4);
            this.Dados.Controls.Add(this.label3);
            this.Dados.Controls.Add(this.label1);
            this.Dados.Controls.Add(this.label2);
            this.Dados.Location = new System.Drawing.Point(12, 12);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(520, 132);
            this.Dados.TabIndex = 2;
            this.Dados.TabStop = false;
            this.Dados.Text = "groupBox1";
            // 
            // Txt_Email_Cadastro
            // 
            this.Txt_Email_Cadastro.Location = new System.Drawing.Point(50, 78);
            this.Txt_Email_Cadastro.Name = "Txt_Email_Cadastro";
            this.Txt_Email_Cadastro.Size = new System.Drawing.Size(313, 20);
            this.Txt_Email_Cadastro.TabIndex = 7;
            // 
            // Txt_Nome_Cadastro
            // 
            this.Txt_Nome_Cadastro.Location = new System.Drawing.Point(50, 42);
            this.Txt_Nome_Cadastro.Name = "Txt_Nome_Cadastro";
            this.Txt_Nome_Cadastro.Size = new System.Drawing.Size(313, 20);
            this.Txt_Nome_Cadastro.TabIndex = 6;
            // 
            // Txt_ID_Cadastro
            // 
            this.Txt_ID_Cadastro.Location = new System.Drawing.Point(50, 16);
            this.Txt_ID_Cadastro.Name = "Txt_ID_Cadastro";
            this.Txt_ID_Cadastro.Size = new System.Drawing.Size(94, 20);
            this.Txt_ID_Cadastro.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // FrmCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 262);
            this.Controls.Add(this.Dados);
            this.Name = "FrmCadastroUser";
            this.Text = "FrmCadastro";
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
    }
}