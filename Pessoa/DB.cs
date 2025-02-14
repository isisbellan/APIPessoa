using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOX;

namespace Pessoa
{
    internal class DB
    {
        private static string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PessoaDB.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";

        public static void construirBanco()
        {
            if (!File.Exists(databasePath))
            {
                criarArquivoBanco();
            }

            criarTabela();
        }

        private static void criarArquivoBanco()
        {
            Erro.setErro(false);
            ADOX.Catalog catalog = new ADOX.Catalog();

            try
            {
                catalog.Create($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};Jet OLEDB:Engine Type=5");
            }
            catch (Exception)
            {
                Erro.setErro("Erro ao criar o banco de dados.");
                return;
            }
        }

        private static void criarTabela()
        {
            if (tabelaExiste("Pessoas")) { return; }
            
            string query = @"
                CREATE TABLE Pessoas (
                    Id AUTOINCREMENT PRIMARY KEY,
                    Nome TEXT NOT NULL,
                    Telefone TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    CEP TEXT NOT NULL,
                    Estado TEXT NOT NULL,
                    Cidade TEXT NOT NULL,
                    Bairro TEXT NOT NULL,
                    Rua TEXT NOT NULL,
                    NumeroRua TEXT NOT NULL,
                    Complemento TEXT
                )";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            
        }

        private static bool tabelaExiste(string nomeTabela)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                DataTable schemas = connection.GetSchema("Tables");

                foreach (DataRow row in schemas.Rows)
                {
                    if (row["TABLE_NAME"].ToString().Equals(nomeTabela, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
