﻿using models.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public partial class Opleiding : BasisKlasse
    {
        public override string ToString()
        {
            return $"{OpleidingType.Naam + " " + Startdatum}";
        }

        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Startdatum" && Startdatum > Einddatum)
                {
                    return "Begindatum moet voor Einddatum.";
                }

                return "";
            }
        }
    }
}
