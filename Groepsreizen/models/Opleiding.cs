using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    [Table("Opleidingen")]
    public partial class Opleiding
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        //Navigatieproperties
        public List<GebruikerOpleiding> GebruikerOpleidingen { get; set; }
    }
}
