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
    public class GroepsreizenViewTest
    {
        [Test]
        public void ReisSelecteren()
        {
            var app = Application.Launch("C:\\Users\\lende\\Documents\\thomasmore\\jaar 2\\agile en testing\\project1\\CM-jongeren-reizen\\Groepsreizen\\wpf\\bin\\Debug\\net6.0-windows\\wpf.exe");

            using(var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                var Aanmelden = window.FindFirstDescendant(x => x.ByAutomationId("Aanmelden")).AsButton();
                Aanmelden.Click();

                System.Threading.Thread.Sleep(1000);
                var startWindow = app.GetMainWindow(automation);
                var groepsreizen = startWindow.FindFirstDescendant(x => x.ByAutomationId("Groepsreizen")).AsButton();
                groepsreizen.Click();

                var groepsreizenWindow = app.GetMainWindow(automation);

                var txtNaamReis = groepsreizenWindow.FindFirstDescendant(x => x.ByAutomationId("txtNaamReis")).AsTextBox();
                var btnZoekReis = groepsreizenWindow.FindFirstDescendant(x => x.ByAutomationId("btnZoekReis")).AsButton();
                var lbGezochteReizen = groepsreizenWindow.FindFirstDescendant(x => x.ByAutomationId("lstGezochteReizen")).AsListBox();
                var txtNaam = groepsreizenWindow.FindFirstDescendant(x => x.ByAutomationId("txtNaamGroepsreis")).AsTextBox();

                txtNaamReis.Enter("Dieren");
                btnZoekReis.Click();
                lbGezochteReizen.FindFirstDescendant().Click();

                System.Threading.Thread.Sleep(1000);

                Assert.That(txtNaam.Text, Is.EqualTo("Dierenliefde"));
            }
        }
    }
}
