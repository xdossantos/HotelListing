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

    }
}

