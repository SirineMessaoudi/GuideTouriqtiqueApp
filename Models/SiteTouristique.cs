using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class SiteTouristique
    {
        [Key]
        public int Id { get; set; }

       [Required]
        [StringLength(10, ErrorMessage=" Name must be 10 characters  or less"), MinLength(3)]
        public string Nom { get; set; }

        [StringLength(10,ErrorMessage ="Year must contain at least 3 numbers"),MinLength(3)]
        public string Anciennete { get; set; }
        public ICollection<Activite> activites { get; set; }
        public Bus bus { get; set; }

        public Restaurant restaurant { get; set; }
    }
}
