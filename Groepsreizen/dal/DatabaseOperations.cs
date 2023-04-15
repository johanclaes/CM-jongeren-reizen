using Microsoft.EntityFrameworkCore;
using models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public static class DatabaseOperations
    {
        //Gebruikers
        public static List<Gebruiker> OphalenGebruikers()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                var query = grc.Gebruikers.ToList();

                return query;
            }
        }

        public static List<Gebruiker> OphalenGebruikersViaNaam(string naam)
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Gebruikers
                    .Where(x => x.Naam.Contains(naam))
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        public static int VoegGebruikerToe(Gebruiker gebruikerRecord)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Gebruikers.Add(gebruikerRecord);
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int VerwijderGebruiker(Gebruiker gebruiker)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(gebruiker).State = EntityState.Deleted;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateGebruiker(Gebruiker gebruiker)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(gebruiker).State = EntityState.Modified;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static List<Gebruiker> OphalenGebruikersMetMonitorbrevet()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Gebruikers
                    .Where(x => x.Monitorbrevet == true)
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        public static List<Gebruiker> OphalenGebruikersMetHoofdmonitorbrevet()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Gebruikers
                    .Where(x => x.Hoofdmonitorbrevet == true)
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        public static List<Gebruiker> OphalenGebruikersWebadmins()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Gebruikers
                    .Where(x => x.Webadmin == true)
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        //Inschrijvingen
        public static int VoegInschrijvingToe(Inschrijving inschrijvingRecord)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Inschrijvingen.Add(inschrijvingRecord);
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int VerwijderInschrijving(Inschrijving inschrijving)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(inschrijving).State = EntityState.Deleted;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateInschrijving(Inschrijving inschrijving)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(inschrijving).State = EntityState.Modified;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //Groepsreizen
        public static List<Groepsreis> OphalenGroepsreizen()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                var query = grc.Groepsreizen.ToList();

                return query;
            }
        }

        public static List<Groepsreis> OphalenGroepsreizenViaNaam(string naam)
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Groepsreizen
                    .Where(x => x.Naam.Contains(naam))
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        public static int VoegGroepsreisToe(Groepsreis groepsreisRecord)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Groepsreizen.Add(groepsreisRecord);
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int VerwijderGroepsreis(Groepsreis groepsreis)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(groepsreis).State = EntityState.Deleted;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateGroepsreis(Groepsreis groepsreis)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(groepsreis).State = EntityState.Modified;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //Opleidingen
        public static List<Opleiding> OphalenOpleidingen()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                var query = grc.Opleidingen.ToList();

                return query;
            }
        }

        public static int VoegOpleidingToe(Opleiding opleidingRecord)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Opleidingen.Add(opleidingRecord);
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //Bestemmingen
        public static List<Bestemming> OphalenBestemmingen()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                var query = grc.Bestemmingen.ToList();

                return query;
            }
        }

        public static List<Bestemming> OphalenBestemmingenViaNaam(string naam)
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Bestemmingen
                    .Where(x => x.Naam.Contains(naam))
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        public static List<Bestemming> OphalenBestemmingenViaBestemmingstype(int bestemmingstypeId)
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Bestemmingen
                    .Where(x => x.BestemmingstypeId == bestemmingstypeId)
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        public static List<Bestemming> OphalenBestemmingenViaLand(string land)
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                return grc.Bestemmingen
                    .Where(x => x.Land == land)
                    .OrderBy(x => x.Naam)
                    .ToList();
            }
        }

        public static int VoegBestemmingToe(Bestemming bestemmingRecord)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Bestemmingen.Add(bestemmingRecord);
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int VerwijderBestemming(Bestemming bestemming)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(bestemming).State = EntityState.Deleted;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int UpdateBestemming(Bestemming bestemming)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Entry(bestemming).State = EntityState.Modified;
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //Bestemmingstypes
        public static List<Bestemmingstype> OphalenBestemmingstypes()
        {
            using (GroepsreizenContext grc = new GroepsreizenContext())
            {
                var query = grc.Bestemmingentypes.ToList();

                return query;
            }
        }

        public static int VoegBestemmingstypeToe(Bestemmingstype bestemmingstype)
        {
            try
            {
                using GroepsreizenContext grc = new();
                grc.Bestemmingentypes.Add(bestemmingstype);
                return grc.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
