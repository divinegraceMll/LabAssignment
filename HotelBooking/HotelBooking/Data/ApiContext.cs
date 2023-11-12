using HotelBooking.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HotelBooking.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBookingg> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API configuration for HotelBookingg entity
            modelBuilder.Entity<HotelBookingg>()
                .ToTable("Bookings") // Set the table name
                .HasKey(b => b.Id); // Set the primary key

            modelBuilder.Entity<HotelBookingg>()
                .Property(b => b.RoomNumber)
                .HasColumnName("RoomNumber"); // Map RoomNumber property to the corresponding column

            modelBuilder.Entity<HotelBookingg>()
                .Property(b => b.ClientName)
                .HasColumnName("ClientName"); // Map ClientName property to the corresponding column

            // Add additional configurations as needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
