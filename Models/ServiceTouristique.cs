using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class ServiceTouristique
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = " Name must be 10 characters  or less"), MinLength(3)]
        public string Nom { get; set; }

        [Display(Name = "Description of Touristic Service")]
        public string Description { get; set; }
        public Localisation localisation { get; set; }
        public ICollection<Offre> offres { get; set; }

    }
}
