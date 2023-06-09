﻿using models.Partials;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public partial class Monitor : BasisKlasse
    {
        public override string ToString()
        {
            return $"{Gebruiker.Voornaam} {Gebruiker.Naam}";
        }

        public override string this[string columnName]
        {
            get
            {
                if (columnName == "GroepsreisId" && GroepsreisId <= 0)
                {
                    return "Naam moet ingevuld zijn.";
                }
                if (columnName == "GebruikerId" && GebruikerId <= 0)
                {
                    return "Land mag niet leeg zijn.";
                }

                return "";
            }
        }
    }
}
