using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.StaffLog2Service
{
    public interface IStaffLog2Service
    {
        public Task<List<StaffLog2>> GetAllLogs();

        public Task<StaffLog2> GetSingleLogByFirstName(string firstname);

        public Task<StaffLog2> GetSingleLogByMiddleName(string middlename);

        public Task<StaffLog2> GetSingleLogByLastName(string lastname);

        public Task<StaffLog2> GetSingleLogByDateOfBirth(string dateofbirth);

        public Task<StaffLog2> GetSingleLogByAddress(string address);

        public Task<StaffLog2> GetSingleLogByDepartment(string department);

        public Task<StaffLog2> GetSingleLog(int telephone);

        public Task<StaffLog2> GetSingleLogByRoleTitle(string roletitle);

        public Task<StaffLog2> GetSingleLogByStaffIDNumber(string staffidnumber);

        public Task<StaffLog2> GetSingleLogByContractAgreement(DateTime contractagreement);

        public Task<StaffLog2> GetSingleLogByContractAgreementExpiration(DateTime contractagreementexpiration);

        public Task<StaffLog2> GetSingleLogByGrossWage(int grosswage);

        public Task<StaffLog2> GetSingleLogByNetWage(int netwage);

        public Task<StaffLog2> GetSingleLog(string modeofpayment);

        public Task<StaffLog2> GetSingleLogByEWageAccountNumber(int ewageaccountnumber);

        public Task<StaffLog2> GetSingleLog(DateTime netwageaccounting);

        public Task<StaffLog2> GetSingleLogBySocialSecurityAddress(string socialsecurityaddress);

        public Task<StaffLog2> GetSingleLogBySocialSecurityWage(int socialsecuritywage);

        public Task<StaffLog2> GetSingleLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment);

        public Task<StaffLog2> GetSingleLogBySocialSecurityEwageAccountNumber(int socialsecurityewageaccountnumber);

        public Task<StaffLog2> GetSingleLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting);

        public Task<StaffLog2> GetSingleLogByVacationDays(int vacationdays);

        public Task<StaffLog2> GetSingleLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays);

        public Task<StaffLog2> GetSingleLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays);

        public Task<ActionResult<List<StaffLog2>>> AddLog(StaffLog2 log);

        public Task<List<StaffLog2>> UpdateLogByFirstName(string firstname, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByMiddleName(string middlename, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByLastName(string lastname, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByDateOfBirth(string dateofbirth, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByAddress(string address, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByDepartment(string department, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByTelephone(int telephone, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByRoleTitle(string roletitle, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByStaffIDNumber(int staffidnumber, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByContractAgreement(DateTime contractagreement, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByContractAgreementExpiration(DateTime contractagreementexpiration, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByGrossWage(int grosswage, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByNetWage(int netwage, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByModeOfPayment(string modeofpayment, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByEWageAccountNumber(int ewageaccountnumber, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByNetWageAccounting(DateTime netwageaccounting, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogBySocialSecurityAddress(string socialsecurityaddress, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogBySocialSecurityWage(int socialsecuritywage, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByVacationDays(int vactiondays, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays, StaffLog2 request);

        public Task<List<StaffLog2>> UpdateLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays, StaffLog2 request);

        public Task<List<StaffLog2>> DeleteLogByFirstName(string firstname);

        public Task<List<StaffLog2>> DeleteLogByMiddleName(string middlename);

        public Task<List<StaffLog2>> DeleteLogByLastName(string lastname);

        public Task<List<StaffLog2>> DeleteLogByDateOfBirth(string dateofbirth);

        public Task<List<StaffLog2>> DeleteLogByAddress(string address);

        public Task<List<StaffLog2>> DeleteLogByDepartment(string department);

        public Task<List<StaffLog2>> DeleteLogByTelephone(int telephone);

        public Task<List<StaffLog2>> DeleteLogByRoleTitle(string roletitle);

        public Task<List<StaffLog2>> DeleteLogByStaffIDNumber(int staffidnumber);

        public Task<List<StaffLog2>> DeleteLogByContractAgreement(DateTime contractagreement);

        public Task<List<StaffLog2>> DeleteLogByContractAgreementExpiration(DateTime contractagreementexpiration);

        public Task<List<StaffLog2>> DeleteLogByGrossWage(int grosswage);

        public Task<List<StaffLog2>> DeleteLogByNetWage(int netwage);

        public Task<List<StaffLog2>> DeleteLogByModeOfPayment(string modeofpayment);

        public Task<List<StaffLog2>> DeleteLogByEWageAccountNumber(int ewageaccountnumber);

        public Task<List<StaffLog2>> DeleteLogByNetWageAccounting(DateTime netwageaccounting);

        public Task<List<StaffLog2>> DeleteLogBySocialSecurityAddress(string socialsecurityaddress);

        public Task<List<StaffLog2>> DeleteLogBySocialSecurityWage(int socialsecuritywage);

        public Task<List<StaffLog2>> DeleteLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment);

        public Task<List<StaffLog2>> DeleteLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber);

        public Task<List<StaffLog2>> DeleteLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting);

        public Task<List<StaffLog2>> DeleteLogByVacationDays(int vactiondays);

        public Task<List<StaffLog2>> DeleteLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays);

        public Task<List<StaffLog2>> DeleteLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays);
    }
}


