using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dublin_bikes.Models;

namespace dublin_bikes.Data
{
    public class MvcBikesContext : DbContext
    {
        public MvcBikesContext(DbContextOptions<MvcBikesContext> options) : base(options)
        {

        }

        public DbSet<Bikes> Bikes { get; set; }

    }
}
