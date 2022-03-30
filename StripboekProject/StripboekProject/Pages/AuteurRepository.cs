using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace StripboekProject.Pages;

public class AuteurRepository
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
    public List<Auteur> Search2(string search2)
    {
        using var connection = Connect();
        var  auteurs= connection.Query<Auteur>("SELECT * FROM StripboekenWebApp.Auteur WHERE Auteur_naam LIKE @search2", new
        {
            search2 = "%" + search2 + "%"
        });
        return auteurs.ToList();
        
            
        
    }
}