using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBibliotheque.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public Livre ChercheLivre(int id)
        {
            return bdd.Livres.FirstOrDefault(l => l.Id == id);
        }

        public List<Livre> ObtientLivresDUnAuteur(int id)
        {
            return bdd.Livres.Where(l => l.Auteur.Id == id).ToList();
        }

        public List<Auteur> ObtientTousLesAuteurs()
        {
            return bdd.Auteurs.ToList();
        }

        public List<Livre> ObtientTousLesLivres()
        {
            return bdd.Livres.ToList();
        }

        public void CreerLivre(string titre)
        {
            bdd.Livres.Add(new Livre { Titre = titre, DateDeParution = DateTime.Now });
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public void CreerEchantillon()
        {
            // Auteurs
            Auteur a1 = new Auteur { Nom = "Victor Hugo" };
            bdd.Auteurs.Add(a1);
            Auteur a2 = new Auteur { Nom = "Charles Baudelaire" };
            bdd.Auteurs.Add(a2);
            Auteur a3 = new Auteur { Nom = "Alfred De Musset" };
            bdd.Auteurs.Add(a3);

            // Livres
            Livre l1 = new Livre { Titre = "Bug-Jargal", DateDeParution = new DateTime(1818, 01, 01), Auteur = a1 };
            bdd.Livres.Add(l1);
            Livre l2 = new Livre { Titre = "Notre-Dame de Paris", DateDeParution = new DateTime(1831, 01, 01), Auteur = a1 };
            bdd.Livres.Add(l2);
            Livre l3 = new Livre { Titre = "Les Fleurs du mal", DateDeParution = new DateTime(1857, 01, 01), Auteur = a2 };
            bdd.Livres.Add(l3);
            Livre l4 = new Livre { Titre = "Lorenzaccio ", DateDeParution = new DateTime(1834, 01, 01), Auteur = a3 };
            bdd.Livres.Add(l4);
            Livre l5 = new Livre { Titre = "Il ne faut jurer de rien", DateDeParution = new DateTime(1836, 01, 01), Auteur = a3 };
            bdd.Livres.Add(l5);

            // Clients
            Client c1 = new Client { Email = "test@gmail.com", Nom = "Test", Livres = new List<Livre> { l1, l2 } };
            Client c2 = new Client { Email = "toto@gmail.com", Nom = "Toto", Livres = new List<Livre> { l3, l4, l5 } };

            l1.Client = c1;
            l2.Client = c1;
            l3.Client = c2;
            l4.Client = c2;
            l5.Client = c2;
            // Sauvegardes

            bdd.SaveChanges();
        }
    }
}