using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = " Name must be 10 characters  or less"), MinLength(3)]
        public string Nom { get; set; }

        [MaxLength(8, ErrorMessage = "Year must contain at least 8 numbers")]
        public int Telephone { get; set; }

        [Display(Name = "Type of Restaurant kitchen like traditionnel, fast food, pizzeria")]
        public string typeCuisine { get; set; }

        [Display(Name = "Fresh food Plats")]
        public string FraicheurDePlats { get; set; }
    }
}
