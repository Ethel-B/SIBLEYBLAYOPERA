global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Migrations;


namespace SIBLEYBLAYOPERA.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost, 1433; Database=SIBLEYBLAYOPERAdb; Trusted_Connection=true; TrustServerCertificate=true;");
        }
        public DbSet<StaffLog1> StaffLog1 { get; set; }
        public DbSet<StaffLog2> StaffLog2 { get; set; }
        public DbSet<Procurements> Procurements { get; set; }
        public DbSet<DepartmentalProcurements> DepartmentalProcurements { get; set; }
        public DbSet<TaxExpendituresLog> TaxExpendituresLog { get; set; }
        public DbSet<Eventslog> EventsLog { get; set; }
        public DbSet<Collaborations> Collaborations { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<RefreshToken> RefreshToken{ get; set; }
    }
}
