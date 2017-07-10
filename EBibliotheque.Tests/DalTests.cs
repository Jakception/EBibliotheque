using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;

using System.Data.Entity;

using EBibliotheque.Models;

namespace EBibliotheque.Tests
{
    [TestClass]
    public class DalTests
    {
        private IDal dal;

        [TestInitialize]
        public void Init_AvantChaqueTest()
        {
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());

            dal = new Dal();
        }

        [TestMethod]
        public void CreerUnLivre_AvecUnNouveauLivre_ObtientTousLesLivresRenvoitBienLeLivre()
        {
            using (IDal Dal = new Dal())
            {
                Dal.CreerLivre("Test");
                List<Livre> livres = Dal.ObtientTousLesLivres();

                Assert.IsNotNull(livres);
                Assert.AreEqual(1, livres.Count);
                Assert.AreEqual("Test", livres[0].Titre);
            }
        }

        [TestCleanup]
        public void ApresChaqueTest()
        {
            dal.Dispose();
        }
    }
}
