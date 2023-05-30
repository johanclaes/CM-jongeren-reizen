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
	public class OpleidingenWindowTests
	{
		// we gaan registreren dat gebruiker johan de cursus dierenverzorging in juli 2023 heeft gevolgd

		[Test]
		public void LijstJuniOpvragen()
		{
			// var app = Application.Launch("C:\\Thomas More 2de jaar\\Agile en testing\\Project\\CM-jongeren-reizen\\Groepsreizen\\wpf\\bin\\Debug\\net6.0-windows\\wpf.exe");

			var app = Application.Launch("\"C:\\\\Users\\\\lende\\\\Documents\\\\thomasmore\\\\jaar 2\\\\agile en testing\\\\project1\\\\CM-jongeren-reizen\\\\Groepsreizen\\\\wpf\\\\bin\\\\Debug\\\\net6.0-windows\\\\wpf.exe\"");

			// var app = System.Windows.Application.

			using (var automation = new UIA3Automation())
			{


				var window = app.GetMainWindow(automation);

				var Aanmelden = window.FindFirstDescendant(x => x.ByAutomationId("Aanmelden")).AsButton();
				Aanmelden.Click();

				System.Threading.Thread.Sleep(1000);
				var windowopleiding = app.GetMainWindow(automation);
				var opleidingen7 = windowopleiding.FindFirstDescendant(x => x.ByAutomationId("Opleidingen")).AsButton();
				opleidingen7.Invoke();
				
				System.Threading.Thread.Sleep(1000);
				var windowopleiding2 = app.GetMainWindow(automation);

				var OpleidingMaand = windowopleiding2.FindFirstDescendant(x => x.ByAutomationId("Maanden")).AsComboBox();
				var OpleidingJaar = windowopleiding2.FindFirstDescendant(x => x.ByAutomationId("Jaren")).AsComboBox();
				var ZoekCursus = windowopleiding2.FindFirstDescendant(x => x.ByAutomationId("OpleidingOpvragen")).AsButton();
				var LijstCursussen = windowopleiding2.FindFirstDescendant(x => x.ByAutomationId("lstOpleidingen")).AsListBox();

				OpleidingMaand.Select("Juni");
				OpleidingJaar.Select("2023");
				System.Threading.Thread.Sleep(1000);
				ZoekCursus.Click();
				ZoekCursus.Click();
				int AantalCursussen = LijstCursussen.Items.Count();

				Assert.That(AantalCursussen, Is.AtLeast(2));

			}


		}
	}
}
