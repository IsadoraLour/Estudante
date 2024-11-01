using Dapper;
using System.Data.SQLite;


namespace Estudante
{
    public class InicializadorBD
    {

       
        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=Escola.db");
            


                
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Pessoas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Altura INTERGER NOT NULL,
                 Peso REAL NOT NULL,
                 Idade INTERGER NOT NULL,
                 Nome STRING NOT NULL
                );";

            connection.Execute(commandoSQL);
        }

        
    }
}


