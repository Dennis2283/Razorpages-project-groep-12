using System.Data;
using System.Runtime.CompilerServices;
using Dapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;


namespace StripboekProject.Pages;

public class StripboekRepository : PageModel
{

    public IDbConnection Connect()
    {
        return new MySqlConnection
            ("Server=127.0.0.1,;Port=3306;Database=stripboekenwebapp;Uid=root;Pwd=;");
    }
    
/* Connection aanroepen en met dapper Query uitvoeren
    Hij pakt het stripboek wat het meest overeenkomt met de titel van wat je invoert*/
    public List<Stripboek> Search(string search)
    {
        using var connection = Connect();
        var stripboeken = connection.Query<Stripboek>("SELECT * FROM Stripboek WHERE Titel LIKE @search", new
        {
            search = "%" + search + "%"
        });
        return stripboeken.ToList();
    }
    public void AddStripboek(Stripboek stripboek) 
    {
        using var connection = Connect();
        int numRowsEffected = connection.Execute
        ("INSERT INTO Stripboek (StripId, Titel, Aantal_blz, Serie, Serienummer, Uitgave, Dikte_mm, Lengte_mm, Breedte_mm, NSFW, Digitaal, Verified) VALUES(@StripId, @Titel, @Aantal_blz, @Serie, @Serienummer, @Uitgave, @Dikte_mm, @Lengte_mm, @Breedte_mm, @NSFW, @Digitaal, @Verified)"
            , new {StripId = stripboek.StripId, Titel = stripboek.Titel, Aantal_blz = stripboek.Aantal_blz, Serie = stripboek.Serie, Serienummer = stripboek.Serienummer, Uitgave = stripboek.Uitgave, Dikte_mm = stripboek.Dikte_mm, Lengte_mm = stripboek.Lengte_mm, Breedte_mm = stripboek.Breedte_mm, NSFW = stripboek.NSFW, Digitaal = stripboek.Digitaal, Verified = stripboek.Verified});
    }
}