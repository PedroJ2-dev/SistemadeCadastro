using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cadastro_materiais.Factory
{
    public static class ConnectionFactory
    {

        private static string caminhoTxt = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\config.txt";

        public static SqlConnection CreateConnection()
        {
            if (!File.Exists(caminhoTxt))
            {
                MessageBox.Show("O arquivo txt com o servidor sql não foi encontrado");
                return null;
            }

            var linhas = File.ReadAllLines(caminhoTxt);
            var builder = new SqlConnectionStringBuilder();

            foreach(var linha in linhas)
            {
                if (!linha.Contains("="))
                    continue;

                var partes = linha.Split('=');
                var chave = partes[0].Trim();
                var valor = partes[1].Trim();

                switch (chave.ToLower())
                {
                    case "data source":
                        builder.DataSource = valor;
                        break;
                    case "userid":
                        builder.UserID = valor;
                        break;
                    case "password":
                        builder.Password = valor;
                        break;
                    case "initial catalog":
                        builder.InitialCatalog = valor;
                        break;
                    case "integrated_security":
                        builder.IntegratedSecurity =
                        valor.Equals("true", StringComparison.OrdinalIgnoreCase) ||
                        valor.Equals("sspi", StringComparison.OrdinalIgnoreCase);
                        break;
                    case "trusted_connection":
                        builder["Trusted_Connection"] = valor;
                        break;
                }

            }
            return new SqlConnection(builder.ConnectionString);

        }
    }
}
