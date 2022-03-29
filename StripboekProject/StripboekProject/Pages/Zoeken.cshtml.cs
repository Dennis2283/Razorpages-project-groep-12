using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace StripboekProject.Pages;

public class Zoeken : PageModel
{

    public List<Stripboek> Stripboeken
    {
        get
        {
            return (List<Stripboek>) new Zoekenlist().Get();
            
        }
    }

    public List<Auteur> Auteurs
    {
        get
        {
            return new Zoekenlist().Get1();
        }
    }
    
    public List<Stripboek> Stripboeken2
    {
        get
        {
            return (List<Stripboek>) new Zoekenlist().Get2();
            
        }
    }
    
    public List<Auteur> Auteurs2
    {
        get
        {
            return new Zoekenlist().Get3();
        }
    }
    
    public List<Stripboek> Stripboeken3
    {
        get
        {
            return (List<Stripboek>) new Zoekenlist().Get4();
            
        }
    }
    
    public List<Auteur> Auteurs3
    {
        get
        {
            return new Zoekenlist().Get5();
        }
    }


    public void OnGet()
    {

    }
}