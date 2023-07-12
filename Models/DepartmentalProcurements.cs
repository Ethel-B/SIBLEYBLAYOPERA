using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Models
{
    //A Departmental Procurements Log for the Opera.

    public class DepartmentalProcurements
    {
        public int Id { get; set; }

        public int? UsersId { get; set; }

        public Users Users { get; set; }

        public string Firstname { get; set; } = string.Empty;

        public string Middlename { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public string RoleTitle { get; set; } = string.Empty;
      
        public int StaffIDNumber { get; set; }

        public string Department { get; set; } = string.Empty;

        public string Item { get; set; } = string.Empty;

        public int OrderQuantity { get; set; }

        public int PresentQuantity { get; set; }

        public int AbsentQuantity { get; set; }

        public string ProcurementCenter { get; set; } = string.Empty;

        public int Telephone { get; set; }

        public string Address { get; set; } = string.Empty;

        public int MonthlyPlacementOrderQuantity { get; set; }

        public int YearlyPlacementOrderQuantity { get; set; }

        public DateTime DateOfPlacementOrder { get; set; }

        public DateTime TargetedDeliveryDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string ArrivalLocation { get; set; } = string.Empty;
    }
}
