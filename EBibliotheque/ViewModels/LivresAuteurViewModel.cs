using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EBibliotheque.Models;

namespace EBibliotheque.ViewModels
{
    public class LivresAuteurViewModel
    {
        public Auteur auteur { get; set; }
        public List<Livre> listeLivres { get; set; }
    }
}