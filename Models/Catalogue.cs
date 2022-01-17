using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Catalogue
    {
        [Key]
        public int Id { get; set; }

        public ICollection<ServiceTouristique> services { get; set; }
    }
}
