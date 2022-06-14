using System.ComponentModel.DataAnnotations;

namespace StripboekProject.Pages;

public class Tekenaar
{
    public string Tekenaar_naam { get; set; }
    
    public int Tekenaar_Id { get; set; }
    
    public string Serie { get; set; }
    
    public int Strip_Id { get; set; }
}