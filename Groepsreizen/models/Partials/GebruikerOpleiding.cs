﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public partial class GebruikerOpleiding
    {
        public override string ToString()
        {
            return $"{Gebruiker.Voornaam} {Gebruiker.Naam}";
        }
    }
}
