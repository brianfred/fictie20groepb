using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ActiviteitenroosterItem
    {
        [Key]
        public int activiteitenRoosterID { get; set; }
        public string naam { get; set; }
        public string week1form { get; set; }
        public string week1sum { get; set; }
        public string week2form { get; set; }
        public string week2sum { get; set; }
        public string week3form { get; set; }
        public string week3sum { get; set; }
        public string week4form { get; set; }
        public string week4sum { get; set; }
        public string week5form { get; set; }
        public string week5sum { get; set; }
        public string week6form { get; set; }
        public string week6sum { get; set; }
        public string week7form { get; set; }
        public string week7sum { get; set; }
        public string week8form { get; set; }
        public string week8sum { get; set; }
        public string week9form { get; set; }
        public string week9sum { get; set; }
        public string week10form { get; set; }
        public string week10sum { get; set; }
    }
}
