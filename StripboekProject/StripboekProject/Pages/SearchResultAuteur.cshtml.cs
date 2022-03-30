using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StripboekProject.Pages;

public class SearchResultAuteur : PageModel
{
    
    [BindProperty(SupportsGet = true)] public string Search2 { get; set; }
    
    public List<Auteur> Auteurs { get; set; }
    
    public IActionResult
        
        OnGet(string Search2)
    
    {
        var auteur = new AuteurRepository();
        Auteurs = auteur.Search2(Search2);

        return Page();
    }
}