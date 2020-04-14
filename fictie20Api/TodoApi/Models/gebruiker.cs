using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class gebruikerItem
    {
        [Key]
        public int ID { get; set; }
        public string gebruikersnaam { get; set; }
        public string wachtwoord { get; set; }
        public string rol { get; set; }

    }
}
