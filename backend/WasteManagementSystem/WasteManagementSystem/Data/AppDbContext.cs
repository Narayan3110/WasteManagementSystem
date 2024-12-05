using System.Data.Entity;
using WasteManagementSystem.Models;

namespace WasteManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<WasteRequest> WasteRequests { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
