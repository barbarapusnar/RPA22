using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VajaCodeFirst.Models
{
    public class Izpit
    {
        public int Id { get; set; }
        
        public DateTime Datum { get; set; }
        public int StudentID { get; set; }
        public int PredmetID { get; set; }
        public int Ocena { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }    
    }
}