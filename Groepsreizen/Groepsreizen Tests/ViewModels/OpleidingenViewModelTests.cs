using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.ViewModels;

// als we op de zoek knop drukken, dan moeten er meer dan 5 records verschijnen


namespace Groepsreizen_Tests.ViewModels
{
    [TestFixture]
    public class OpleidingenViewModelTests
    {
        OpleidingenViewModel opleidingenViewModel = new OpleidingenViewModel();

        [Test]
        public void OpleidingtypesTellen()
        {
            opleidingenViewModel.ZoekDeelnemer();

            Assert.That(opleidingenViewModel.GezochteDeelnemers.Count, Is.GreaterThan(5));
        
        }
    }
}
