
using System.Data.SQLite;


namespace Estudante
{
    public class InicializadorBD
    {

        private const string ConnectionString = "Data Source=Escola.db";
        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {


                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Pessoas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Altura INTERGER NOT NULL,
                 Peso REAL NOT NULL,
                 Idade INTERGER NOT NULL,
                 Nome STRING NOT NULL
                );";
            }

        }
    }

}
