using System.Collections;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace StripboekProject.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public IEnumerable accounts;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var connection = new MySqlConnection(
            "Server=127.0.0.1;Database=StripboekenwebApp;Uid=root;Pwd=;Port=3306"
        );

 
    }

}