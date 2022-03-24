using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StripboekProject.Pages;

public class SearchResult : PageModel
{
    [BindProperty (SupportsGet = true)]
    
    public string Search { get; set; }
    
    public List<Stripboek> stripboeken { get; set; }

    public IActionResult OnGet(string Search)
    {
        var stripboek = new StripboekRepository();
        stripboeken = stripboek.Search(Search); 
        return Page();
    }
}