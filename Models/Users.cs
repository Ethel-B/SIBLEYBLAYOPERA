namespace SIBLEYBLAYOPERA.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public List<StaffLog1> StaffLog1 { get; set; }

        public List<StaffLog2> StaffLog2 { get; set; }

        public List<Collaborations> Collaborations { get; set; }

        public List<Bookings> Bookings { get; set; }

        public List<DepartmentalProcurements> DepartmentalProcurements { get; set; }

        public List<Eventslog> Eventslog { get; set; }

        public List<Procurements> Procurements { get; set; }

        public List<TaxExpendituresLog> TaxExpendituresLog { get; set; }

        public string RefreshToken { get; set; }

        public DateTime TokenCreated { get; set; }

        public DateTime TokenExpires { get; set; }
 }
}
    
