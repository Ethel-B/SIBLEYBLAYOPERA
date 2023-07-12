using Microsoft.EntityFrameworkCore;

namespace SIBLEYBLAYOPERA.Models
{
    // A collaborations log that houses the details of any collaboration, that the Opera will engage itself in.
    
    public class Collaborations
    {
        public int id { get; set; }

        public int? UsersId { get; set; }

        public Users Users { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string DateOfBirth { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

       public int Telephone { get; set; }

        public string RoleStatus { get; set; } = string.Empty;

        public DateTime ContractAgreement { get; set; }

        public string ContractDetails { get; set; } = string.Empty;

        public DateTime ContractAgreementExpiration { get; set; }

        public int AgreedContractPayment { get; set; }

        public DateTime AgreedPayment { get; set; }

        public int HonouredContractPayment1 { get; set; }

        public int HonouredContractPayment2 { get; set; }

        public int UnHonouredContractPayment1 { get; set; }

        public int UnHonouredContractPayment2 { get; set; }

        public DateTime HonouredPayment1 { get; set; }

        public DateTime HonouredPayment2 { get; set; }

        public DateTime UnHonouredPayment1 { get; set; }

        public DateTime UnHonouredPayment2 { get; set; }

        public string ModeOfPayment { get; set; } = string.Empty;

        public int EContractPaymentAccountNumber { get; set; }

        public String ContractPaymentAddress { get; set; } = string.Empty;

    }
}
    
