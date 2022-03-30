using System.ComponentModel.DataAnnotations;
using System.Configuration;
using Org.BouncyCastle.Utilities;
using ErrorEventArgs = Microsoft.AspNetCore.Components.Web.ErrorEventArgs;

namespace StripboekProject.Pages;
/* Stripboek table */
public class Stripboek
{
    [Required(ErrorMessage = "StripId is verplicht")]
    public int StripId { get; set; }
    [Required(ErrorMessage = "Titel is verplicht. ")]
    public string Titel { get; set; }
    public int Aantal_blz { get; set; }
    public string Serie { get; set; }
    [Required(ErrorMessage = "Serienummer is verplicht. ")]
    public int Serienummer { get; set; }
    public string Uitgave { get; set; }
    public int Dikte_mm { get; set; }
    public int Lengte_mm { get; set; }
    public int Breedte_mm { get; set; }
    public bool NSFW { get; set; }
    public bool Digitaal { get; set; }
    public bool Verified { get; set; }
}