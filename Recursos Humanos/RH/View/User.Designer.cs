namespace RH
{
    partial class User
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Procurar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_ID_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_Nome_Usuario = new System.Windows.Forms.TextBox();
            this.DTGW_Usuario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGW_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Nome_Usuario);
            this.groupBox1.Controls.Add(this.Txt_ID_Usuario);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Btn_Procurar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // Btn_Procurar
            // 
            this.Btn_Procurar.Location = new System.Drawing.Point(184, 20);
            this.Btn_Procurar.Name = "Btn_Procurar";
            this.Btn_Procurar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Procurar.TabIndex = 2;
            this.Btn_Procurar.Text = "Procurar";
            this.Btn_Procurar.UseVisualStyleBackColor = true;
            this.Btn_Procurar.Click += new System.EventHandler(this.Btn_Procurar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Txt_ID_Usuario
            // 
            this.Txt_ID_Usuario.Location = new System.Drawing.Point(44, 23);
            this.Txt_ID_Usuario.Name = "Txt_ID_Usuario";
            this.Txt_ID_Usuario.Size = new System.Drawing.Size(116, 20);
            this.Txt_ID_Usuario.TabIndex = 4;
            // 
            // Txt_Nome_Usuario
            // 
            this.Txt_Nome_Usuario.Location = new System.Drawing.Point(44, 58);
            this.Txt_Nome_Usuario.Name = "Txt_Nome_Usuario";
            this.Txt_Nome_Usuario.Size = new System.Drawing.Size(329, 20);
            this.Txt_Nome_Usuario.TabIndex = 5;
            // 
            // DTGW_Usuario
            // 
            this.DTGW_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGW_Usuario.Location = new System.Drawing.Point(12, 115);
            this.DTGW_Usuario.Name = "DTGW_Usuario";
            this.DTGW_Usuario.Size = new System.Drawing.Size(388, 155);
            this.DTGW_Usuario.TabIndex = 1;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 282);
            this.Controls.Add(this.DTGW_Usuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGW_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Nome_Usuario;
        private System.Windows.Forms.TextBox Txt_ID_Usuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Procurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTGW_Usuario;
    }
}