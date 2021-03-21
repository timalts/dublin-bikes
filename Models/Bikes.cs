using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListings.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [Required]
        public int number {get;set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Adress { get; set; }

        [Required]
        public float Latitude {get; set; }

        [Required]
        public float Longitude {get; set; }
    }
}