using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ModuleItem
    {
        [Key]
        public int moduleID { get; set; }
        public string Naam { get; set; }
        public string opleiding { get; set; }
        public string studiejaar { get; set; }
        public string fase { get; set; }
        public string credits { get; set; }
        public string ingangseisen { get; set; }
        public string voorkennis { get; set; }
        public string examinator { get; set; }
        public string context { get; set; }
        public string competenties { get; set; }
        public string beroepstaken { get; set; }
        public string algemeneKwalificaties { get; set; }
        public string onderwerpen { get; set; }
        public string lesmateriaal { get; set; }
        public string werkvormen { get; set; }
        public string toetsvormen { get; set; }
        public string toetsprotocol { get; set; }
        public string rekenmodel { get; set; }
        public string gelegenheid1 { get; set; }
        public string gelegenheid2 { get; set; }
        public int activiteitenRoosterID { get; set; }
    }
}
