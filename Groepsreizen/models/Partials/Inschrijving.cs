using models.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public partial class Inschrijving : BasisKlasse
    {
        public override string ToString()
        {
            string betaald = Betaald ? "Reeds betaald" : "Niet betaald";
            return $"{Gebruiker.Voornaam} {Gebruiker.Naam} - {Groepsreis.Naam} {Groepsreis.Bestemming.Gemeente} - {Groepsreis.Startdatum.ToShortDateString()} tot {Groepsreis.Einddatum.ToShortDateString()} - {betaald}";
        }

        public override string this[string columnName]
        {
            get
            {
                if (columnName == "GebruikerId" && GebruikerId <= 0)
                {
                    return "Naam moet ingevuld zijn.";
                }
                if (columnName == "GroepsreisId" && GroepsreisId <= 0)
                {
                    return "Deelnemerprijs moet ingevuld zijn.";
                }

                return "";
            }
        }
    }
}
