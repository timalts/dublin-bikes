using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dublin_bikes.Models
{
    public class Bikes
    {

        public int Id { get; set; }

        [Required]
        public int Number {get;set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^-?[0-8]?\d(?:\.\d*)?|-?90(?:\.0+)?$")]
        public float Latitude {get; set; }

        [Required]
        [RegularExpression(@"^-?[0-8]?\d(?:\.\d*)?|-?90(?:\.0+)?$")]
        public float Longitude {get; set; }

        [Required]
        public bool Banking { get; set; }

        [Required]
        [Range(1, 50)]
        public int Available_bikes { get; set; }

        [Required]
        [Range(1, 50)]
        public int Avaible_stand { get; set; }

        [Required]
        [Range(1, 50)]
        public int Capacity { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Status { get; set; }
    }
}