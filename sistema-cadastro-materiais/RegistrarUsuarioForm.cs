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

using sistema_cadastro_materiais.DTO;
using sistema_cadastro_materiais.Library;

namespace sistema_cadastro_materiais
{
    public partial class RegistrarUsuarioForm: Form
    {
        public int idUpdate;

        public bool existUsuarioBool;
        public bool updateBool = false;
        public RegistrarUsuarioForm()
        {
            InitializeComponent();

            GetUsuarios();
        }

        private void UpdateMode(bool update)
        {
            if (update)
            {
                txtModoEditando.Enabled = true;
                txtModoEditando.Visible = true;
                btnSairModoEditando.Enabled = true;
                btnSairModoEditando.Visible = true;
            }
            else
            {
                txtModoEditando.Enabled = false;
                txtModoEditando.Visible = false;
                btnSairModoEditando.Enabled = false;
                btnSairModoEditando.Visible = false;
            }
        }
        private void GetUsuarios()
        {
            List<Usuario> listUsuarios = new List<Usuario>();

            string sql = "SELECT NOME, [LOGIN], SENHA, PERFIL, ID FROM dbo.USUARIO";
        
            using (var conexao = ConnectionFactory.CreateConnection())
            {
                conexao.Open();
                try
                {
                    using(SqlCommand command = new SqlCommand(sql, conexao))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();

                                if (reader.GetValue(0).ToString() != "")
                                {
                                    usuario.Nome = reader.GetValue(0).ToString();
                                }
                                
                                if(reader.GetValue(1).ToString() != "")
                                {
                                    usuario.Login = reader.GetValue(1).ToString();
                                }

                                if (reader.GetValue(2).ToString() != "")
                                {
                                    usuario.Senha = PasswordCript.DesCriptografar(reader.GetValue(2).ToString(), "14441");
                                }

                                if (reader.GetValue(3).ToString() != "")
                                {
                                    usuario.Perfil = reader.GetValue(3).ToString();
                                }

                                if (reader.GetValue(4).ToString() != "")
                                {
                                    usuario.Id = reader.GetInt32(4);
                                }

                                listUsuarios.Add(usuario);
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("aconteceu o error:" + error);
                }
            }

            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.AllowUserToOrderColumns = false;
            dgvUsuario.DataSource = listUsuarios;

            dgvUsuario.Columns["Id"].DisplayIndex = 0;
            dgvUsuario.Columns["Nome"].DisplayIndex = 1;
            dgvUsuario.Columns["Login"].DisplayIndex = 2;
            dgvUsuario.Columns["Senha"].DisplayIndex = 3;
            dgvUsuario.Columns["Perfil"].DisplayIndex = 4;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo de usuário");

                return;
            }
            
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo do nome");

                return;
            }
            
            if (txtSenha.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo da senha");
                
                return;
            }
            
            if (cmbPerfil.SelectedItem == null)
            {
                MessageBox.Show("Selecione algum perfil");

                return;
            }

            //Verificar se existe no banco
            

            using (var conexao = ConnectionFactory.CreateConnection())
            {
                string sql = "SELECT * FROM dbo.USUARIO WHERE LOGIN = '" + txtUsuario.Text + "';";

                conexao.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(sql, conexao))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                existUsuarioBool = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("aconteceu o error:" + error);
                }
            }

            //Se existir informo usuario já cadastrado
            if (existUsuarioBool && !updateBool)
            {
                MessageBox.Show("Este usuário já esta cadastrado");
            }
            //Se não existir crio um objeto usuario e insiro
            else
            {
                if (updateBool)
                {
                    string senhaConvert = PasswordCript.Criptografar(txtSenha.Text, "14441");

                    Usuario obj = new Usuario();
                    obj.Login = txtUsuario.Text.TrimEnd();
                    obj.Perfil = cmbPerfil.Text.TrimEnd();
                    obj.Nome = txtNome.Text.TrimEnd();
                    obj.Senha = senhaConvert;

                    using (var conexao = ConnectionFactory.CreateConnection())
                    {
                        string sql = @"UPDATE [dbo].[USUARIO]
                            SET [LOGIN] = @login
                               ,[PERFIL] = @perfil
                               ,[NOME] = @nome
                               ,[SENHA] = @senha
                                WHERE ID = @id";

                        SqlCommand command = new SqlCommand(sql, conexao);
                        command.Parameters.AddWithValue("@login", obj.Login);
                        command.Parameters.AddWithValue("@perfil", obj.Perfil);
                        command.Parameters.AddWithValue("@nome", obj.Nome);
                        command.Parameters.AddWithValue("@senha", obj.Senha);
                        command.Parameters.AddWithValue("@id", idUpdate);

                        conexao.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Usuario editado com sucesso");

                        GetUsuarios();

                        this.CleanBoxesInForm();

                        updateBool = false;
                        
                        UpdateMode(updateBool);

                        idUpdate = 0;
                    }
                }
                else
                {
                    string senhaConvert = PasswordCript.Criptografar(txtSenha.Text, "14441");

                    Usuario obj = new Usuario();
                    obj.Login = txtUsuario.Text.TrimEnd();
                    obj.Perfil = cmbPerfil.Text.TrimEnd();
                    obj.Nome = txtNome.Text.TrimEnd();
                    obj.Senha = senhaConvert;
                    using (var conexao = ConnectionFactory.CreateConnection())
                    {
                        string sql = @"INSERT INTO dbo.USUARIO
                                    (
                                      [LOGIN]
                                    , [PERFIL]
                                    , [NOME]
                                    , [SENHA]
                                    , [SENHA_PROVISORIA]
                                    , [IN_SOLICITACAO_SENHA])
                                    VALUES(
                                      @login
                                    , @perfil
                                    , @nome
                                    , @senha
                                    , null
                                    , null
                                     );";

                        SqlCommand command = new SqlCommand(sql, conexao);
                        command.Parameters.AddWithValue("@login", obj.Login);
                        command.Parameters.AddWithValue("@perfil", obj.Perfil);
                        command.Parameters.AddWithValue("@nome", obj.Nome);
                        command.Parameters.AddWithValue("@senha", obj.Senha);

                        conexao.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Novo usuário cadastrado");

                        GetUsuarios();

                        this.CleanBoxesInForm();
                    }
                }
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.Columns[e.ColumnIndex].Name == "Editar")
            {
                idUpdate = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                txtUsuario.Text = dgvUsuario.Rows[e.RowIndex].Cells["Login"].Value.ToString().TrimEnd();
                txtNome.Text = dgvUsuario.Rows[e.RowIndex].Cells["Nome"].Value.ToString().TrimEnd();
                cmbPerfil.SelectedItem = dgvUsuario.Rows[e.RowIndex].Cells["Perfil"].Value.ToString().TrimEnd();
                txtSenha.Text = dgvUsuario.Rows[e.RowIndex].Cells["Senha"].Value.ToString().TrimEnd();

                updateBool = true;
                UpdateMode(updateBool);
            }
            else if (dgvUsuario.Columns[e.ColumnIndex].Name == "Excluir")
            {
                using (var conexao = ConnectionFactory.CreateConnection())
                {
                    int idDelete = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    
                    string sql = "DELETE FROM [dbo].[USUARIO] WHERE id = @id";

                    SqlCommand command = new SqlCommand(sql, conexao);
                    command.Parameters.AddWithValue("@id", idDelete);

                    conexao.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Usuario deletado com sucesso");

                    GetUsuarios();
                }
            }
        }

        private void btnSairModoEditando_Click(object sender, EventArgs e)
        {
            updateBool = false;
            UpdateMode(updateBool);

            this.CleanBoxesInForm();
        }
    }
}
