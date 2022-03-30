using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;



namespace StripboekProject.Pages;

public partial class Login : PageModel
{
    private IDbConnection Connect() 
    {
        return new MySqlConnection(
            "Server=127.0.0.1,;Port = 3306;" +
            "Database=StripboekenWebApp;" +
            "Uid=root;Pwd=;"
        );
    }
    
    [BindProperty]
    public MadeAccount profile { get; set; }
    public void OnGet()
    {

    }

    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            // als input wordt geacepteerd wordt er gecheckt in de database en doorverwezen als dit succesvol is
            new StripboekRepository().SignIn(profile);
        }
    }
}