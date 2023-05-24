INSERT INTO dbo.Bestemmingstypes(Naam)
	VALUES 
		('Camping'),
		('Hotel'),
		('Hostel'),
		('BnB'),
		('Pretpark'),
		('Appartement');

INSERT INTO dbo.Bestemmingen(Naam, Land, Gemeente, Straat, Capaciteit, Fotonaam, BestemmingstypeId)
	VALUES 
		('Hotel Reymar', 'Spanje', 'Malgrat de Mar', 'Passeo Maritimo 96', 100, 'malgrat.jpg', 2),
		('Hotel Kipriotis Aqualand', 'Griekenland', 'Kos', 'Internal Road', 100, 'kipriotis.jpg', 2),
		('Peach Hostel & Suites', 'Portugal', 'Porto', 'Rua de Justino Teixeira 213', 100, 'peachhostel.jpg', 3),
		('Lemon Tree Urban Camping', 'Portugal', 'Faro', 'Praça da Liberdade, 6', 100, 'lemontree.jpg', 3),
		('Center Parks De Haan', 'België', 'De Haan', 'Wenduinesteenweg 150', 100, 'centerparksdehaan.jpg', 5),
		('Margarethenstein Apartment', 'Oostenrijk', 'Kaprun', 'Kirchgasse 1', 100, 'margarethenstein.jpg', 6),
		('La Villa Teresa', 'Cuba', 'Havana', 'Juan Bruno Zayas 15', 15, 'teresa.jpg', 4);

INSERT INTO dbo.Groepsreizen(Naam, Deelneemprijs, BestemmingId, Startdatum, Einddatum, Minimumleeftijd, Maximumleeftijd, PlaatsenVrij, InschrijvingGestopt)
	VALUES 
		('Beachtrip Malgrat de Mar', 950, 1, '2023-07-01', '2023-07-15', 14, 17, 1, 0),
		('Backpacktrip Italië', 750, 3, '2023-07-14', '2023-07-29', 21, 24, 1, 0),
		('Skireis Kaprun', 1500, 6, '2024-01-02', '2024-01-07', 12, 14, 1, 0),
		('Citytrip Porto', 500, 1, '2023-08-01', '2023-08-04', 18, 21, 1, 0),
		('Cultuurontdekking Cuba', 2685, 7, '2023-07-03', '2023-07-27', 18, 30, 1, 0);

INSERT INTO dbo.Gebruikers(Naam, Voornaam, Geboortedatum, Monitorbrevet, Email, Adres, Woonplaats, Opmerking)
	VALUES
		('Claes', 'Johan', '2000-01-01', 1, 's0085147@student.thomasmore.be', 'Kleinhoefstraat', 'Geel', ''),
		('Lender', 'Boeckx', '2000-01-01', 1,'r0658604@student.thomasmore.be', 'Kleinhoefstraat', 'Geel', ''),
		('Mathieu', 'Christophe', '1998-03-15', 1,'r0901658@student.thomasmore.be', 'Kleinhoefstraat', 'Geel', ''),
		('Janssens', 'Jef', '2000-01-01', 0,'jef@hotmail.com', 'Kleinhoefstraat', 'Geel', ''),
		('Peeters', 'Peter', '2000-01-01', 0,'peter@hotmail.com', 'Kleinhoefstraat', 'Geel', '');

INSERT INTO dbo.Inschrijvingen(Betaald, GroepsreisId, GebruikerId)
	VALUES 
		(1, 4, 6),
		(1, 5, 7);

INSERT INTO dbo.Opleidingen(Naam)
	VALUES 
		('Monitor basiscursus');

INSERT INTO dbo.GebruikerOpleidingen(GebruikerId, OpleidingId, Startdatum, Einddatum)
	VALUES 
		(3, 1, '2023-03-15', '2023-03-18'),
		(4, 1, '2023-03-15', '2023-03-18'),
		(5, 1, '2023-03-15', '2023-03-18');

INSERT INTO dbo.Monitors(GroepsreisId, GebruikerId, Hoofdmonitor)
	VALUES
		(13, 3, 1),
		(13, 4, 0),
		(13, 5, 0);