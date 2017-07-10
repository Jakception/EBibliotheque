using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBibliotheque.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime DateDeParution { get; set; }
        public virtual Auteur Auteur { get; set; }
        public virtual Client Client { get; set; }
    }
}