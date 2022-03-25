using System.ComponentModel.DataAnnotations;

namespace StripboekProject.Pages.Viewmodel;

public class Register
{
    [Required]
    public int Identity { get; set; }
    [Required]
    public char AccountRole { get; set; }
    [Required, DataType(DataType.Text)]
    public string Username { get; set; }
    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
    [Required, DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Password and Confirm Password do not match!")]
    public string ConfirmPassword { get; set; }
}