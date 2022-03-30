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

    private IDbConnection Connect()
    {
        return new MySqlConnection(
            "Server=127.0.0.1;Port=3306;" +
            "Database=StripboekenWebApp;" +
            "Uid=root;Pwd=;"
        );
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
    // het toevegen van een account in register voor de account table in de database
    public void Add(Account account)
    {
        using var secondConnection = Connect();
        string sql =
            @"INSERT INTO account (Naam, Wachtwoord, AccountId) 
            VALUES (@Naam, @Wachtwoord, @AccountId)";
        int RowsInserted = secondConnection.Execute(sql, account);
        // als dit gemergged is in main check insert into hierboven voor hun datasource (database tabelnamen zijn bij mij in lowercase en kan misschien betekenen dat ze niet direct koppelen zonder correctie op hun hoofdletters) 
    }
    // het checken van de account database om de input te valideren en vervolgens naar home door te verwijzen   
    public IActionResult SignIn(MadeAccount profile)
    {
        using var thirdConnection = Connect();
        string select = @"SELECT * FROM account WHERE Naam = @Naam AND Wachtwoord = @Wachtwoord";
        object RowsFound = thirdConnection.QuerySingle(select, profile);
        // hier graag dezelfde check als bij de insert into in Add functie hierboven maar dan bij select * from hier
        object workaround = null;
        if (RowsFound != null)
        {
            return RedirectToPage("/Login/Home");
        }

        return null;
    }
}