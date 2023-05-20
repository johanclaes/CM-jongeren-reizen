using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using NUnit.Framework;
using wpf;
using wpf.UserControls;

namespace Groepsreizen_Tests.Views
{
    [TestFixture]
    public class PersonenWindowTests
    {
        [Test]
        public void GebruikerAanmakenTest()
        {
            var app = Application.Launch("C:\\Thomas More 2de jaar\\Agile en testing\\Project\\CM-jongeren-reizen\\Groepsreizen\\wpf\\bin\\Debug\\net6.0-windows\\wpf.exe");
            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                var Aanmelden = window.FindFirstDescendant(x => x.ByAutomationId("Aanmelden")).AsButton();
                Aanmelden.Click();

                System.Threading.Thread.Sleep(5);
                var windowpersonen = app.GetMainWindow(automation);
                var personen = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Personen")).AsButton();
                personen.Invoke();

                var NaamGebruiker = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("NaamGebruiker")).AsTextBox();
                var ZoekGebruikers = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("ZoekGebruikers")).AsButton();
                var lstGebruikers = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("lstGebruikers")).AsListBox();
                var Naam = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Naam")).AsTextBox();
                var Voornaam = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Voornaam")).AsTextBox();
                var Geboortedatum = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Geboortedatum")).AsDateTimePicker();
                var Email = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Email")).AsTextBox();
                var Adres = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Adres")).AsTextBox();
                var Woonplaats = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Woonplaats")).AsTextBox();
                var Allergie = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Allergie")).AsTextBox();

                var GebruikerAanmaken = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("GebruikerAanmaken")).AsButton();
                var FormulierLeegmaken = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("FormulierLeegmaken")).AsButton();

                ZoekGebruikers.Click();
                Naam.Enter("Mathieu");
                Voornaam.Enter("Christophe");
                Geboortedatum.SelectedDate = new DateTime(1998, 03, 15);
                Email.Enter("christophe@email.com");
                Adres.Enter("Eggestraat");
                Woonplaats.Enter("Vosselaar");
                Allergie.Enter("Hooikoorts");

                var aantalgebruikers = lstGebruikers.Items.Count();

                GebruikerAanmaken.Click();

                var eindgebruikers = lstGebruikers.Items.Count();

                Assert.That(eindgebruikers, Is.EqualTo(aantalgebruikers + 1));

                windowpersonen.Close();
                window.Close();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
