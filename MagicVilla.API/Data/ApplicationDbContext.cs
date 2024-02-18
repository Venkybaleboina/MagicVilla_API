using MagicVilla.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal villa",
                    Details = "This is royal villa",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 100,
                    sqrt = 400,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Pool villa",
                    Details = "This is royal villa",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 300,
                    sqrt = 700,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Royal Palace villa",
                    Details = "This is royal villa",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    sqrt = 500,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                });
        }
    }
}
