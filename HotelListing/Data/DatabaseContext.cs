using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext 
    {
        // This class represetnts the bridge betwween our defined class and the actual database 
        
        // Our constructor 

        public DatabaseContext(DbContextOptions options): base(options)
        { }

        // We provide the name that the database will use here 

        public DbSet<Country> Countries { get; set; } // The data type as far as C# is concerned is Country

        public DbSet<Hotel> Hotels { get; set; } // The data type as far as C# is concerned is Country

        // We override a method that is already existing on our DatabaseContext in order to seed data into our app 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Jamaica",
                        ShortName = "JM"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Bahamas",
                        ShortName = "BS"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Cayman Island",
                        ShortName = "CS"
                    }
                );

            builder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "Sandals Resort and Spa",
                        Address = "Negril",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Comfort Suites",
                        Address = "Goerge Town",
                        CountryId = 3,
                        Rating = 4.3
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "grand Palldium",
                        Address = "Nassua",
                        CountryId = 2,
                        Rating = 4
                    }
                );
        }

    }
}

