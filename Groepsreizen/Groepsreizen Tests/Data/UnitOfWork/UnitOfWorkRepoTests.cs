﻿using dal.Data.UnitOfWork;
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

			Gebruikers = new ObservableCollection<Gebruiker>(unitOfWork.GebruikerRepo.Ophalen(x => x.Voornaam.Contains("Ria")));

			Assert.NotNull(Gebruikers);
			Assert.IsInstanceOf<ObservableCollection<Gebruiker>>(Gebruikers);
		}

		[Test]
		public void LocatiesViaLandEnGemeenteOphalenTest()
		{
			ObservableCollection<Groepsreis> Groepreizen;

			Groepreizen = new ObservableCollection<Groepsreis>(unitOfWork.GroepsreisRepo.Ophalen(x => x.Bestemming.Land == "Belgie" && x.Bestemming.Gemeente == "Mol"));

			Assert.NotNull(Groepreizen);
			Assert.IsInstanceOf<ObservableCollection<Groepsreis>>(Groepreizen);
		}

		[Test]
		public void GebruikerVerwijderenTest()
		{
			// we proberen een gebruiker "Chris" te deleten, die niet in de database zit
			Gebruiker Gebruiker;

			Gebruiker = unitOfWork.GebruikerRepo.Ophalen(x => x.Voornaam.Contains("yy")).FirstOrDefault();

			unitOfWork.GebruikerRepo.Verwijderen(Gebruiker);

			Assert.IsNull(Gebruiker);
		}
	}

	[TestFixture]
	public class UnitOfWorkRepoTests2
	{
		private IUnitOfWork unitOfWork2 = A.Fake<IUnitOfWork>();
		private Bestemmingstype bestemming8 = A.Fake<Bestemmingstype>();

		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void BestemmingsTypesOphalenTest()
		{
			// Arrange
			ObservableCollection<Bestemmingstype> Bestemmingstypes2;

			// Act
			Bestemmingstypes2 = new ObservableCollection<Bestemmingstype>(unitOfWork2.BestemmingstypeRepo.Ophalen());

			// Assert
			Assert.NotNull(Bestemmingstypes2);
			Assert.IsInstanceOf<ObservableCollection<Bestemmingstype>>(Bestemmingstypes2);
		}

		[Test]
		public void abc() { }

	}
}
