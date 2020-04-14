using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ProcesverbaalItem
    {
        [Key]
        public int procesverbaalID { get; set; }
        public string naam { get; set; }
        public string opleiding { get; set; }
        public string studiejaar { get; set; }
        public string credits { get; set; }
        public string eindcijfer { get; set; }
        public string prestatieindicatoren { get; set; }
        public string gewichten { get; set; }
        public string gelegenheid1 { get; set; }
        public string gelegenheid2 { get; set; }
        public string cijfer { get; set; }
        public int moduleID { get; set; }
        public int studentID { get; set; }
    }
}
