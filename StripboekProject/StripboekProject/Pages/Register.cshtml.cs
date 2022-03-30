using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


namespace StripboekProject.Pages;

public class Register : PageModel
{
    private IDbConnection Connect() 
    {
        return new MySqlConnection(
            "Server=127.0.0.1,;Port = 3306;" +
            "Database=StripboekenWebApp;" +
            "Uid=root;Pwd=;"
        );
        // HEEL BELANGRIJK check de namen van de data
    }
    
    [BindProperty]
    public Account account { get; set; }
    
    public void OnGet()
    {

    }

    public void OnPost()
    {
        
    }
    
    public void OnPostCreate()
    {
        if (ModelState.IsValid)
        { 
            // als input wordt geacepteerd wordt het deze input data verwerkt in de account table van de database
            new StripboekRepository().Add(account);
        }
    }
}   