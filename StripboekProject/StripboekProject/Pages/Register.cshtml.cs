using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


namespace StripboekProject.Pages;

public class Register : PageModel
{
    public IDbConnection Connect()
    {
        return new MySqlConnection
            ("Server=127.0.0.1,;Port=3306;Database=stripboekenwebapp;Uid=root;Pwd=;");
    }
    
    [BindProperty]
    public account profile { get; set; }
    
    public void OnGet()
    {

    }

    public void OnPost()
    {
        using var connection = Connect();
        int rowAffected = connection.Execute(
            "INSERT INTO stripboekenwebapp.account (Naam, Wachtwoord) VALUES (@Naam, @Wachtwoord)"
            , new {Naam = profile.Naam, Wachtwoord = profile.Wachtwoord});
    }
    
    
}