using System;
using System.Data.OleDb;
using System.IO;
using ADOX;

namespace Pessoa
{
    public class PessoaDAL
    {
        private static string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PessoaDB.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";

        public static int createPessoa(Pessoa pessoa)
        {
            Erro.setErro(false);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Pessoas (Nome, Telefone, Email, CEP, Estado, Cidade, Bairro, Rua, NumeroRua, Complemento) " +
                               "VALUES (@Nome, @Telefone, @Email, @CEP, @Estado, @Cidade, @Bairro, @Rua, @NumeroRua, @Complemento)";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome",     pessoa.Nome);
                    command.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                    command.Parameters.AddWithValue("@Email",    pessoa.Email);
                    command.Parameters.AddWithValue("@CEP",    pessoa.CEP);
                    command.Parameters.AddWithValue("@Estado", pessoa.Estado);
                    command.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
                    command.Parameters.AddWithValue("@Bairro", pessoa.Bairro);
                    command.Parameters.AddWithValue("@Rua",    pessoa.Rua);
                    command.Parameters.AddWithValue("@NumeroRua",   pessoa.NumeroRua);
                    command.Parameters.AddWithValue("@Complemento", pessoa.Complemento);

                    command.ExecuteNonQuery();
                }

                string idQuery = "SELECT @@IDENTITY AS LastID";

                using (OleDbCommand idCommand = new OleDbCommand(idQuery, connection))
                {
                    int id = (int)idCommand.ExecuteScalar();
                    return id;
                }
            }
        }

        public static Pessoa readPessoa(string id)
        {
            Erro.setErro(false);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Pessoas WHERE Id = @Id";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Pessoa pessoa = new Pessoa
                            {
                                Id   = reader["Id"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                Telefone = reader["Telefone"].ToString(),
                                Email  = reader["Email"].ToString(),
                                CEP    = reader["CEP"].ToString(),
                                Estado = reader["Estado"].ToString(),
                                Cidade = reader["Cidade"].ToString(),
                                Bairro = reader["Bairro"].ToString(),
                                Rua    = reader["Rua"].ToString(),
                                NumeroRua   = reader["NumeroRua"].ToString(),
                                Complemento = reader["Complemento"].ToString()
                            };

                            return pessoa;
                        }
                        else
                        {
                            Erro.setErro("Não foi possível encontrar pessoa.");
                            return null;
                        }
                    }
                }
            }
        }

        public static void updatePessoa(Pessoa pessoa)
        {
            Erro.setErro(false);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Pessoas SET Nome = @Nome, Telefone = @Telefone, Email = @Email, CEP = @CEP, Estado = @Estado, " +
                               "Cidade = @Cidade, Bairro = @Bairro, Rua = @Rua, NumeroRua = @NumeroRua, Complemento = @Complemento " +
                               "WHERE Id = @Id";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome",     pessoa.Nome);
                    command.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                    command.Parameters.AddWithValue("@Email",    pessoa.Email);
                    command.Parameters.AddWithValue("@CEP",      pessoa.CEP);
                    command.Parameters.AddWithValue("@Estado",   pessoa.Estado);
                    command.Parameters.AddWithValue("@Cidade",   pessoa.Cidade);
                    command.Parameters.AddWithValue("@Bairro",   pessoa.Bairro);
                    command.Parameters.AddWithValue("@Rua",         pessoa.Rua);
                    command.Parameters.AddWithValue("@NumeroRua",   pessoa.NumeroRua);
                    command.Parameters.AddWithValue("@Complemento", pessoa.Complemento);
                    command.Parameters.AddWithValue("@Id",          pessoa.Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        Erro.setErro("Não foi possível encontrar pessoa.");
                        return;
                    }
                }
            }
        }

        public static void removePessoa(string id)
        {
            Erro.setErro(false);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Pessoas WHERE Id = @Id";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        Erro.setErro("Não foi possível encontrar pessoa.");
                        return;
                    }
                }
            }
        }
    }
}
