SET IDENTITY_INSERT [dbo].[Bestemmingstypes] ON
INSERT INTO [dbo].[Bestemmingstypes] ([Id], [Naam]) VALUES (1, N'hoeve')
INSERT INTO [dbo].[Bestemmingstypes] ([Id], [Naam]) VALUES (2, N'sporthotel')
INSERT INTO [dbo].[Bestemmingstypes] ([Id], [Naam]) VALUES (3, N'tentenkamp')
INSERT INTO [dbo].[Bestemmingstypes] ([Id], [Naam]) VALUES (4, N'zeilboot')
INSERT INTO [dbo].[Bestemmingstypes] ([Id], [Naam]) VALUES (5, N'skihotel')
INSERT INTO [dbo].[Bestemmingstypes] ([Id], [Naam]) VALUES (6, N'kamphuis')
SET IDENTITY_INSERT [dbo].[Bestemmingstypes] OFF

SET IDENTITY_INSERT [dbo].[Bestemmingen] ON
INSERT INTO [dbo].[Bestemmingen] ([Id], [Naam], [Land], [Gemeente], [Straat], [Capaciteit], [Fotonaam], [BestemmingstypeId]) VALUES (1, N'geitenboerderij', N'Nederland', N'goes', N'dokkum, 5', 45, N'test.png', 1)
INSERT INTO [dbo].[Bestemmingen] ([Id], [Naam], [Land], [Gemeente], [Straat], [Capaciteit], [Fotonaam], [BestemmingstypeId]) VALUES (2, N'postelheide', N'Belgie', N'mol', N'postelsesteenweg', 85, N'test.png', 3)
INSERT INTO [dbo].[Bestemmingen] ([Id], [Naam], [Land], [Gemeente], [Straat], [Capaciteit], [Fotonaam], [BestemmingstypeId]) VALUES (3, N'kaprunski', N'Oostenrijk', N'uttendorf', N'tirolerstrasse, 5', 50, N'test.png', 5)
INSERT INTO [dbo].[Bestemmingen] ([Id], [Naam], [Land], [Gemeente], [Straat], [Capaciteit], [Fotonaam], [BestemmingstypeId]) VALUES (4, N'keiheuvel', N'Belgie', N'balen', N'vliegwezenstr 5', 55, N'keiheuvel.png', 2)
INSERT INTO [dbo].[Bestemmingen] ([Id], [Naam], [Land], [Gemeente], [Straat], [Capaciteit], [Fotonaam], [BestemmingstypeId]) VALUES (5, N'sports de l''eau', N'Frankrijk', N'nantes', N'rue des collines 2', 35, N'test.png', 2)
INSERT INTO [dbo].[Bestemmingen] ([Id], [Naam], [Land], [Gemeente], [Straat], [Capaciteit], [Fotonaam], [BestemmingstypeId]) VALUES (6, N'ark bonavonture', N'Nederland', N'harderwijk', N'---', 20, N'test.png', 4)
INSERT INTO [dbo].[Bestemmingen] ([Id], [Naam], [Land], [Gemeente], [Straat], [Capaciteit], [Fotonaam], [BestemmingstypeId]) VALUES (7, N'de oesterput', N'Belgie', N'oostende', N'spuikom 5', 55, N'test.png', 6)
SET IDENTITY_INSERT [dbo].[Bestemmingen] OFF


SET IDENTITY_INSERT [dbo].[Gebruikers] ON
INSERT INTO [dbo].[Gebruikers] ([Id], [Naam], [Voornaam], [Geboortedatum], [IsLid], [Telefoonnummer], [Monitorbrevet], [Hoofdmonitorbrevet], [Webadmin], [Email], [Adres], [Woonplaats], [Allergie], [Medicatie], [Rolstoel], [Opmerking], [Paswoord]) VALUES (4, N'Claes', N'Johan', N'1971-08-17 00:00:00', 1, N'+32475891000', 1, 1, 1, N'johan.claes@belbone.net', N'hangarstraat 11', N'mol', N'', N'', 0, N'mag niet zwemmn', N'dkdk')
INSERT INTO [dbo].[Gebruikers] ([Id], [Naam], [Voornaam], [Geboortedatum], [IsLid], [Telefoonnummer], [Monitorbrevet], [Hoofdmonitorbrevet], [Webadmin], [Email], [Adres], [Woonplaats], [Allergie], [Medicatie], [Rolstoel], [Opmerking], [Paswoord]) VALUES (7, N'Mathieu', N'Christophe', N'1998-02-02 00:00:00', 1, N'+32478123456', 1, 0, 1, N'cm@gmail.com', N'kerkstraat 2', N'turnhout', N' ', N' ', 0, N'genoeg drinken', N'12345')
INSERT INTO [dbo].[Gebruikers] ([Id], [Naam], [Voornaam], [Geboortedatum], [IsLid], [Telefoonnummer], [Monitorbrevet], [Hoofdmonitorbrevet], [Webadmin], [Email], [Adres], [Woonplaats], [Allergie], [Medicatie], [Rolstoel], [Opmerking], [Paswoord]) VALUES (8, N'Boeckx', N'Lender', N'1999-07-05 00:00:00', 1, N'+32496256987', 1, 1, 1, N'lb@proximus.com', N'dalstraat 8', N'herentals', NULL, NULL, 0, NULL, N'12345')
INSERT INTO [dbo].[Gebruikers] ([Id], [Naam], [Voornaam], [Geboortedatum], [IsLid], [Telefoonnummer], [Monitorbrevet], [Hoofdmonitorbrevet], [Webadmin], [Email], [Adres], [Woonplaats], [Allergie], [Medicatie], [Rolstoel], [Opmerking], [Paswoord]) VALUES (11, N'Peeters', N'Ria', N'2008-08-05 00:00:00', 1, N'+3214123456', 0, 0, 0, N'ria@hotmail.com', N'dd', N'geel', N'melk', NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Gebruikers] ([Id], [Naam], [Voornaam], [Geboortedatum], [IsLid], [Telefoonnummer], [Monitorbrevet], [Hoofdmonitorbrevet], [Webadmin], [Email], [Adres], [Woonplaats], [Allergie], [Medicatie], [Rolstoel], [Opmerking], [Paswoord]) VALUES (12, N'Ruts', N'Linda', N'2009-09-06 00:00:00', 0, N'+3214987654', 0, 0, 0, N'linda@gmail.com', N'parkstraat 6', N'kasterlee', NULL, NULL, 0, NULL, NULL)
INSERT INTO [dbo].[Gebruikers] ([Id], [Naam], [Voornaam], [Geboortedatum], [IsLid], [Telefoonnummer], [Monitorbrevet], [Hoofdmonitorbrevet], [Webadmin], [Email], [Adres], [Woonplaats], [Allergie], [Medicatie], [Rolstoel], [Opmerking], [Paswoord]) VALUES (13, N'Jansen', N'Mia', N'2009-09-18 00:00:00', 0, N'+3237654321', 1, 1, 0, N'miajansen@skynet.be', N'lindendreef 5', N'lille', NULL, NULL, 0, N'bang in donder', NULL)
INSERT INTO [dbo].[Gebruikers] ([Id], [Naam], [Voornaam], [Geboortedatum], [IsLid], [Telefoonnummer], [Monitorbrevet], [Hoofdmonitorbrevet], [Webadmin], [Email], [Adres], [Woonplaats], [Allergie], [Medicatie], [Rolstoel], [Opmerking], [Paswoord]) VALUES (15, N'Moonen', N'Maarten', N'1980-05-22 00:00:00', 1, N'+32495123456', 1, 0, 0, N'mm@skynet.be', N'lindenweg 8', N'turnhout', NULL, NULL, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Gebruikers] OFF


SET IDENTITY_INSERT [dbo].[OpleidingTypes] ON
INSERT INTO [dbo].[OpleidingTypes] ([Id], [Naam]) VALUES (1, N'basis-monitor')
INSERT INTO [dbo].[OpleidingTypes] ([Id], [Naam]) VALUES (2, N'hoofd-monitor')
INSERT INTO [dbo].[OpleidingTypes] ([Id], [Naam]) VALUES (3, N'dierenverzorging')
INSERT INTO [dbo].[OpleidingTypes] ([Id], [Naam]) VALUES (4, N'creatief knutselen')
SET IDENTITY_INSERT [dbo].[OpleidingTypes] OFF


SET IDENTITY_INSERT [dbo].[Opleidingen] ON
INSERT INTO [dbo].[Opleidingen] ([Id], [OpleidingTypeId], [Startdatum], [Einddatum]) VALUES (1, 1, N'2023-06-02 00:00:00', N'2023-06-04 00:00:00')
INSERT INTO [dbo].[Opleidingen] ([Id], [OpleidingTypeId], [Startdatum], [Einddatum]) VALUES (2, 2, N'2023-06-16 00:00:00', N'2023-06-18 00:00:00')
INSERT INTO [dbo].[Opleidingen] ([Id], [OpleidingTypeId], [Startdatum], [Einddatum]) VALUES (3, 4, N'2023-06-23 00:00:00', N'2023-06-25 00:00:00')
INSERT INTO [dbo].[Opleidingen] ([Id], [OpleidingTypeId], [Startdatum], [Einddatum]) VALUES (4, 1, N'2023-06-30 00:00:00', N'2023-07-02 00:00:00')
INSERT INTO [dbo].[Opleidingen] ([Id], [OpleidingTypeId], [Startdatum], [Einddatum]) VALUES (5, 3, N'2023-07-14 00:00:00', N'2023-07-16 00:00:00')
INSERT INTO [dbo].[Opleidingen] ([Id], [OpleidingTypeId], [Startdatum], [Einddatum]) VALUES (6, 4, N'2023-07-16 00:00:00', N'2023-07-18 00:00:00')
SET IDENTITY_INSERT [dbo].[Opleidingen] OFF


SET IDENTITY_INSERT [dbo].[GebruikerOpleidingen] ON
INSERT INTO [dbo].[GebruikerOpleidingen] ([Id], [GebruikerId], [OpleidingId]) VALUES (1, 4, 1)
INSERT INTO [dbo].[GebruikerOpleidingen] ([Id], [GebruikerId], [OpleidingId]) VALUES (2, 8, 3)
INSERT INTO [dbo].[GebruikerOpleidingen] ([Id], [GebruikerId], [OpleidingId]) VALUES (3, 7, 4)
SET IDENTITY_INSERT [dbo].[GebruikerOpleidingen] OFF


SET IDENTITY_INSERT [dbo].[Groepsreizen] ON
INSERT INTO [dbo].[Groepsreizen] ([Id], [Naam], [Deelneemprijs], [Thema], [BestemmingId], [Budget], [Startdatum], [Einddatum], [Minimumleeftijd], [Maximumleeftijd], [OverschotBudget], [PlaatsenVrij], [InschrijvingGestopt]) VALUES (1, N'dierenliefde', CAST(450.00 AS Decimal(18, 2)), N'dieren', 1, CAST(65.00 AS Decimal(18, 2)), N'2023-05-26 00:00:00', N'2023-05-29 00:00:00', 14, 16, CAST(5.00 AS Decimal(18, 2)), 1, 0)
INSERT INTO [dbo].[Groepsreizen] ([Id], [Naam], [Deelneemprijs], [Thema], [BestemmingId], [Budget], [Startdatum], [Einddatum], [Minimumleeftijd], [Maximumleeftijd], [OverschotBudget], [PlaatsenVrij], [InschrijvingGestopt]) VALUES (2, N'back to basics', CAST(350.00 AS Decimal(18, 2)), N'natuur-overleven', 2, CAST(70.00 AS Decimal(18, 2)), N'2023-06-23 00:00:00', N'2023-06-25 00:00:00', 15, 17, CAST(10.00 AS Decimal(18, 2)), 1, 0)
INSERT INTO [dbo].[Groepsreizen] ([Id], [Naam], [Deelneemprijs], [Thema], [BestemmingId], [Budget], [Startdatum], [Einddatum], [Minimumleeftijd], [Maximumleeftijd], [OverschotBudget], [PlaatsenVrij], [InschrijvingGestopt]) VALUES (3, N'ski-initiatie', CAST(780.00 AS Decimal(18, 2)), N'ski', 3, CAST(90.00 AS Decimal(18, 2)), N'2023-12-26 00:00:00', N'2023-12-31 00:00:00', 18, 20, NULL, 1, 0)
INSERT INTO [dbo].[Groepsreizen] ([Id], [Naam], [Deelneemprijs], [Thema], [BestemmingId], [Budget], [Startdatum], [Einddatum], [Minimumleeftijd], [Maximumleeftijd], [OverschotBudget], [PlaatsenVrij], [InschrijvingGestopt]) VALUES (4, N'omnisport', CAST(499.00 AS Decimal(18, 2)), N'allerlei sport', 4, CAST(55.00 AS Decimal(18, 2)), N'2023-07-05 00:00:00', N'2023-07-09 00:00:00', 12, 15, NULL, 0, 1)
INSERT INTO [dbo].[Groepsreizen] ([Id], [Naam], [Deelneemprijs], [Thema], [BestemmingId], [Budget], [Startdatum], [Einddatum], [Minimumleeftijd], [Maximumleeftijd], [OverschotBudget], [PlaatsenVrij], [InschrijvingGestopt]) VALUES (5, N'watersport', CAST(600.00 AS Decimal(18, 2)), N'waterrattten', 5, CAST(70.00 AS Decimal(18, 2)), N'2023-08-09 00:00:00', N'2023-08-15 00:00:00', 15, 16, NULL, 1, 0)
INSERT INTO [dbo].[Groepsreizen] ([Id], [Naam], [Deelneemprijs], [Thema], [BestemmingId], [Budget], [Startdatum], [Einddatum], [Minimumleeftijd], [Maximumleeftijd], [OverschotBudget], [PlaatsenVrij], [InschrijvingGestopt]) VALUES (6, N'zeilinitiatie', CAST(550.00 AS Decimal(18, 2)), N'zeil je voor het eerst', 5, CAST(75.00 AS Decimal(18, 2)), N'2023-08-08 00:00:00', N'2023-08-14 00:00:00', 16, 18, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Groepsreizen] OFF


SET IDENTITY_INSERT [dbo].[Inschrijvingen] ON
INSERT INTO [dbo].[Inschrijvingen] ([Id], [Betaald], [GroepsreisId], [GebruikerId]) VALUES (2, 0, 1, 8)
INSERT INTO [dbo].[Inschrijvingen] ([Id], [Betaald], [GroepsreisId], [GebruikerId]) VALUES (3, 1, 2, 12)
INSERT INTO [dbo].[Inschrijvingen] ([Id], [Betaald], [GroepsreisId], [GebruikerId]) VALUES (4, 0, 4, 15)
INSERT INTO [dbo].[Inschrijvingen] ([Id], [Betaald], [GroepsreisId], [GebruikerId]) VALUES (5, 1, 3, 7)
INSERT INTO [dbo].[Inschrijvingen] ([Id], [Betaald], [GroepsreisId], [GebruikerId]) VALUES (6, 0, 6, 4)
SET IDENTITY_INSERT [dbo].[Inschrijvingen] OFF


SET IDENTITY_INSERT [dbo].[Monitors] ON
INSERT INTO [dbo].[Monitors] ([Id], [GroepsreisId], [GebruikerId], [Hoofdmonitor]) VALUES (8, 1, 4, 1)
INSERT INTO [dbo].[Monitors] ([Id], [GroepsreisId], [GebruikerId], [Hoofdmonitor]) VALUES (9, 1, 7, 0)
INSERT INTO [dbo].[Monitors] ([Id], [GroepsreisId], [GebruikerId], [Hoofdmonitor]) VALUES (10, 2, 8, 0)
INSERT INTO [dbo].[Monitors] ([Id], [GroepsreisId], [GebruikerId], [Hoofdmonitor]) VALUES (11, 2, 15, 1)
SET IDENTITY_INSERT [dbo].[Monitors] OFF





