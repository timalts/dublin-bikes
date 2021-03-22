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
        public float Latitude {get; set; }

        [Required]
        public float Longitude {get; set; }

        [Required]
        public bool Banking { get; set; }

        [Required]
        public int Available_bikes { get; set; }

        [Required]
        public int Avaible_stand { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Status { get; set; }
    }
}