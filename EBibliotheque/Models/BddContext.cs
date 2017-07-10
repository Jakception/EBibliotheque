using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace EBibliotheque.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Livre> Livres { get; set; }
    }
}