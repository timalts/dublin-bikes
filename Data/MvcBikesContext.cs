using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dublin_bikes.Data
{
    public class MvcBikesController : DbContext
    {
        public MvcBikesController(DbContextOptions<MvcBikesController> options) : base(options)
        {

        }

        public DbSet<Bikes> Bikes { get; set; }

    }
}
