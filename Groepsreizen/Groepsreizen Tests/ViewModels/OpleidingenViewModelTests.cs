using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.ViewModels;


namespace Groepsreizen_Tests.ViewModels
{
	[TestFixture]
	public class OpleidingenViewModelTests
	{
		OpleidingenViewModel opleidingenViewModel = new OpleidingenViewModel();

		[Test]
		public void GezochteDeelnemersTellen()
		{
			// als we op de zoek knop "Zoek Deelnemer" drukken, dan moeten er meer dan 5 records / users verschijnen
			// als ik ohan invul, en dan "Zoek Deelnemer" druk,  dan moet er minstens 1 inzetten, namelijk mezelf

			// Arrange
			opleidingenViewModel.Deelnemer = "ohan";
			// Act
			opleidingenViewModel.ZoekDeelnemer();
			// Assert
			Assert.That(opleidingenViewModel.GezochteDeelnemers.Count, Is.GreaterThanOrEqualTo(1));
		}

		BestemmingenViewModel bestemmingenViewModel = new BestemmingenViewModel();

		[Test]
		public void BestemmingenInBelgieTellen()
		{
			// er zijn 3 bestemmingen in Belgie, dus als we in combobox belgie selecteren, dan moeten we er 3 tellen

			// Arrange
			bestemmingenViewModel.SelectedLand2 = "belgie";

			// Act
			int AantalBestemmigenBelgie = bestemmingenViewModel.Bestemmingen.Count;

			// Assert
			Assert.That(AantalBestemmigenBelgie, Is.EqualTo(3));
		}

		[Test]
		public void BestemmingsTypeToevoegenEnTellen()
		{
			// we proberen nieuw bestemmingstype toe te voegen, maar dit moet foutmelding geven

			// Arrange
			bestemmingenViewModel.NieuwBestemmingtype = "AB";
			// Act
			bestemmingenViewModel.BestemmingstypeToevoegen();
			// Assert
			Assert.That(bestemmingenViewModel.FoutmeldingBestemming, Is.EqualTo("Bestemmingstype minstens 3 karakters"));

		}
	}
}
