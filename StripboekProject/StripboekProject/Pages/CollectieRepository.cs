using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace StripboekProject.Pages;

public class CollectieRepository
{
    private IDbConnection Connect()
    {
        return new MySqlConnection(
            "Server=127.0.0.1;Port=3306;" +
            "Database=StripboekenWebApp;" +
            "Uid=dennis;Pwd=password;"
        );
    }
/* Connection aanroepen en met dapper Query uitvoeren
    Hij pakt het stripboek wat het meest overeenkomt met de titel van wat je invoert*/
    public List<Stripboek> Search(string search)
    {
        using var connection = Connect();
        var  collectie= connection.Query<Stripboek>("SELECT * FROM Collectie_naam WHERE Collectie_naam LIKE @search", new
        {
            search = "%" + search + "%"
        });
        return collectie.ToList();
        
            
        
    }
}