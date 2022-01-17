using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " Name must be 10 characters  or less"), MinLength(3)]
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int NombreEtoile { get; set; }

        public ICollection<Chambre> chambres { get; set; }

        [Display(Name = "Evalueted on quality of bedrooms and calme")]
        public string Qualite { get; set; }
        public Bus bus { get; set; }

        public Restaurant restaurant { get; set; }


    }
}
