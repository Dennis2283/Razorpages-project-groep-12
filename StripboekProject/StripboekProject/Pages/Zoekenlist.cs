using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace StripboekProject.Pages;

public class Zoekenlist
{
    private IDbConnection Connect()
    {
        return new MySqlConnection(
            @"Server=127.0.0.1;Port=3306;
            Database=StripboekenWebApp;
            Uid=dennis;Pwd=password;"
        );
    }
    
    public List<Stripboek> Get()
    {
        using var connection = Connect();
        var stripboeken = connection.Query<Stripboek>("SELECT * FROM StripboekenWebApp.Stripboek limit 1");
        return stripboeken.ToList();
    }
}