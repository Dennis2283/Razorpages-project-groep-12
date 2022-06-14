using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StripboekProject.Pages;

public class SearchResultJoin : PageModel
{
    
    
    [BindProperty(SupportsGet = true)] public string Search3 { get; set; }
    
    public List<Auteur> Auteurs { get; set; }
    
    public List<Stripboek> Stripboeken { get; set; }

    public IList<Tekenaar> Tekenaars { get; set; }

    
    public IActionResult

        OnGet(string Search3)

    {
        var auteur = new JoinRepository();
        Tekenaars = auteur.Search3(Search3);
        
        return Page();
    }
    
    
}







