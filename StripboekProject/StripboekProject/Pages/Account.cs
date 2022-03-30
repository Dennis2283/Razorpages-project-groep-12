using System.ComponentModel.DataAnnotations;

namespace StripboekProject.Pages;

// table data voor register.cshtml(.cs) (beide linken aan account vast)
public class Account
{
    
    public int AccountId { get; set; }
    [Required]
    public char Account_soort { get; set; }
    
    [Required, DataType(DataType.Text)]
    public string Naam { get; set; }
    
    [Required, DataType(DataType.Password)]
    public string Wachtwoord { get; set; }
    
    [Required, DataType(DataType.Password)]
    [Compare(nameof(Wachtwoord), ErrorMessage = "Password and Confirm Password do not match!")]
    public string ConfirmWachtwoord { get; set; }
}
// table data voor login.cshtml(.cs) (beide linken aan account vast)
public class MadeAccount
{
    [Required, DataType(DataType.Text)] 
    public string Naam { get; set; }
    
    [Required, DataType(DataType.Password)]
    public string Wachtwoord { get; set; }
}