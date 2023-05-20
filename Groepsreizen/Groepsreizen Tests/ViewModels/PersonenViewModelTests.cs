using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.ViewModels;

namespace Groepsreizen_Tests.ViewModels
{
    [TestFixture]
    public class PersonenViewModelTests
    {
        PersonenViewModel personenViewModel = new PersonenViewModel();
        InschrijvingenViewModel inschrijvingenViewModel = new InschrijvingenViewModel();

        [Test]
        public void GebruikersZoekenTest() 
        {
            inschrijvingenViewModel.ZoekGebruikers();

            Assert.That(inschrijvingenViewModel.Gebruikers, Is.Not.Null);
        }
    }
}
