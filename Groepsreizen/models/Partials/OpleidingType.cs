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

                return "";
            }
        }
    }
}
