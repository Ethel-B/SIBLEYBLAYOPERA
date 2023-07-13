using System;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using SIBLEYBLAYOPERA.Services.StaffLog1Service;
using System.Net;
using System.Text;


namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffLog1Controller : ControllerBase
    {
        private readonly IStaffLog1Service _staffLog1Service;

        public StaffLog1Controller(IStaffLog1Service staffLog1Service)
        {
            _staffLog1Service = staffLog1Service;
        }

     
        [HttpGet]
        public async Task<ActionResult<List<StaffLog1>>> GetAllLogs()
        {
            return await _staffLog1Service.GetAllLogs();
        }

        [HttpGet("GetSingleLogByFirstName/{FirstName}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByFirstName(string firstname)
        {
            var result = await _staffLog1Service.GetSingleLogByFirstName(firstname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByMiddleName/{MiddleName}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByMiddleName(string middlename)
        {
            var result = await _staffLog1Service.GetSingleLogByMiddleName(middlename);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByLastName/{LastName}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByLastName(string lastname)
        {
            var result = await _staffLog1Service.GetSingleLogByLastName(lastname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByDateOfBirth(string dateofbirth)
        {
            var result = await _staffLog1Service.GetSingleLogByDateOfBirth(dateofbirth);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByAddress/{Address}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByAddress(string address)
        {
            var result = await _staffLog1Service.GetSingleLogByAddress(address);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByDepartment/{Department}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByDepartment(string department)
        {
            var result = await _staffLog1Service.GetSingleLogByDepartment(department);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByTelephone/{Telephone}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByTelephone(int telephone)
        {
            var result = await _staffLog1Service.GetSingleLogByTelephone(telephone);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByRoleTitle(string roletitle)
        {
            var result = await _staffLog1Service.GetSingleLogByRoleTitle(roletitle);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByStaffIDNumber(int staffidnumber)
        {
            var result = await _staffLog1Service.GetSingleLogByStaffIDNumber(staffidnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByContractAgreement(DateTime contractagreement)
        {
            var result = await _staffLog1Service.GetSingleLogByContractAgreement(contractagreement);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var result = await _staffLog1Service.GetSingleLogByContractAgreementExpiration(contractagreementexpiration);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByGrossWage/{GrossWage}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByGrossWage(int grosswage)
        {
            var result = await _staffLog1Service.GetSingleLogByGrossWage(grosswage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNetWage/{NetWage}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByNetWage(int netwage)
        {
            var result = await _staffLog1Service.GetSingleLogByNetWage(netwage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByModeOfPayment(string modeofpayment)
        {
            var result = await _staffLog1Service.GetSingleLogByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByEWageAccountNumber/{EWageAccountnumber}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByEWageAccountNumber(int ewageaccountnumber)
        {
            var result = await _staffLog1Service.GetSingleLogByEWageAccountNumber(ewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNetWageAccounting/{NetWageAccounting}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByNetWageAccounting(DateTime netwageaccounting)
        {
            var result = await _staffLog1Service.GetSingleLogByNetWageAccounting(netwageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityAddress/{SocialSecurityAddress}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogBySocialSecurityAddress(string socialsecurityaddress)
        {
            var result = await _staffLog1Service.GetSingleLogBySocialSecurityAddress(socialsecurityaddress);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLoggBySocialSecurityWage/{SocialSecurityWage}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogBySocialSecurityWage(int socialsecuritywage)
        {
            var result = await _staffLog1Service.GetSingleLogBySocialSecurityWage(socialsecuritywage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityModeOfPayment/{SocialSecurityModeOfPayment}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var result = await _staffLog1Service.GetSingleLogBySocialSecurityModeOfPayment(socialsecuritymodeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityEwageAccountNumber/{SocialSecurityEwageAccountNumber}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogBySocialSecurityEwageAccountNumber(int socialsecurityewageaccountnumber)
        {
            var result = await _staffLog1Service.GetSingleLogBySocialSecurityEwageAccountNumber(socialsecurityewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogBySocialSecurityWageAccounting/{SocialSecurityWageAccounting}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
            var result = await _staffLog1Service.GetSingleLogBySocialSecurityWageAccounting(socialsecuritywageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByVacationDays/{VacationDays}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByVacationDays(int vacationdays)
        {
            var result = await _staffLog1Service.GetSingleLogByVacationDays(vacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNumberOfExhaustedVacationDays/{NumberOfExhaustedVacationDays}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
            var result = await _staffLog1Service.GetSingleLogByNumberOfExhaustedVacationDays(numberofexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNumberOfUnExhaustedVacationDays/{NumberOfUnExhaustedVacationDays}")]
        public async Task<ActionResult<StaffLog1>> GetSingleLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
            var result = await _staffLog1Service.GetSingleLogByNumberOfUnExhaustedVacationDays(numberofunexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        
       [HttpPost]
       public async Task<ActionResult<List<StaffLog1>>> AddLog(StaffLog1 log)
        {
            var result = await _staffLog1Service.AddLog(log);
            return Ok(result);
        }

   
        [HttpPut("UpdateLogByFirstName/{FirstName}")]
       public async Task<ActionResult<List<StaffLog1>>> UpdateLogByFirstName(string firstname, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByFirstName(firstname, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByMiddleName/{MiddleName}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByMiddleName(string middlename, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByMiddleName(middlename, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByLastName/{LastName}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByLastName(string lastname, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByLastName(lastname, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByDateOfBirth(string dateofbirth, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByDateOfBirth(dateofbirth, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByAddress/{Address}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByAddress(string address, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByAddress(address, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByDepartment/{Department}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByDepartment(string department, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByDepartment(department, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByTelephone/{Telephone}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByTelephone(int telephone, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByTelephone(telephone, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByRoleTitle(string roletitle, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByRoleTitle(roletitle, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByStaffIDNumber(int staffidnumber, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByStaffIDNumber(staffidnumber, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByContractAgreement(DateTime contractagreement, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByContractAgreement(contractagreement, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByContractAgreementExpiration(DateTime contractagreementexpiration, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByContractAgreementExpiration(contractagreementexpiration, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByGrossWage/{GrossWage}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByGrossWage(int grosswage, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByGrossWage(grosswage, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNetWage/{NetWage}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByNetWage(int netwage, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByNetWage(netwage, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByModeOfPayment(string modeofpayment, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByModeOfPayment(modeofpayment, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByEWageAccountNumber/{EWageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByEWageAccountNumber(int ewageaccountnumber, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByEWageAccountNumber(ewageaccountnumber, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNetWageAccounting/{NetWageAccounting}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByNetWageAccounting(DateTime netwageaccounting, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByNetWageAccounting(netwageaccounting, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityAddress/{SocialSecurityAddress}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogBySocialSecurityAddress(string socialsecurityaddress, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogBySocialSecurityAddress(socialsecurityaddress, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityWage/{SocialSecurityWage}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogBySocialSecurityWage(int socialsecuritywage, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogBySocialSecurityWage(socialsecuritywage, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogSocialSecurityModeOfPayment/{SocialSecurityModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogBySocialSecurityModeOfPayment(socialsecuritymodeofpayment, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityEWageAccountNumber/{SocialSecurityEWageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogBySocialSecurityEWageAccountNumber(socialsecurityewageaccountnumber, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogBySocialSecurityWageAccounting/{SocialSecurityWageAccounting}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogBySocialSecurityWageAccounting(socialsecuritywageaccounting, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByVacationDays/{VactionDays}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByVacationDays(int vacationdays, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByVacationDays(vacationdays, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNumberOfExhaustedVacationDays/{NumberOfExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByNumberOfExhaustedVacationDays(numberofexhaustedvacationdays, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNumberOfUnExhaustedVacationDays/{NumberOfUnExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog1>>> UpdateLogByNumberOfunexhaustedVacationDays(int numberofunexhaustedvacationdays, StaffLog1 request)
        {
            var result = await _staffLog1Service.UpdateLogByNumberOfUnExhaustedVacationDays(numberofunexhaustedvacationdays, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByFirstName/{FirstName}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByFirstName(string firstname)
        {
            var result = await _staffLog1Service.DeleteLogByFirstName(firstname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);

        }

       
        [HttpDelete("DeleteLogByMiddleName/{MiddleName}")]
       public async Task<ActionResult<List<StaffLog1>>> DeleteLogByMiddleName(string middlename)
        {
            var result = await _staffLog1Service.DeleteLogByMiddleName(middlename);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByLastName/{LastName}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByLastName(string lastname)
        {
            var result = await _staffLog1Service.DeleteLogByLastName(lastname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByDateOfBirth(string dateofbirth)
        {
            var result = await _staffLog1Service.DeleteLogByDateOfBirth(dateofbirth);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByAddress/{Address}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByAddress(string address)
        {
            var result = await _staffLog1Service.DeleteLogByAddress(address);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByDepartment/{Department}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByDepartment(string department)
        {
            var result = await _staffLog1Service.DeleteLogByDepartment(department);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByTelephone/{Telephone}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByTelephone(int telephone)
        {
            var result = await _staffLog1Service.DeleteLogByTelephone(telephone);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByRoleTitle(string roletitle)
        {
            var result = await _staffLog1Service.DeleteLogByRoleTitle(roletitle);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByStaffIDNumber(int staffidnumber)
        {
            var result = await _staffLog1Service.DeleteLogByStaffIDNumber(staffidnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByContractAgreement(DateTime contractagreement)
        {
            var result = await _staffLog1Service.DeleteLogByContractAgreement(contractagreement);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var result = await _staffLog1Service.DeleteLogByContractAgreementExpiration(contractagreementexpiration);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByGrossWage/{GrossWage}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByGrossWage(int grosswage)
        {
            var result = await _staffLog1Service.DeleteLogByGrossWage(grosswage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNetWage/{NetWage}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByNetWage(int netwage)
        {
            var result = await _staffLog1Service.DeleteLogByNetWage(netwage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByModeOfPayment(string modeofpayment)
        {
            var result = await _staffLog1Service.DeleteLogByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByEWageAccountNumber/{EWageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByEWageAccountNumber(int ewageaccountnumber)
        {
            var result = await _staffLog1Service.DeleteLogByEWageAccountNumber(ewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNetWageAccounting/{NetWageAccounting}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByNetWageAccounting(DateTime netwageaccounting)
        {
            var result = await _staffLog1Service.DeleteLogByNetWageAccounting(netwageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityAddress/{SocialSecurityAddress}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogBySocialSecurityAddress(string socialsecurityaddress)
        {
            var result = await _staffLog1Service.DeleteLogBySocialSecurityAddress(socialsecurityaddress);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityWage/{SocialSecurityWage}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogBySocialSecurityWage(int socialsecuritywage)
        {
            var result = await _staffLog1Service.DeleteLogBySocialSecurityWage(socialsecuritywage);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityModeOfPayment/{SocialSecurityModeOfPayment}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var result = await _staffLog1Service.DeleteLogBySocialSecurityModeOfPayment(socialsecuritymodeofpayment);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityEWageAccountNumber/{SocialSecurityEWageAccountNumber}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber)
        {
            var result = await _staffLog1Service.DeleteLogBySocialSecurityEWageAccountNumber(socialsecurityewageaccountnumber);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogBySocialSecurityWageAccounting/{SocialSecurityWageAccounting}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
            var result = await _staffLog1Service.DeleteLogBySocialSecurityWageAccounting(socialsecuritywageaccounting);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByVacationDays/{VactionDays}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByVacationDays(int vacationdays)
        {
            var result = await _staffLog1Service.DeleteLogByVacationDays(vacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNumberOfExhaustedVacationDays/{NumberOfExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
            var result = await _staffLog1Service.DeleteLogByNumberOfExhaustedVacationDays(numberofexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogNumberOfUnExhaustedVacationDays/{NumberOfUnExhaustedVacationDays}")]
        public async Task<ActionResult<List<StaffLog1>>> DeleteLogByNumberOfunexhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
            var result = await _staffLog1Service.DeleteLogByNumberOfUnExhaustedVacationDays(numberofunexhaustedvacationdays);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }
    }
}