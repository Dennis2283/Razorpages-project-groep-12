using System.Data;
using MySql.Data.MySqlClient;

namespace StripboekProject;

public class DbConnection
{
    private IDbConnection Connect()
    {
        return new MySqlConnection(
            "Server=127.0.0.1,;Port = 3306;" +
            "Database=StripboekenWebApp;" +
            "Uid=Admin;Pwd=Test@1;"
        );
    }
}