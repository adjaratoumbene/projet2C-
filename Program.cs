using System;
using System.Collections.Generic;


public enum StatutTache
{
    EnAttente,
    EnCours,
    Terminee
}

public class Projet
{
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Description { get; set; }
    public DateTime DateDeDebut { get; set; }
    public DateTime DateDeFin { get; set; }
    public List<Tache> Taches { get; set; }

    public Projet(int id, string nom, string description, DateTime debut, DateTime fin)
    {
        ID = id;
        Nom = nom;
        Description = description;
        DateDeDebut = debut;
        DateDeFin = fin;
        Taches = new List<Tache>();
    }

    public void AjouterTache(Tache tache)
    {
        Taches.Add(tache);
        Console.WriteLine($"Tâche '{tache.Nom}' ajoutée au projet '{Nom}'");
    }

    public void SupprimerTache(Tache tache)
    {
        Taches.Remove(tache);
        Console.WriteLine($"Tâche '{tache.Nom}' supprimée du projet '{Nom}'");
    }
}


public class Tache
{
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Description { get; set; }
    public StatutTache Statut { get; set; }
    public DateTime DateDeDebut { get; set; }
    public DateTime DateDeFin { get; set; }

    public Tache(int id, string nom, string description, DateTime debut, DateTime fin)
    {
        ID = id;
        Nom = nom;
        Description = description;
        Statut = StatutTache.EnAttente;
        DateDeDebut = debut;
        DateDeFin = fin;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Projet projet = new Projet(1, "Projet A", "Description du projet A", DateTime.Now, DateTime.Now.AddDays(30));
        Console.WriteLine($"Projet '{projet.Nom}' créé.");


        Tache tache1 = new Tache(1, "Tâche 1", "Description de la tâche 1", DateTime.Now, DateTime.Now.AddDays(7));
        Tache tache2 = new Tache(2, "Tâche 2", "Description de la tâche 2", DateTime.Now, DateTime.Now.AddDays(14));

        projet.AjouterTache(tache1);
        projet.AjouterTache(tache2);
        projet.SupprimerTache(tache1);
    }
}