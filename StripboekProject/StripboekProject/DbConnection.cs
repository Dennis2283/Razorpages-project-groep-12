using System.Data;
using MySql.Data.MySqlClient;

namespace StripboekProject;

public class DbConnection
{
    private IDbConnection Connect() /* Misschien overbodige connection string */ 
    {
        return new MySqlConnection(
            "Server=127.0.0.1,;Port = 3306;" +
            "Database=StripboekenWebApp;" +
            "Uid=dennis;Pwd=password;"
        );
    }
}