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
            Database=StripboekenwebApp;
            Uid=root;Pwd=;"
        );
    }
    
    public List<Stripboek> Get()
    {
        using var connection = Connect();
        var stripboeken = connection.Query<Stripboek>("SELECT * FROM Stripboek where StripId = 1");
        return stripboeken.ToList();
    }

    public List<Auteur> Get1()
    {
        using var connection = Connect();
        var auteurs = connection.Query<Auteur>("Select * from Auteur where Strip_Id = 1");
        return auteurs.ToList();
    }
    
    public List<Stripboek> Get2()
    {
        using var connection = Connect();
        var stripboeken = connection.Query<Stripboek>("SELECT * FROM Stripboek where StripId = 2");
        return stripboeken.ToList();
    }
    public List<Auteur> Get3()
    {
        using var connection = Connect();
        var auteurs = connection.Query<Auteur>("Select * from Auteur where Strip_Id = 2");
        return auteurs.ToList();
    }
    
    public List<Stripboek> Get4()
    {
        using var connection = Connect();
        var stripboeken = connection.Query<Stripboek>("SELECT * FROM Stripboek where StripId = 3");
        return stripboeken.ToList();
    }
    
    public List<Auteur> Get5()
    {
        using var connection = Connect();
        var auteurs = connection.Query<Auteur>("Select * from Auteur where Strip_Id = 3");
        return auteurs.ToList();
    }
}