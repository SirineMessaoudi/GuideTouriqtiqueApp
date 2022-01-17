using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Offre
    {
        [Key]
        public int Id { get; set; }
        public int NbrePersonne { get; set; }
        public float Prix { get; set; }

        [Display(Name = "Description of offre")]
        public string Descriptif { get; set; }
       // public ICollection<ServiceTouristique> services { get; set; }
    }
}
