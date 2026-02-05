using MaterialSkin.Controls;
using sistema_cadastro_materiais.DTO;
using sistema_cadastro_materiais.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using sistema_cadastro_materiais.Library;

namespace sistema_cadastro_materiais
{
    public partial class LoginForm: MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Fazer verificações para abrir menu

            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha o usuário");

                return;
            }
            else if (txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha a senha");

                return;
            }
            
            
            bool usuarioCorretobool = false;

            string senhaConvert = PasswordCript.Criptografar(txtSenha.Text, "14441");

            string sql = @"SELECT * FROM dbo.USUARIO 
                         WHERE [LOGIN] = '" + txtUsuario.Text + "' " +
                          "AND SENHA = '" + senhaConvert + "'";

            using (var conexao = ConnectionFactory.CreateConnection())
            {
                conexao.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(sql, conexao))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuarioCorretobool = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("aconteceu o error:" + error);
                }
            }

            if (usuarioCorretobool)
            {
                ConferenciaPainelForm menu = new ConferenciaPainelForm();

                this.Hide();

                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
