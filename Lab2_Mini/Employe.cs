using System.Diagnostics.CodeAnalysis;
using System.Net.Cache;

public class Employe
{
    private string matricule;
    private string nom;
    private string prenom;
    private DateTime dateNaissance;
    private DateTime dateEmbauche;
    private double salaire;

    public Employe(
        string matricule, 
        string nom, 
        string prenom, 
        DateTime dateNaissance, 
        DateTime dateEmbauche, 
        double salaire)
    {
        this.matricule = matricule;
        this.nom = nom;
        this.prenom = prenom;
        this.dateNaissance = dateNaissance;
        this.dateEmbauche = dateEmbauche;
        this.salaire = salaire;
    }

    public int Age()
    {
        DateTime today = DateTime.Now;
        int age = today.Year - this.dateNaissance.Year;

        if ((today.Month < this.dateNaissance.Month) || 
            ((today.Month == this.dateNaissance.Month) && 
            (today.Day < this.dateNaissance.Day)))
        {
            age--;
        }
        return age;
        
    }

    public int Anciennete()
    {
        DateTime today = DateTime.Now;
        int anciennete = today.Year - this.dateEmbauche.Year;

        if ((today.Month < this.dateEmbauche.Month) || 
            ((today.Month == this.dateEmbauche.Month) && 
            (today.Day < this.dateEmbauche.Day)))
        {
            anciennete--;
        }
        return anciennete;
    }

    public void AugmentationDuSalaire()
    {
        int anciennete = Anciennete();
        if (anciennete < 5)
        {
            this.salaire = this.salaire * 1.02;
        } else if (anciennete < 10){
            this.salaire = this.salaire * 1.05;
        } else
        {
            this.salaire = this.salaire * 1.1;
        }
    }

    public void AfficherEmploye()
    {
        Console.WriteLine("la matricule est: " + this.matricule);
        Console.WriteLine("le nom complet est: " + this.nom.ToUpper() + " " + char.ToUpper(this.prenom[0]) + this.prenom.Substring(1).ToLower());
        //Console.WriteLine("Nom complet : " + this.nom.ToUpper() + " " + this.prenom.Substring(0, 1).ToUpper() + this.prenom.Substring(1).ToLower());
        Console.WriteLine("l'age est: " + this.Age() + " ans");
        Console.WriteLine("l'ancienneté est: " + this.Anciennete() + " ans");
        Console.WriteLine("le salaire est: " + this.salaire);
    }

}