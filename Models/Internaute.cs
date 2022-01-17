using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Internaute
    {
        [Key]
        public int Id { get; set; }

        public int? Note { get; set; }
        public string Commentaire { get; set; }
        public ServiceTouristique service { get; set; }
    }
}
