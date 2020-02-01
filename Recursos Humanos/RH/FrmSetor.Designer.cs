namespace RH
{
    partial class FrmSetorCadastro
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
            this.Txt_ID_Setor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nome_Setor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMB_Cadastro_Setor = new System.Windows.Forms.ComboBox();
            this.Btn_Cadastro_Setor = new System.Windows.Forms.Button();
            this.Btn_Cadastro_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Setor:";
            // 
            // Txt_ID_Setor
            // 
            this.Txt_ID_Setor.Location = new System.Drawing.Point(61, 34);
            this.Txt_ID_Setor.Name = "Txt_ID_Setor";
            this.Txt_ID_Setor.Size = new System.Drawing.Size(64, 20);
            this.Txt_ID_Setor.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Cadastro_Cancelar);
            this.groupBox1.Controls.Add(this.Btn_Cadastro_Setor);
            this.groupBox1.Controls.Add(this.CMB_Cadastro_Setor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Nome_Setor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_ID_Setor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Setor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // Txt_Nome_Setor
            // 
            this.Txt_Nome_Setor.Location = new System.Drawing.Point(50, 68);
            this.Txt_Nome_Setor.Name = "Txt_Nome_Setor";
            this.Txt_Nome_Setor.Size = new System.Drawing.Size(357, 20);
            this.Txt_Nome_Setor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Setor:";
            // 
            // CMB_Cadastro_Setor
            // 
            this.CMB_Cadastro_Setor.FormattingEnabled = true;
            this.CMB_Cadastro_Setor.Location = new System.Drawing.Point(172, 33);
            this.CMB_Cadastro_Setor.Name = "CMB_Cadastro_Setor";
            this.CMB_Cadastro_Setor.Size = new System.Drawing.Size(235, 21);
            this.CMB_Cadastro_Setor.TabIndex = 5;
            this.CMB_Cadastro_Setor.SelectedIndexChanged += new System.EventHandler(this.CMB_Cadastro_Setor_SelectedIndexChanged);
            // 
            // Btn_Cadastro_Setor
            // 
            this.Btn_Cadastro_Setor.Location = new System.Drawing.Point(235, 106);
            this.Btn_Cadastro_Setor.Name = "Btn_Cadastro_Setor";
            this.Btn_Cadastro_Setor.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastro_Setor.TabIndex = 6;
            this.Btn_Cadastro_Setor.Text = "Salvar";
            this.Btn_Cadastro_Setor.UseVisualStyleBackColor = true;
            this.Btn_Cadastro_Setor.Click += new System.EventHandler(this.Btn_Cadastro_Setor_Click);
            // 
            // Btn_Cadastro_Cancelar
            // 
            this.Btn_Cadastro_Cancelar.Location = new System.Drawing.Point(332, 106);
            this.Btn_Cadastro_Cancelar.Name = "Btn_Cadastro_Cancelar";
            this.Btn_Cadastro_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastro_Cancelar.TabIndex = 7;
            this.Btn_Cadastro_Cancelar.Text = "Cancelar";
            this.Btn_Cadastro_Cancelar.UseVisualStyleBackColor = true;
            // 
            // FrmSetorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 169);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSetorCadastro";
            this.Text = "FrmSetor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ID_Setor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Cadastro_Cancelar;
        private System.Windows.Forms.Button Btn_Cadastro_Setor;
        private System.Windows.Forms.ComboBox CMB_Cadastro_Setor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nome_Setor;
        private System.Windows.Forms.Label label2;
    }
}