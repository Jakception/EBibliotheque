using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using EBibliotheque.Models;
using EBibliotheque.ViewModels;

namespace EBibliotheque.Controllers
{
    public class HomeController : Controller
    {
        private IDal dal;

        public HomeController() : this(new Dal())
        {
        }

        public HomeController(IDal dalIoc)
        {
            dal = dalIoc;
        }

        // GET: Home
        public ActionResult Index()
        {
            List<Livre> listeLivres = dal.ObtientTousLesLivres();
            return View(listeLivres);
        }

        public ActionResult AfficheAuteurs()
        {
            List<Auteur> listeAuteurs = dal.ObtientTousLesAuteurs();
            return View(listeAuteurs);
        }
        public ActionResult AfficheLivre()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AfficheLivre(int id)
        {
            Livre livre = dal.ChercheLivre(id);
            return View(livre);
        }
        public ActionResult LivresPourUnAuteur()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LivresPourUnAuteur(LivresAuteurViewModel livresAuteurViewModel)
        {
            Auteur auteurRecherche = dal.ChercheAuteur(livresAuteurViewModel.auteur.Nom);
            List<Livre> listeLivreAuteurs = dal.ObtientLivresDUnAuteur(auteurRecherche.Id);

            LivresAuteurViewModel livresAuteurViewModelResultat = new LivresAuteurViewModel { auteur = auteurRecherche, listeLivres = listeLivreAuteurs };

            return View(livresAuteurViewModelResultat);
        }
    }
}