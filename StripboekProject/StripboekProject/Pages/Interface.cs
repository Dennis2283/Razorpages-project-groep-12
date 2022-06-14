namespace StripboekProject.Pages;

public interface IInterface
{
    public class Tekenaar
    {
        public string Tekenaar_naam { get; set; }
    }
    
    
    
    
    public class Auteur
    {
        public string Auteur_naam { get; set; }
        public int Auteur_Id { get; set; }
        public string Serie { get; set; }
        public int Strip_Id { get; set; }
        
        
    }
    
    
}