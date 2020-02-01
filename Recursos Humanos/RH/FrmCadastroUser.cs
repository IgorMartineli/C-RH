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
    public partial class FrmCadastroUser : Form
    {
        Usuario objCadasUser;
        Conexao con;


        public FrmCadastroUser()
        {
            InitializeComponent();
            con = new Conexao();
        }

        private void lerdados()
        {
            objCadasUser = new Usuario();
            objCadasUser.id = int.Parse(Txt_ID_Cadastro.Text.Trim());
            objCadasUser.nome = Txt_Nome_Cadastro.Text;
            objCadasUser.email = Txt_Email_Cadastro.Text;
            objCadasUser.usuario = Txt_Usuario_Cadastro.Text.Trim();
            objCadasUser.senha = Txt_Senha_Cadastro.Text.Trim();
            // objCadasUser.status = Boolean.Parse;
            objCadasUser.id_perfil = int.Parse(CMB_ID_Perfil.SelectedValue.ToString());
        }

        private void Btn_Salvar_Cadastro_Click(object sender, EventArgs e)
        {
            lerdados();
            String Mysql = $" insert into tb_usuario values ='{objCadasUser.id}' , '{objCadasUser.nome}','{objCadasUser.email}','{objCadasUser.senha}','{objCadasUser.usuario}','{objCadasUser.status}','{objCadasUser.id_perfil}'";
            MySqlDataReader reader;
            reader = con.executeQuery(Mysql);
            if (con.executeQuery(Mysql)==null)
            {
                MessageBox.Show("Dados Salvos com Sucesso!");
            }
            else
            {
                MessageBox.Show("Dados Não Salvos");
            }
        
        }
        private void carregarbox()
        {
            List<Perfil> listperfil = new List<Perfil>();
            con.OpenConnection();
            MySqlDataReader reader;
            String Mysql = $"SELECT * FROM tb_perfil";
            reader = con.executeQuery(Mysql);
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    Perfil perfill = new Perfil();
                    perfill.id_perfil = reader.GetInt32(0);
                    perfill.nome = reader.GetString(1);
                    listperfil.Add(perfill);
                }

            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            reader.Close();
            CMB_ID_Perfil.DataSource = listperfil;
            CMB_ID_Perfil.DisplayMember = "nome";
            CMB_ID_Perfil.ValueMember = "id";

        }

        private void FrmCadastroUser_Load(object sender, EventArgs e)
        {
            carregarbox();
        }
    }
}
