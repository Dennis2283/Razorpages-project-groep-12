using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace StripboekProject.Pages;

public class Zoeken : PageModel
{

    public IEnumerable<Stripboek> Stripboeken
    {
        get
        {
            return new Zoekenlist().Get();
        }
    }
    public void OnGet()
    {

    }
}