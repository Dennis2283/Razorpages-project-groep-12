namespace StripboekProject.Pages;
/* Stripboek table */
public class Stripboek
{
    public int StripId { get; set; }
    public string Titel { get; set; }
    public int Aantal_blz { get; set; }
    public string Serie { get; set; }
    public int Serienummer { get; set; }
    public string Uitgave { get; set; }
    public int Dikete_mm { get; set; }
    public int Lengte_mm { get; set; }
    public int Breedte_mm { get; set; }
    public bool NSFW { get; set; }
    public bool Digitaal { get; set; }
    public bool Verified { get; set; }
}