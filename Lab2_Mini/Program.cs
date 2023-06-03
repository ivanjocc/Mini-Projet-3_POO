using System;

namespace Lab2_Mini // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("matricule: ");
            string matricule = Console.ReadLine();

            Console.WriteLine("nom: ");
            string nom = Console.ReadLine();

            Console.WriteLine("prenom: ");
            string prenom = Console.ReadLine();

            Console.WriteLine("date naissance comme ceci jour/mois/annee: ");
            DateTime dateNaissance = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("date embauche comme ceci jour/mois/annee: ");
            DateTime dateEmbauche = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("salaire: ");
            double salaire = double.Parse(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("dates personneles");
            Employe newObject = new Employe(matricule, nom, prenom, dateNaissance, dateEmbauche, salaire);

            newObject.AfficherEmploye();

            Console.ReadLine();

        }
    }
}