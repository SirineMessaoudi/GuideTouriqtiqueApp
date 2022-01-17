using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Activite
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = " Name of activity must be 15 characters  or less"), MinLength(2)]
        public string Nom { get; set; }

        [Display(Name = "Genre of activity like Sport,Musicly,traditionnel,sahara..")]
        public string Genre { get; set; }
        public float Prix { get; set; }
        public SiteTouristique site { get; set; }
    }
}
