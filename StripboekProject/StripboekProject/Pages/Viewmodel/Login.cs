using System.ComponentModel.DataAnnotations;

namespace StripboekProject.Pages.Viewmodel;

public class Login
{
    [Required, DataType(DataType.Text)]
    public string Username { get; set; }
     
    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
}