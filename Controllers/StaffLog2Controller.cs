using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using System.Net;
using System.Text;
using SIBLEYBLAYOPERA.Services.StaffLog2Service;


namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffLog2Controller : ControllerBase
    {
        private readonly IStaffLog2Service _staffLog2Service;

        public StaffLog2Controller(IStaffLog2Service staffLog2Service)
        {
            _staffLog2Service = staffLog2Service;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<StaffLog2>>> GetAllLogs()
        {
            return await _staffLog2Service.GetAllLogs();
        }

        [HttpGet("GetSingleLogByFirstName/{FirstName}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByFirstName(string firstname)
        {
            var result = await _staffLog2Service.GetSingleLogByFirstName(firstname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByMiddleName/{MiddleName}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByMiddleName(string middlename)
        {
            var result = await _staffLog2Service.GetSingleLogByMiddleName(middlename);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByLastName/{LastName}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByLastName(string lastname)
        {
            var result = await _staffLog2Service.GetSingleLogByLastName(lastname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByDateOfBirth(string dateofbirth)
        {
            var result = await _staffLog2Service.GetSingleLogByDateOfBirth(dateofbirth);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByAddress/{Address}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByAddress(string address)
        {
            var result = await _staffLog2Service.GetSingleLogByAddress(address);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByDepartment/{Department}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByDepartment(string department)
        {
            var result = await _staffLog2Service.GetSingleLogByDepartment(department);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByTelephone/{Telephone}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByTelephone(int telephone)
        {
            var result = await _staffLog2Service.GetSingleLogByTelephone(telephone);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByRoleTitle(string roletitle)
        {
            var result = await _staffLog2Service.GetSingleLogByRoleTitle(roletitle);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByStaffIDNumber(int staffidnumber)
        {
            var result = await _staffLog2Service.GetSingleLogByStaffIDNumber(staffidnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByContractAgreement(DateTime contractagreement)
        {
            var result = await _staffLog2Service.GetSingleLogByContractAgreement(contractagreement);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var result = await _staffLog2Service.GetSingleLogByContractAgreementExpiration(contractagreementexpiration);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByGrossWage/{GrossWage}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByGrossWage(int grosswage)
        {
            var result = await _staffLog2Service.GetSingleLogByGrossWage(grosswage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNetWage/{NetWage}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByNetWage(int netwage)
        {
            var result = await _staffLog2Service.GetSingleLogByNetWage(netwage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByModeOfPayment(string modeofpayment)
        {
            var result = await _staffLog2Service.GetSingleLogByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByEWageAccountNumber/{EWageAccountnumber}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByEWageAccountNumber(int ewageaccountnumber)
        {
            var result = await _staffLog2Service.GetSingleLogByEWageAccountNumber(ewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNetWageAccounting/{NetWageAccounting}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByNetWageAccounting(DateTime netwageaccounting)
        {
            var result = await _staffLog2Service.GetSingleLogByNetWageAccounting(netwageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityAddress/{SocialSecurityAddress}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogBySocialSecurityAddress(string socialsecurityaddress)
        {
            var result = await _staffLog2Service.GetSingleLogBySocialSecurityAddress(socialsecurityaddress);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityWage/{SocialSecurityWage}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogBySocialSecurityWage(int socialsecuritywage)
        {
            var result = await _staffLog2Service.GetSingleLogBySocialSecurityWage(socialsecuritywage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityModeOfPayment/{SocialSecurityModeOfPayment}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var result = await _staffLog2Service.GetSingleLogBySocialSecurityModeOfPayment(socialsecuritymodeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityEwageAccountNumber/{SocialSecurityEwageAccountNumber}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogBySocialSecurityEwageAccountNumber(int socialsecurityewageaccountnumber)
        {
            var result = await _staffLog2Service.GetSingleLogBySocialSecurityEwageAccountNumber(socialsecurityewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityWageAccounting/{SocialSecurityWageAccounting}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
            var result = await _staffLog2Service.GetSingleLogBySocialSecurityWageAccounting(socialsecuritywageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByVacationDays/{VacationDays}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByVacationDays(int vacationdays)
        {
            var result = await _staffLog2Service.GetSingleLogByVacationDays(vacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNumberOfExhaustedVacationDays/{NumberOfExhaustedVacationDays}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
            var result = await _staffLog2Service.GetSingleLogByNumberOfExhaustedVacationDays(numberofexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNumberOfUnExhaustedVacationDays/{NumberOfUnExhaustedVacationDays}")]
        public async Task<ActionResult<StaffLog2>> GetSingleLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
            var result = await _staffLog2Service.GetSingleLogByNumberOfUnExhaustedVacationDays(numberofunexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPost]
      public async Task<ActionResult<List<StaffLog2>>> AddLog(StaffLog2 log)
        {
            var result = await _staffLog2Service.AddLog(log);
            return Ok(result);
        }

   
        [HttpPut("UpdateLogByFirstName/{FirstName}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByFirstName(string firstname, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByFirstName(firstname, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByMiddleName/{MiddleName}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByMiddleName(string middlename, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByMiddleName(middlename, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByLastName/{LastName}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByLastName(string lastname, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByLastName(lastname, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByDateOfBirth(string dateofbirth, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByDateOfBirth(dateofbirth, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByAddress/{Address}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByAddress(string address, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByAddress(address, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByDepartment/{Department}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByDepartment(string department, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByDepartment(department, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByTelephone/{Telephone}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByTelephone(int telephone, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByTelephone(telephone, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByRoleTitle(string roletitle, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByRoleTitle(roletitle, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByStaffIDNumber(int staffidnumber, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByStaffIDNumber(staffidnumber, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByContractAgreement(DateTime contractagreement, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByContractAgreement(contractagreement, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByContractAgreementExpiration(DateTime contractagreementexpiration, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByContractAgreementExpiration(contractagreementexpiration, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByGrossWage/{GrossWage}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByGrossWage(int grosswage, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByGrossWage(grosswage, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNetWage/{NetWage}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByNetWage(int netwage, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByNetWage(netwage, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByModeOfPayment(string modeofpayment, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByModeOfPayment(modeofpayment, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByEWageAccountNumber/{EWageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByEWageAccountNumber(int ewageaccountnumber, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByEWageAccountNumber(ewageaccountnumber, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNetWageAccounting/{NetWageAccounting}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByNetWageAccounting(DateTime netwageaccounting, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByNetWageAccounting(netwageaccounting, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogSocialSecurityAddress/{SocialSecurityAddress}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogBySocialSecurityAddress(string socialsecurityaddress, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogBySocialSecurityAddress(socialsecurityaddress, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityWage/{SocialSecurityWage}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogBySocialSecurityWage(int socialsecuritywage, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogBySocialSecurityWage(socialsecuritywage, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityModeOfPayment/{SocialSecurityModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogBySocialSecurityModeOfPayment(socialsecuritymodeofpayment, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityEWageAccountNumber/{SocialSecurityEwageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogBySocialSecurityEWageAccountNumber(socialsecurityewageaccountnumber, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityWageAccounting/{SocialSecurityWageAccounting}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogBySocialSecurityWageAccounting(socialsecuritywageaccounting, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByVacationDays/{VactionDays}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByVacationDays(int vacationdays, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByVacationDays(vacationdays, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNumberOfExhaustedVacationDays/{NumberOfExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByNumberOfExhaustedVacationDays(numberofexhaustedvacationdays, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNumberOfUnExhaustedVacationDays/{NumberOfUnExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog2>>> UpdateLogByNumberOfunexhaustedVacationDays(int numberofunexhaustedvacationdays, StaffLog2 request)
        {
            var result = await _staffLog2Service.UpdateLogByNumberOfUnExhaustedVacationDays(numberofunexhaustedvacationdays, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

      
        [HttpDelete("DeleteLogByFirstName/{FirstName}")]
       public async Task<ActionResult<List<StaffLog2>>> DeleteLogByFirstName(string firstname)
        {
            var result = await _staffLog2Service.DeleteLogByFirstName(firstname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteLogByMiddleName/{MiddleName}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByMiddleName(string middlename)
        {
            var result = await _staffLog2Service.DeleteLogByMiddleName(middlename);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByLastName/{LastName}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByLastName(string lastname)
        {
            var result = await _staffLog2Service.DeleteLogByLastName(lastname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByDateOfBirth(string dateofbirth)
        {
            var result = await _staffLog2Service.DeleteLogByDateOfBirth(dateofbirth);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByAddress/{Address}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByAddress(string address)
        {
            var result = await _staffLog2Service.DeleteLogByAddress(address);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByDepartment/{Department}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByDepartment(string department)
        {
            var result = await _staffLog2Service.DeleteLogByDepartment(department);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByTelephone/{Telephone}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByTelephone(int telephone)
        {
            var result = await _staffLog2Service.DeleteLogByTelephone(telephone);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByRoleTitle(string roletitle)
        {
            var result = await _staffLog2Service.DeleteLogByRoleTitle(roletitle);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("DeleteLogByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByStaffIDNumber(int staffidnumber)
        {
            var result = await _staffLog2Service.DeleteLogByStaffIDNumber(staffidnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByContractAgreement(DateTime contractagreement)
        {
            var result = await _staffLog2Service.DeleteLogByContractAgreement(contractagreement);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var result = await _staffLog2Service.DeleteLogByContractAgreementExpiration(contractagreementexpiration);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByGrossWage/{GrossWage}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByGrossWage(int grosswage)
        {
            var result = await _staffLog2Service.DeleteLogByGrossWage(grosswage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNetWage/{NetWage}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByNetWage(int netwage)
        {
            var result = await _staffLog2Service.DeleteLogByNetWage(netwage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByModeOfPayment(string modeofpayment)
        {
            var result = await _staffLog2Service.DeleteLogByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByEWageAccountNumber/{EWageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByEWageAccountNumber(int ewageaccountnumber)
        {
            var result = await _staffLog2Service.DeleteLogByEWageAccountNumber(ewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNetWageAccounting/{NetWageAccounting}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByNetWageAccounting(DateTime netwageaccounting)
        {
            var result = await _staffLog2Service.DeleteLogByNetWageAccounting(netwageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityAddress/{SocialSecurityAddress}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogBySocialSecurityAddress(string socialsecurityaddress)
        {
            var result = await _staffLog2Service.DeleteLogBySocialSecurityAddress(socialsecurityaddress);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityWage/{SocialSecurityWage}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogBySocialSecurityWage(int socialsecuritywage)
        {
            var result = await _staffLog2Service.DeleteLogBySocialSecurityWage(socialsecuritywage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityModeOfPayment/{SocialSecurityModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var result = await _staffLog2Service.DeleteLogBySocialSecurityModeOfPayment(socialsecuritymodeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityEWageAccountNumber/{SocialSecurityEWageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber)
        {
            var result = await _staffLog2Service.DeleteLogBySocialSecurityEWageAccountNumber(socialsecurityewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityWageAccounting/{SocialSecurityWageAccounting}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
            var result = await _staffLog2Service.DeleteLogBySocialSecurityWageAccounting(socialsecuritywageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByVacationDays/{VactionDays}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByVacationDays(int vacationdays)
        {
            var result = await _staffLog2Service.DeleteLogByVacationDays(vacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNumberOfExhaustedVacationDays/{NumberOfExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
            var result = await _staffLog2Service.DeleteLogByNumberOfExhaustedVacationDays(numberofexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNumberOfUnExhaustedVacationDays/{NumberOfUnExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog2>>> DeleteLogByNumberOfunexhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
            var result = await _staffLog2Service.DeleteLogByNumberOfUnExhaustedVacationDays(numberofunexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }
    }
}



