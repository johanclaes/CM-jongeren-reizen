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

        [Test]
        public void GebruikersZoekenTest() 
        {
            personenViewModel.ZoekGebruikers();

            Assert.That(personenViewModel.Gebruikers, Is.Not.Null);
        }
    }
}
