using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EBibliotheque.Models
{
    public class Client
    {
        [Key, Required]
        public string Email { get; set; }
        public string Nom { get; set; }
        public virtual List<Livre> Livres { get; set; }
    }
}