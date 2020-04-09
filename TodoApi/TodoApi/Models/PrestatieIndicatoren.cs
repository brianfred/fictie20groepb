using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PrestatieIndicatoren.Models
{
    public class PrestatieIndicatorenItem
    {
        [Key]
        public int prestatieindicatorID { get; set; }
        public string prestatieindicator { get; set; }
        public string omschrijving { get; set; }
        public string gewicht { get; set; }
        public string toetsvorm { get; set; }
        public string toetsmoment { get; set; }
        public string product { get; set; }
        public string toetsaspecten { get; set; }
        public string toetsduur { get; set; }
        public int moduleID { get; set; }
    }
}
