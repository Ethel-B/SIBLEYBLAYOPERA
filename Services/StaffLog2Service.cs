using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using SIBLEYBLAYOPERA.Services.StaffLog2Service;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.StaffLog2Service
{
    public class StaffLog2Service : IStaffLog2Service
    {
        private readonly DataContext _context;

        public StaffLog2Service(DataContext context)
        {
            _context = context;
        }

        public async Task<List<StaffLog2>> GetAllLogs()
        {
            var logs = await _context.StaffLog2.ToListAsync();
            return logs;
        }

        public async Task<StaffLog2> GetSingleLogByFirstName(string firstname)
        {
            var log = await _context.StaffLog2.FindAsync(firstname);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByMiddleName(string middlename)
        {
            var log = await _context.StaffLog2.FindAsync(middlename);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByLastName(string lastname)
        {
            var log = await _context.StaffLog2.FindAsync(lastname);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByDateOfBirth(string dateofbirth)
        {
            var log = await _context.StaffLog2.FindAsync(dateofbirth);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByAddress(string address)
        {
            var log = await _context.StaffLog2.FindAsync(address);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByDepartment(string department)
        {
            var log = await _context.StaffLog2.FindAsync(department);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByTelephone(int telephone)
        {
            var log = await _context.StaffLog2.FindAsync(telephone);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByRoleTitle(string roletitle)
        {
            var log = await _context.StaffLog2.FindAsync(roletitle);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByStaffIDNumber(int staffidnumber)
        {
            var log = await _context.StaffLog2.FindAsync(staffidnumber);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByContractAgreement(DateTime contractagreement)
        {
            var log = await _context.StaffLog2.FindAsync(contractagreement);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var log = await _context.StaffLog2.FindAsync(contractagreementexpiration);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByGrossWage(int grosswage)
        {
            var log = await _context.StaffLog2.FindAsync(grosswage);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByNetWage(int netwage)
        {
            var log = await _context.StaffLog2.FindAsync(netwage);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByModeOfPayment(string modeofpayment)
        {
            var log = await _context.StaffLog2.FindAsync(modeofpayment);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByEWageAccountNumber(int ewageaccountnumber)
        {
            var log = await _context.StaffLog2.FindAsync(ewageaccountnumber);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingeLogByNetWageAccounting(DateTime netwageaccounting)
        {
            var log = await _context.StaffLog2.FindAsync(netwageaccounting);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogBySocialSecurityAddress(string socialsecurityaddress)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecurityaddress);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogBySocialSecurityWage(int socialsecuritywage)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritywage);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritymodeofpayment);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogBySocialSecurityEwageAccountNumber(int socialsecurityewageaccountnumber)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecurityewageaccountnumber);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritywageaccounting);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByVacationDays(int vacationdays)
        {
            var log = await _context.StaffLog2.FindAsync(vacationdays);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
            var log = await _context.StaffLog2.FindAsync(numberofexhaustedvacationdays);
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog2> GetSingleLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
            var log = await _context.StaffLog2.FindAsync(numberofunexhaustedvacationdays);
            if (log is null)
                return null;

            return log;
        }

        public async Task<ActionResult<List<StaffLog2>>>AddLog(StaffLog2 log)
        {
            _context.StaffLog2.Add(log);
            await _context.SaveChangesAsync();
            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByFirstName(string firstname, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(firstname);
            if (log is null)
                return null;

            log.FirstName = request.FirstName;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByMiddleName(string middlename, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(middlename);
            if (log is null)
                return null;

            log.MiddleName = request.MiddleName;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByLastName(string lastname, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(lastname);
            if (log is null)
                return null;

            log.LastName = request.LastName;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByDateOfBirth(string dateofbirth, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(dateofbirth);
            if (log is null)
                return null;

            log.DateOfBirth = request.DateOfBirth;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByAddress(string address, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(address);
            if (log is null)
                return null;

            log.Address = request.Address;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByDepartment(string department, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(department);
            if (log is null)
                return null;

            log.Department = request.Department;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByTelephone(int telephone, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(telephone);
            if (log is null)
                return null;

            log.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByRoleTitle(string roletitle, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(roletitle);
            if (log is null)
                return null;

            log.RoleTitle = request.RoleTitle;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByStaffIDNumber(int staffidnumber, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(staffidnumber);
            if (log is null)
                return null;

            log.StaffIDNumber = request.StaffIDNumber;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByContractAgreement(DateTime contractagreement, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(contractagreement);
            if (log is null)
                return null;

            log.ContractAgreement = request.ContractAgreement;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByContractAgreementExpiration(DateTime contractagreementexpiration, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(contractagreementexpiration);
            if (log is null)
                return null;

            log.ContractAgreementExpiration = request.ContractAgreementExpiration;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByGrossWage(int grosswage, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(grosswage);
            if (log is null)
                return null;

            log.GrossWage = request.GrossWage;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByNetWage(int netwage, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(netwage);
            if (log is null)
                return null;

            log.NetWage = request.NetWage;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByModeOfPayment(string modeofpayment, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(modeofpayment);
            if (log is null)
                return null;

            log.ModeOfPayment = request.ModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByEWageAccountNumber(int ewageaccountnumber, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(ewageaccountnumber);
            if (log is null)
                return null;

            log.EWageAccountNumber = request.EWageAccountNumber;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByNetWageAccounting(DateTime netwageaccounting, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(netwageaccounting);
            if (log is null)
                return null;

            log.NetWageAccounting = request.NetWageAccounting;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogBySocialSecurityAddress(string socialsecurityaddress, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecurityaddress);
            if (log is null)
                return null;

            log.SocialSecurityAddress = request.SocialSecurityAddress;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }


        public async Task<List<StaffLog2>> UpdateLogBySocialSecurityWage(int socialsecuritywage, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritywage);
            if (log is null)
                return null;

            log.SocialSecurityWage = request.SocialSecurityWage;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritymodeofpayment);
            if (log is null)
                return null;

            log.SocialSecurityModeOfPayment = request.SocialSecurityModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecurityewageaccountnumber);
            if (log is null)
                return null;

            log.SocialSecurityEWageAccountNumber = request.SocialSecurityEWageAccountNumber;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritywageaccounting);
            if (log is null)
                return null;

            log.SocialSecurityWageAccounting = request.SocialSecurityWageAccounting;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByVacationDays(int vacationdays, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(vacationdays);
            if (log is null)
                return null;

            log.VacationDays = request.VacationDays;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(numberofexhaustedvacationdays);
            if (log is null)
                return null;

            log.NumberOfExhaustedVacationDays = request.NumberOfExhaustedVacationDays;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> UpdateLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays, StaffLog2 request)
        {
            var log = await _context.StaffLog2.FindAsync(numberofunexhaustedvacationdays);
            if (log is null)
                return null;

            log.NumberOfUnExhaustedVacationDays = request.NumberOfUnExhaustedVacationDays;
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByFirstName(string firstname)
        {
            var log = await _context.StaffLog2.FindAsync(firstname);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();

        }

        public async Task<List<StaffLog2>> DeleteLogByMiddleName(string middlename)
        {
            var log = await _context.StaffLog2.FindAsync(middlename);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByLastName(string lastname)
        {
            var log = await _context.StaffLog2.FindAsync(lastname);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByDateOfBirth(string dateofbirth)
        {
            var log = await _context.StaffLog2.FindAsync(dateofbirth);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByAddress(string address)
        {
            var log = await _context.StaffLog2.FindAsync(address);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByDepartment(string department)
        {
            var log = await _context.StaffLog2.FindAsync(department);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByTelephone(int telephone)
        {
            var log = await _context.StaffLog2.FindAsync(telephone);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByRoleTitle(string roletitle)
        {
            var log = await _context.StaffLog2.FindAsync(roletitle);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByStaffIDNumber(int staffidnumber)
        {
            var log = await _context.StaffLog2.FindAsync(staffidnumber);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByContractAgreement(DateTime contractagreement)
        {
            var log = await _context.StaffLog2.FindAsync(contractagreement);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var log = await _context.StaffLog2.FindAsync(contractagreementexpiration);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByGrossWage(int grosswage)
        {
            var log = await _context.StaffLog2.FindAsync(grosswage);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByNetWage(int netwage)
        {
            var log = await _context.StaffLog2.FindAsync(netwage);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByModeOfPayment(string modeofpayment)
        {
            var log = await _context.StaffLog2.FindAsync(modeofpayment);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByEWageAccountNumber(int ewageaccountnumber)
        {
            var log = await _context.StaffLog2.FindAsync(ewageaccountnumber);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByNetWageAccounting(DateTime netwageaccounting)
        {
            var log = await _context.StaffLog2.FindAsync(netwageaccounting);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogBySocialSecurityAddress(string socialsecurityaddress)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecurityaddress);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }


        public async Task<List<StaffLog2>> DeleteLogBySocialSecurityWage(int socialsecuritywage)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritywage);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritymodeofpayment);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecurityewageaccountnumber);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
            var log = await _context.StaffLog2.FindAsync(socialsecuritywageaccounting);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByVacationDays(int vacationdays)
        {
            var log = await _context.StaffLog2.FindAsync(vacationdays);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
            var log = await _context.StaffLog1.FindAsync(numberofexhaustedvacationdays);
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }

        public async Task<List<StaffLog2>> DeleteLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
            var log = await _context.StaffLog2.FindAsync(numberofunexhaustedvacationdays);
            if (log is null)
                return null;

            _context.StaffLog2.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog2.ToListAsync();
        }
    }
}




