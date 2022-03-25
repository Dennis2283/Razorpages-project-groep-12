using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StripboekProject.Pages;

public class Register : PageModel
{
    [BindProperty]
    public Viewmodel.Register register { get; set; }
    public void OnGet()
    {

    }
    
    public void OnPost()
    {
        var name = "";
        var password = "";
        var id = "";
        var role = "";

        if (ModelState.IsValid)
        {
            // var db = (Database).open("Table")
            
        }
    }
}