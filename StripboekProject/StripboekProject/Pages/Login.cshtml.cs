using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;



namespace StripboekProject.Pages;

public partial class Login : PageModel
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

    public IActionResult Find()
    {
        using var connection = Connect();
        var account = connection.QuerySingleOrDefault<account>(
            "SELECT * FROM stripboekenwebapp.account WHERE Naam = @Naam AND Wachtwoord = @Wachtwoord",
            new {Naam = profile.Naam, Wachtwoord = profile.Wachtwoord});
        if (account != null)
        {
            return OnPostSucces();
        }
        else
        {
            return OnPostFailure();
        }
    }
    
    public IActionResult OnPostSucces()
    {
        return RedirectToPage("Home");
    }

    public IActionResult OnPostFailure()
    {
        return RedirectToPage("Login");
    }
    
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            return Find();
        }

        return Page();
    }
}