using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StripboekProject.Pages;

public class Add : PageModel
{
    [BindProperty]
    public Stripboek NewStripboek { get; set; }
    public string Msg { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult Onpost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Msg = "Nieuw stripboek succesvol toegevoegd! ";
        new StripboekRepository().AddStripboek(NewStripboek);
        return RedirectToPage("SearchResult");
    }
}