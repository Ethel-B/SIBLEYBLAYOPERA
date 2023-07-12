namespace SIBLEYBLAYOPERA.Models
{
    //Event Log Management for the Opera.

    public class Eventslog
    {
        public int id { get; set; }

        public int? UsersId { get; set; }

        public Users Users { get; set; }

        public string EventName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string RolePerformers { get; set; } = string.Empty;

        public string NameOfRolePerformer { get; set; } = string.Empty;

        public string TitleOfRolePerformer { get; set; } = string.Empty;

        public DateTime EventDetails { get; set; }

        public int AudienceSeatingCapacity { get; set; }

        public int ExpectedAudienceSeatingNo { get; set; }

        public int UnExpectedAudienceSeatingNo { get; set; }

        public int EventPrice { get; set; }

       public int TotalMonthlyExpenditure { get; set; }

        public int TotalYearlyExpenditure { get; set; }

    }
}
    
