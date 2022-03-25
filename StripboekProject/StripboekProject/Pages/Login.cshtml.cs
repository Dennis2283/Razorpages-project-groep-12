using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StripboekProject.Pages;

public class Login : PageModel
{
    [BindProperty]
    public Viewmodel.Login login { get; set; }
    public void OnGet()
    {

    }
}