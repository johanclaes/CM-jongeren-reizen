using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.Partials;

namespace models
{
    public partial class OpleidingType : BasisKlasse
    {
        public override string ToString()
        {
            return Naam;
        }

        public override string this[string columnName]
        {
            get
            {
                if (columnName == "Naam" && string.IsNullOrWhiteSpace(Naam))
                {
                    return "Opleidingstype moet ingevuld zijn.";
                }

                if (columnName == "Naam" && Naam.Length <= 3)
                {
                    return "Het opleidingstype moet minstens 3 karakters bevatten.";
                }

                return "";
            }
        }
    }
}
