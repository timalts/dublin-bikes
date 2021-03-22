using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dublin_bikes.Data;

namespace dublin_bikes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBikesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBikesContext>>()))
            {
                // Look for any bikes.
                if (context.Bikes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bikes.AddRange(
                    new Bikes
                    {
                        Number = 1,
                        Name = "Emeric",
                        Address = "Mayor street lower",
                        Latitude = 56,
                        Longitude = 23,
                        Banking = true,
                        Available_bikes = 15,
                        Avaible_stand = 15,
                        Capacity = 30,
                        Status = "open"
                    },

                    new Bikes
                    {
                        Number = 2,
                        Name = "Titi",
                        Address = "8 folks street",
                        Latitude = 48,
                        Longitude = 69,
                        Banking = true,
                        Available_bikes = 12,
                        Avaible_stand = 18,
                        Capacity = 30,
                        Status = "open"
                    },

                    new Bikes
                    {
                        Number = 3,
                        Name = "Pierre-Louis",
                        Address = "Greet street",
                        Latitude = 62,
                        Longitude = 76,
                        Banking = true,
                        Available_bikes = 18,
                        Avaible_stand = 12,
                        Capacity = 30,
                        Status = "open"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
