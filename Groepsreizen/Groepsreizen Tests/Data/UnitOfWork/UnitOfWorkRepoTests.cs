using dal.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using System.Collections.ObjectModel;
using wpf.UserControls;
using dal;
using models;

namespace Groepsreizen_Tests.Data.UnitOfWork
{
    [TestFixture]
    public class UnitOfWorkRepoTests
    {
        private IUnitOfWork unitOfWork = A.Fake<IUnitOfWork>();

        [Test]
        public void OphalenGebruikersTest() 
        {
            ObservableCollection<Gebruiker> Gebruikers;

            Gebruikers = new ObservableCollection<Gebruiker>(unitOfWork.GebruikerRepo.Ophalen(x => x.Voornaam.Contains("Chris")));

            Assert.NotNull(Gebruikers);
            Assert.IsInstanceOf<ObservableCollection<Gebruiker>>(Gebruikers);
        }

        [Test]
        public void LocatiesViaLandEnGemeenteOphalenTest()
        {
            ObservableCollection<Groepsreis> Groepreizen;

            Groepreizen = new ObservableCollection<Groepsreis>(unitOfWork.GroepsreisRepo.Ophalen(x => x.Bestemming.Land == "België" && x.Bestemming.Gemeente == "Mol"));

            Assert.NotNull(Groepreizen);
            Assert.IsInstanceOf<ObservableCollection<Groepsreis>>(Groepreizen);
        }

        [Test]
        public void BestemmingVerwijderenTest() 
        {
            
        }
    }
}
