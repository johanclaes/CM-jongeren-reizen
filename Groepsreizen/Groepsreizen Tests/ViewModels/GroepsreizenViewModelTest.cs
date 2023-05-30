using dal.Data.UnitOfWork;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.UserControls;
using wpf.ViewModels;
using models;
using NUnit.Framework;
using System.Collections.ObjectModel;

namespace Groepsreizen_Tests.ViewModels
{
    [TestFixture]
    public class GroepsreizenViewModelTest
    {
        private IUnitOfWork unitOfWork = A.Fake<IUnitOfWork>();
        GroepsreizenViewModel gvm = new GroepsreizenViewModel();

        [Test]
        public void ZoekReis()
        {
            gvm.NaamReis = "Dieren";

            gvm.ZoekReis();

            Assert.That(gvm.GezochteReizen.Count, Is.EqualTo(1));
        }
        [Test]
        public void ZoekMonitorsViaOpleiding()
        {
            gvm.NaamMonitor = "Basis";

            gvm.ZoekMonitorViaOpleiding();

            Assert.That(gvm.GezochteGebruikers.Count, Is.EqualTo(1));
        }
        [Test]
        public void LaadBestemmingen()
        {
            ObservableCollection<Bestemming> bestemmingen;

            bestemmingen = new ObservableCollection<Bestemming>(unitOfWork.BestemmingRepo.Ophalen());

            Assert.NotNull(bestemmingen);
            Assert.IsInstanceOf<ObservableCollection<Bestemming>>(bestemmingen);
        }
    }
}
