namespace SIBLEYBLAYOPERA.Models
{
    //StaffLog for the stage personnel of the opera.

    public class StaffLog1
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

            public string RoleTitle { get; set; } = string.Empty;

            public int StaffIDNumber { get; set; }

            public DateTime ContractAgreement { get; set; }

            public DateTime ContractAgreementExpiration { get; set; }

            public int GrossWage { get; set; }

            public int NetWage { get; set; }

            public string ModeOfPayment { get; set; } = string.Empty;
            //ModeOfPayment For NetWage

            public int EWageAccountNumber { get; set; }
            //digital account address

            public DateTime NetWageAccounting { get; set; }

            public String SocialSecurityAddress { get; set; } = string.Empty;

            public int SocialSecurityWage { get; set; }

            public string SocialSecurityModeOfPayment { get; set; } = string.Empty;

            public int SocialSecurityEWageAccountNumber { get; set; }
            //SocialSecurity digital account address

            public DateTime SocialSecurityWageAccounting { get; set; }

            public int VacationDays { get; set; }

            public int NumberOfExhaustedVacationDays { get; set; }

            public int NumberOfUnExhaustedVacationDays { get; set; }
        }
    }

