namespace RH
{
    partial class Menu
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
            this.Btn_Setor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Funcionario = new System.Windows.Forms.Button();
            this.Btn_User = new System.Windows.Forms.Button();
            this.Btn_Perfil = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Setor
            // 
            this.Btn_Setor.Location = new System.Drawing.Point(21, 178);
            this.Btn_Setor.Name = "Btn_Setor";
            this.Btn_Setor.Size = new System.Drawing.Size(85, 34);
            this.Btn_Setor.TabIndex = 3;
            this.Btn_Setor.Text = "Setor";
            this.Btn_Setor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.BackgroundImage = global::RH.Properties.Resources.os_4_principios_da_revolucao_do_rh_1571685135;
            this.groupBox1.Controls.Add(this.Btn_Funcionario);
            this.groupBox1.Controls.Add(this.Btn_User);
            this.groupBox1.Controls.Add(this.Btn_Perfil);
            this.groupBox1.Controls.Add(this.Btn_Setor);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Funcionario
            // 
            this.Btn_Funcionario.Location = new System.Drawing.Point(21, 19);
            this.Btn_Funcionario.Name = "Btn_Funcionario";
            this.Btn_Funcionario.Size = new System.Drawing.Size(85, 34);
            this.Btn_Funcionario.TabIndex = 6;
            this.Btn_Funcionario.Text = "Funcionário";
            this.Btn_Funcionario.UseVisualStyleBackColor = true;
            // 
            // Btn_User
            // 
            this.Btn_User.Location = new System.Drawing.Point(21, 72);
            this.Btn_User.Name = "Btn_User";
            this.Btn_User.Size = new System.Drawing.Size(85, 34);
            this.Btn_User.TabIndex = 5;
            this.Btn_User.Text = "Usuário";
            this.Btn_User.UseVisualStyleBackColor = true;
            this.Btn_User.Click += new System.EventHandler(this.Btn_User_Click);
            // 
            // Btn_Perfil
            // 
            this.Btn_Perfil.Location = new System.Drawing.Point(21, 124);
            this.Btn_Perfil.Name = "Btn_Perfil";
            this.Btn_Perfil.Size = new System.Drawing.Size(85, 34);
            this.Btn_Perfil.TabIndex = 4;
            this.Btn_Perfil.Text = "Perfil";
            this.Btn_Perfil.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.setorToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Cadastro";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // setorToolStripMenuItem
            // 
            this.setorToolStripMenuItem.Name = "setorToolStripMenuItem";
            this.setorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setorToolStripMenuItem.Text = "Setor";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::RH.Properties.Resources.os_4_principios_da_revolucao_do_rh_1571685135;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Setor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Funcionario;
        private System.Windows.Forms.Button Btn_User;
        private System.Windows.Forms.Button Btn_Perfil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setorToolStripMenuItem;
    }
}