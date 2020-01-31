using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RH
{
    public partial class FrmLogin : Form
    {
        Usuario objusuario;
        Conexao con;

        public FrmLogin()
        {
            InitializeComponent();
            con = new Conexao();
        }
        private void lerdados()
        {
            objusuario = new Usuario();
            objusuario.usuario = Txt_Login.Text.Trim();
            objusuario.senha = Txt_Senha.Text.Trim();                       

            
            String CrypSenha = CrypHash.ComputeSha256Hash(objusuario.senha);
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {



        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja cancelar:?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Txt_Login.Text = " ";
            Txt_Senha.Text = " ";

        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            lerdados();
            String CrypSenha = CrypHash.ComputeSha256Hash(objusuario.senha);
            con.OpenConnection();
            String Mysql = $"SELECT * FROM tb_usuario WHERE usuario='{objusuario.usuario}' AND senha='{CrypSenha}'";
            MySqlDataReader reader;
            reader = con.executeQuery(Mysql);

            if (reader.HasRows)

            {
                MessageBox.Show("login com sucesso!");
                Menu menu = new Menu();
                menu.Show();

            }
            else
            {
                MessageBox.Show("não logou!");
            }
        }

        
    }

     
        
    }

