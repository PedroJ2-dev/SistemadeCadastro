using iTextSharp.text;
using iTextSharp.text.pdf;
using sistema_cadastro_materiais.DTO;
using sistema_cadastro_materiais.Factory;
using sistema_cadastro_materiais.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cadastro_materiais
{
    public partial class CadMaterialComprasForm: Form
    {
        int idUpdate = 0;

        bool updateBool = false;
        public CadMaterialComprasForm()
        {
            InitializeComponent();

            GetMaterials();
        }

        private void GetMaterials()
        {
            List<Material> materialsList = new List<Material>();

            string sql = @"SELECT ID, 
                                CODIGO_BARRA, 
                                CODIGO_MATERIAL,
                                COR,
                                TAMANHO 
                                FROM dbo.MATERIAL";

            using(SqlConnection conexao = ConnectionFactory.CreateConnection())
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
                                Material material = new Material();

                                if(reader.GetValue(0).ToString() != "")
                                {
                                    material.Id = reader.GetInt32(0);
                                }
                                if(reader.GetString(1) != "")
                                {
                                    material.Codigo_Barra = reader.GetValue(1).ToString().TrimEnd();
                                }
                                if(reader.GetString(2) != "")
                                {
                                    material.Codigo_Material = reader.GetValue(2).ToString().TrimEnd();
                                }
                                if(reader.GetString(3) != "")
                                {
                                    material.Cor = reader.GetValue(3).ToString().TrimEnd();
                                }
                                if(reader.GetString(4) != "")
                                {
                                    material.Tamanho = reader.GetValue(4).ToString().TrimEnd();
                                }

                                materialsList.Add(material);
                            }
                        }
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show("" + error);
                }
            }

            dgvMaterial.AutoGenerateColumns = false;
            dgvMaterial.AllowUserToOrderColumns = false;
            dgvMaterial.DataSource = materialsList;

            dgvMaterial.Columns["Id"].DisplayIndex = 0;
            dgvMaterial.Columns["Codigo_Barra"].DisplayIndex = 1;
            dgvMaterial.Columns["Codigo_Material"].DisplayIndex = 2;
            dgvMaterial.Columns["Cor"].DisplayIndex = 3;
            dgvMaterial.Columns["Tamanho"].DisplayIndex = 4;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtCodBar.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo de codigo de barra");

                return;
            }
            if (txtCodMaterial.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo de codigo de material");

                return;
            }
            if (txtCor.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo da cor");

                return;
            }
            if (txtTamanho.Text.Equals(""))
            {
                MessageBox.Show("Preencha o campo do tamanho");

                return;
            }

            if (updateBool)
            {
                Material obj = new Material();
                obj.Codigo_Barra = txtCodBar.Text.TrimEnd();
                obj.Codigo_Material = txtCodMaterial.Text.TrimEnd();
                obj.Cor = txtCor.Text.TrimEnd();
                obj.Tamanho = txtTamanho.Text.TrimEnd();

                using (SqlConnection conexao = ConnectionFactory.CreateConnection())
                {
                    string sql = @"UPDATE dbo.MATERIAL
                                SET CODIGO_BARRA = @codigo_barra
                                ,CODIGO_MATERIAL = @codigo_material
                                ,COR = @cor
                                ,TAMANHO = @tamanho
                                 WHERE ID = @id";

                    SqlCommand command = new SqlCommand(sql, conexao);
                    command.Parameters.AddWithValue("@id", idUpdate);
                    command.Parameters.AddWithValue("@codigo_barra", obj.Codigo_Barra);
                    command.Parameters.AddWithValue("@codigo_material", obj.Codigo_Material);
                    command.Parameters.AddWithValue("@cor", obj.Cor);
                    command.Parameters.AddWithValue("@tamanho", obj.Tamanho);

                    conexao.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material editado com sucesso");

                    this.CleanBoxesInForm();

                    GetMaterials();

                    updateBool = false;
                    UpdateMode(updateBool);

                    idUpdate = 0;
                }
            }
            else
            {
                Material obj = new Material();
                obj.Codigo_Barra = txtCodBar.Text.TrimEnd();
                obj.Codigo_Material = txtCodMaterial.Text.TrimEnd();
                obj.Cor = txtCor.Text.TrimEnd();
                obj.Tamanho = txtTamanho.Text.TrimEnd();

                using(SqlConnection conexao = ConnectionFactory.CreateConnection())
                {
                    string sql = @"INSERT INTO dbo.MATERIAL
                            (CODIGO_BARRA
                            ,CODIGO_MATERIAL
                            ,COR
                            ,TAMANHO)
                            VALUES                 
                            (@codigo_barra
                            ,@codigo_material
                            ,@cor
                            ,@tamanho)";

                    SqlCommand command = new SqlCommand(sql, conexao);
                    command.Parameters.AddWithValue("@codigo_barra", obj.Codigo_Barra);
                    command.Parameters.AddWithValue("@codigo_material", obj.Codigo_Material);
                    command.Parameters.AddWithValue("@cor", obj.Cor);
                    command.Parameters.AddWithValue("@tamanho", obj.Tamanho);

                    conexao.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material adicionado com sucesso");

                    this.CleanBoxesInForm();

                    GetMaterials();
                }
            }
        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterial.Columns[e.ColumnIndex].Name == "Editar")
            {
                idUpdate = Convert.ToInt32(dgvMaterial.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                txtCodBar.Text = dgvMaterial.Rows[e.RowIndex].Cells["Codigo_Barra"].Value.ToString();
                txtCodMaterial.Text = dgvMaterial.Rows[e.RowIndex].Cells["Codigo_Material"].Value.ToString();
                txtCor.Text = dgvMaterial.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
                txtTamanho.Text = dgvMaterial.Rows[e.RowIndex].Cells["Tamanho"].Value.ToString();

                updateBool = true;
                UpdateMode(updateBool);
            }
            else if (dgvMaterial.Columns[e.ColumnIndex].Name == "Excluir")
            {
                using(SqlConnection conexao = new SqlConnection())
                {
                    int idDelete = Convert.ToInt32(dgvMaterial.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                    string sql = "DELETE FROM dbo.MATERIAL WHERE ID = @id";

                    SqlCommand command = new SqlCommand(sql, conexao);
                    command.Parameters.AddWithValue("@id", idDelete);

                    conexao.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Material deletado com sucesso");

                    GetMaterials();
                }
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            //Cria o dialogo pro usuario escolher a pasta
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo PDF|*.pdf";
            saveDialog.Title = "Salvar relatório de materiais";
            saveDialog.FileName = "materiais" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ".pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoPdf = saveDialog.FileName;

                //Cria a variavel do doc e usa o Writer pra criar o documento no caminho
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(caminhoPdf, FileMode.Create));

                //Abri o documento para inserir os dados
                doc.Open();

                //Cria o cabeçalho do Pdf e adiciona no documento
                Paragraph titulo = new Paragraph("Relatório de Materiais\n\n");
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                //Cria a tabela que sera adicionada no pdf
                PdfPTable tabela = new PdfPTable(dgvMaterial.Columns.Count - 2);

                //Adiciona os cabeçalhos
                foreach(DataGridViewColumn col in dgvMaterial.Columns)
                {
                    if (col.Name == "Editar" || col.Name == "Excluir") continue;

                    tabela.AddCell(new Phrase(col.HeaderText));
                }

                foreach(DataGridViewRow row in dgvMaterial.Rows)
                {
                    if (row.IsNewRow) continue; //Ignora linha em branco

                    //adiciona o conteudo de cada celula
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        if (dgvMaterial.Columns[cell.ColumnIndex].Name == "Editar" ||
                            dgvMaterial.Columns[cell.ColumnIndex].Name == "Excluir") 
                            continue;

                        tabela.AddCell(cell.Value?.ToString() ?? "");
                    }
                }
                doc.Add(tabela);
                doc.Close();

                MessageBox.Show("Relatório baixado com sucesso");
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
