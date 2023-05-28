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

			var app = Application.Launch("C:\\Users\\fb922\\Desktop\\agile\\project\\CM-jongeren-final4\\CM-jongeren-reizen\\Groepsreizen\\wpf\\bin\\Debug\\net6.0-windows\\wpf.exe");

			// var app = System.Windows.Application.

			using (var automation = new UIA3Automation())
			{


				var window = app.GetMainWindow(automation);

				var Aanmelden = window.FindFirstDescendant(x => x.ByAutomationId("Aanmelden")).AsButton();
				Aanmelden.Click();

				System.Threading.Thread.Sleep(5);
				var windowpersonen = app.GetMainWindow(automation);
				var personen = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Personen")).AsButton();
				personen.Invoke();

				//System.Threading.Thread.Sleep(5);
				//var windowpersonen = app.GetMainWindow(automation);
				//var personen = windowpersonen.FindFirstDescendant(x => x.ByAutomationId("Bestemmingen")).AsButton();
				//personen.Invoke();




			}


		}
	}
}
