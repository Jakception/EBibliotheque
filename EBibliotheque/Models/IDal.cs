using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBibliotheque.Models
{
    public interface IDal : IDisposable
    {
        List<Livre> ObtientTousLesLivres();
        List<Auteur> ObtientTousLesAuteurs();
        List<Livre> ObtientLivresDUnAuteur(int id);
        Livre ChercheLivre(int id);
        void CreerEchantillon();
        void CreerLivre(string titre);
    }
}
