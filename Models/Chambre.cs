using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuideTouristiqueApp.Models
{
    public class Chambre
    {
        [Key]
        public int Id { get; set; }
        public int? Numero { get; set; }

        [Display(Name = "Type of Bedroom like Simple,Couples,Double")]
        public string Type { get; set; }
        public float Prix { get; set; }
        public Hotel hotel { get; set; }

    }
}
