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
    public partial class User : Form
    {
        Conexao con;
        Usuario objuser;
     
        public User()
        {
            InitializeComponent();
            con = new Conexao();
            objuser = new Usuario();
       
                }

        // lista do banco de dados para aparecer no GRID VIEW
        private void Btn_Procurar_Click(object sender, EventArgs e)
        {
            List<Usuario> listusuario = new List<Usuario>();
            con.OpenConnection();
      
            MySqlDataReader reader;
            String Mysql = $"SELECT * FROM tb_usuario WHERE id='{objuser.id}' AND nome='{objuser.nome}'";
            reader = con.executeQuery(Mysql);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario objuser2 = new Usuario();
                    objuser2.id = reader.GetInt32(0);
                    objuser2.nome = reader.GetString(1);
                    listusuario.Add(objuser2);
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados!");
            }
        }

             // lista do banco de dados para aparecer no GRID VIEW
        public void atualizargrid()
        {
            List<Usuario> listusuario = new List<Usuario>();
            con.OpenConnection();
         MySqlDataReader reader;
            String Mysql = $"SELECT * FROM tb_usuario";
            reader = con.executeQuery(Mysql);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario objuser2 = new Usuario();
                    objuser2.id = reader.GetInt32(0);
                    objuser2.nome = reader.GetString(1);
                    objuser2.email = reader.GetString(2);
                    objuser2.usuario = reader.GetString(4);
                    objuser2.status = reader.GetBoolean(5);
                    objuser2.id_perfil = reader.GetInt32(6);
                    listusuario.Add(objuser2);
                }
                reader.Close();
            }
            //DTGW caso não abra
            else
            {
                Console.WriteLine("Inválido");
            }
            DTGW_Usuario.DataSource = null;
            DTGW_Usuario.DataSource = listusuario;
       


        }

        private void User_Load(object sender, EventArgs e)
        {
            atualizargrid();
        }
    }
}
