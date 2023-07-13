using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.StaffLog1Service
{
    public interface IStaffLog1Service
    {
        public Task<List<StaffLog1>> GetAllLogs();

        public Task<StaffLog1?> GetSingleLogByFirstName(string firstname);

        public Task<StaffLog1?> GetSingleLogByMiddleName(string middlename);

        public Task<StaffLog1> GetSingleLogByLastName(string lastname);

        public Task<StaffLog1> GetSingleLogByDateOfBirth(string dateofbirth);

        public Task<StaffLog1> GetSingleLogByAddress(string address);

        public Task<StaffLog1> GetSingleLogByDepartment(string department);

        public Task<StaffLog1> GetSingleLogByTelephone(int telephone);

        public Task<StaffLog1> GetSingleLogByRoleTitle(string roletitle);

        public Task<StaffLog1> GetSingleLogByStaffIDNumber(int staffidnumber);

        public Task<StaffLog1> GetSingleLogByContractAgreement(DateTime contractagreement);

        public Task<StaffLog1> GetSingleLogByContractAgreementExpiration(DateTime contractagreementexpiration);

        public Task<StaffLog1> GetSingleLogByGrossWage(int grosswage);

        public Task<StaffLog1> GetSingleLogByNetWage(int netwage);

        public Task<StaffLog1> GetSingleLogByModeOfPayment(string modeofpayment);

        public Task<StaffLog1> GetSingleLogByEWageAccountNumber(int ewageaccountnumber);

        public Task<StaffLog1> GetSingleLogByNetWageAccounting(DateTime netwageaccounting);

        public Task<StaffLog1> GetSingleLogBySocialSecurityAddress(string socialsecurityaddress);

        public Task<StaffLog1> GetSingleLogBySocialSecurityWage(int socialsecuritywage);

        public Task<StaffLog1> GetSingleLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment);

        public Task<StaffLog1> GetSingleLogBySocialSecurityEwageAccountNumber(int socialsecurityewageaccountnumber);

        public Task<StaffLog1> GetSingleLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting);

        public Task<StaffLog1> GetSingleLogByVacationDays(int vacationdays);

        public Task<StaffLog1> GetSingleLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays);

        public Task<StaffLog1> GetSingleLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays);

        public Task<ActionResult<List<StaffLog1>>> AddLog(StaffLog1 log);

        public Task<List<StaffLog1>> UpdateLogByFirstName(string firstname, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByMiddleName(string middlename, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByLastName(string lastname, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByDateOfBirth(string dateofbirth, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByAddress(string address, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByDepartment(string department, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByTelephone(int telephone, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByRoleTitle(string roletitle, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByStaffIDNumber(int staffidnumber, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByContractAgreement(DateTime contractagreement, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByContractAgreementExpiration(DateTime contractagreementexpiration, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByGrossWage(int grosswage, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByNetWage(int netwage, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByModeOfPayment(string modeofpayment, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByEWageAccountNumber(int ewageaccountnumber, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByNetWageAccounting(DateTime netwageaccounting, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogBySocialSecurityAddress(string socialsecurityaddress, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogBySocialSecurityWage(int socialsecuritywage, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByVacationDays(int vactiondays, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays, StaffLog1 request);

        public Task<List<StaffLog1>> UpdateLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays, StaffLog1 request);

        public Task<List<StaffLog1>> DeleteLogByFirstName(string firstname);

        public Task<List<StaffLog1>> DeleteLogByMiddleName(string middlename);

        public Task<List<StaffLog1>> DeleteLogByLastName(string lastname);

        public Task<List<StaffLog1>> DeleteLogByDateOfBirth(string dateofbirth);

        public Task<List<StaffLog1>> DeleteLogByAddress(string address);

        public Task<List<StaffLog1>> DeleteLogByDepartment(string department);

        public Task<List<StaffLog1>> DeleteLogByTelephone(int telephone);

        public Task<List<StaffLog1>> DeleteLogByRoleTitle(string roletitle);

        public Task<List<StaffLog1>> DeleteLogByStaffIDNumber(int staffidnumber);

        public Task<List<StaffLog1>> DeleteLogByContractAgreement(DateTime contractagreement);

        public Task<List<StaffLog1>> DeleteLogByContractAgreementExpiration(DateTime contractagreementexpiration);

        public Task<List<StaffLog1>> DeleteLogByGrossWage(int grosswage);

        public Task<List<StaffLog1>> DeleteLogByNetWage(int netwage);

        public Task<List<StaffLog1>> DeleteLogByModeOfPayment(string modeofpayment);

        public Task<List<StaffLog1>> DeleteLogByEWageAccountNumber(int ewageaccountnumber);

        public Task<List<StaffLog1>> DeleteLogByNetWageAccounting(DateTime netwageaccounting);

        public Task<List<StaffLog1>> DeleteLogBySocialSecurityAddress(string socialsecurityaddress);

        public Task<List<StaffLog1>> DeleteLogBySocialSecurityWage(int socialsecuritywage);

        public Task<List<StaffLog1>> DeleteLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment);

        public Task<List<StaffLog1>> DeleteLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber);

        public Task<List<StaffLog1>> DeleteLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting);

        public Task<List<StaffLog1>> DeleteLogByVacationDays(int vactiondays);

        public Task<List<StaffLog1>> DeleteLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays);

        public Task<List<StaffLog1>> DeleteLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays);
    }
}
   
