using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace StripboekProject.Pages;

public class JoinRepository
{

    private IDbConnection Connect()
    {
        return new MySqlConnection(
            "Server=127.0.0.1;Port=3306;Database=StripboekenwebApp;Uid=root;Pwd=;"
        );
    }


    public List<Tekenaar> Search3(string search3)
    {
        using var connection = Connect();
        var tekenaars = connection.Query<Tekenaar>("select *from Tekenaar join Stripboek S on S.Titel = Tekenaar.Strip_Id join Auteur A on A.Auteur_naam = A.Strip_Id LIKE @search3", new
        {
            search3 = "%" + search3 + "%"
        });
        return tekenaars.ToList();
    }
}

