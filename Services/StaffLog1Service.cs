using System;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Services;
using Microsoft.EntityFrameworkCore;
using SIBLEYBLAYOPERA.Services.StaffLog1Service;
using System.Net;
using System.Text;

namespace SIBLEYBLAYOPERA.Services.StaffLog1Service
{
    public class StaffLog1Service : IStaffLog1Service
    {
        private readonly DataContext _context;

        public StaffLog1Service(DataContext context)
        {
            _context = context;
        }

        public async Task<List<StaffLog1>> GetAllLogs()
        {
            var logs = await _context.StaffLog1.ToListAsync();
            return logs;
        }

        public async Task<StaffLog1?> GetSingleLogByFirstName(string firstname)
        {
           var log = await _context.StaffLog1.Where(l => l.FirstName == firstname).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1?> GetSingleLogByMiddleName(string middlename)
        {
            var log = await _context.StaffLog1.Where(l => l.MiddleName == middlename).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByLastName(string lastname)
        {
             var log = await _context.StaffLog1.Where(l => l.LastName == lastname).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByDateOfBirth(string dateofbirth)
        {
          var log = await _context.StaffLog1.Where(l => l.DateOfBirth == dateofbirth).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByAddress(string address)
        {
            var log = await _context.StaffLog1.Where(l => l.Address == address).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByDepartment(string department)
        {
          var log = await _context.StaffLog1.Where(l => l.Department == department).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByTelephone(int telephone)
        {
             var log = await _context.StaffLog1.Where(l => l.Telephone == telephone).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByRoleTitle(string roletitle)
        {
             var log = await _context.StaffLog1.Where(l => l.RoleTitle == roletitle).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByStaffIDNumber(int staffidnumber)
        {
          var log = await _context.StaffLog1.Where(l => l.StaffIDNumber == staffidnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByContractAgreement(DateTime contractagreement)
        {
            var log = await _context.StaffLog1.Where(l => l.ContractAgreement == contractagreement).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
             var log = await _context.StaffLog1.Where(l => l.ContractAgreementExpiration == contractagreementexpiration).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByGrossWage(int grosswage)
        {
            var log = await _context.StaffLog1.Where(l => l.GrossWage == grosswage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByNetWage(int netwage)
        {
            var log = await _context.StaffLog1.Where(l => l.NetWage == netwage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByModeOfPayment(string modeofpayment)
        {
            var log = await _context.StaffLog1.Where(l => l.ModeOfPayment == modeofpayment).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByEWageAccountNumber(int ewageaccountnumber)
        {
            var log = await _context.StaffLog1.Where(l => l.EWageAccountNumber == ewageaccountnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByNetWageAccounting(DateTime netwageaccounting)
        {
          var log = await _context.StaffLog1.Where(l => l.NetWageAccounting == netwageaccounting).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogBySocialSecurityAddress(string socialsecurityaddress)
        {
            var log = await _context.StaffLog1.Where(l => l.SocialSecurityAddress == socialsecurityaddress).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogBySocialSecurityWage(int socialsecuritywage)
        {
            var log = await _context.StaffLog1.Where(l => l.SocialSecurityWage == socialsecuritywage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var log = await _context.StaffLog1.Where(l => l.SocialSecurityModeOfPayment == socialsecuritymodeofpayment).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogBySocialSecurityEwageAccountNumber(int socialsecurityewageaccountnumber)
        {
            var log = await _context.StaffLog1.Where(l => l.SocialSecurityEWageAccountNumber == socialsecurityewageaccountnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
            var log = await _context.StaffLog1.Where(l => l.SocialSecurityWageAccounting == socialsecuritywageaccounting).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByVacationDays(int vacationdays)
        {
            var log = await _context.StaffLog1.Where(l => l.VacationDays == vacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
          var log = await _context.StaffLog1.Where(l => l.NumberOfExhaustedVacationDays == numberofexhaustedvacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<StaffLog1> GetSingleLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
            var log = await _context.StaffLog1.Where(l => l.NumberOfUnExhaustedVacationDays == numberofunexhaustedvacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            return log;
        }

        public async Task<ActionResult<List<StaffLog1>>> AddLog(StaffLog1 log)
        {
            _context.StaffLog1.Add(log);
            await _context.SaveChangesAsync();
            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByFirstName(string firstname, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.FirstName == firstname).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.FirstName = request.FirstName;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByMiddleName(string middlename, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.MiddleName == middlename).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.MiddleName = request.MiddleName;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByLastName(string lastname, StaffLog1 request)
        {
            var log = await _context.StaffLog1.Where(l => l.LastName == lastname).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.LastName = request.LastName;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByDateOfBirth(string dateofbirth, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.DateOfBirth == dateofbirth).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.DateOfBirth = request.DateOfBirth;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByAddress(string address, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.Address == address).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.Address = request.Address;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByDepartment(string department, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.Department == department).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.Department = request.Department;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByTelephone(int telephone, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.Telephone == telephone).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByRoleTitle(string roletitle, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.RoleTitle == roletitle).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.RoleTitle = request.RoleTitle;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByStaffIDNumber(int staffidnumber, StaffLog1 request)
        {
            var log = await _context.StaffLog1.Where(l => l.StaffIDNumber == staffidnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.StaffIDNumber = request.StaffIDNumber;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByContractAgreement(DateTime contractagreement, StaffLog1 request)
        {
            var log = await _context.StaffLog1.Where(l => l.ContractAgreement == contractagreement).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.ContractAgreement = request.ContractAgreement;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByContractAgreementExpiration(DateTime contractagreementexpiration, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.ContractAgreementExpiration ==contractagreementexpiration ).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.ContractAgreementExpiration = request.ContractAgreementExpiration;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByGrossWage(int grosswage, StaffLog1 request)
        {
            var log = await _context.StaffLog1.Where(l => l.GrossWage == grosswage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.GrossWage = request.GrossWage;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByNetWage(int netwage, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.NetWage == netwage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.NetWage = request.NetWage;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByModeOfPayment(string modeofpayment, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.ModeOfPayment == modeofpayment).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.ModeOfPayment = request.ModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByEWageAccountNumber(int ewageaccountnumber, StaffLog1 request)
        {
            var log = await _context.StaffLog1.Where(l => l.EWageAccountNumber == ewageaccountnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.EWageAccountNumber = request.EWageAccountNumber;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByNetWageAccounting(DateTime netwageaccounting, StaffLog1 request)
        {
            var log = await _context.StaffLog1.Where(l => l.NetWageAccounting == netwageaccounting).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.NetWageAccounting = request.NetWageAccounting;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogBySocialSecurityAddress(string socialsecurityaddress, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.SocialSecurityAddress == socialsecurityaddress).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.SocialSecurityAddress = request.SocialSecurityAddress;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }


        public async Task<List<StaffLog1>> UpdateLogBySocialSecurityWage(int socialsecuritywage, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.SocialSecurityWage == socialsecuritywage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.SocialSecurityWage = request.SocialSecurityWage;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.SocialSecurityModeOfPayment == socialsecuritymodeofpayment).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.SocialSecurityModeOfPayment = request.SocialSecurityModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.SocialSecurityEWageAccountNumber == socialsecurityewageaccountnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.SocialSecurityEWageAccountNumber = request.SocialSecurityEWageAccountNumber;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.SocialSecurityWageAccounting == socialsecuritywageaccounting).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.SocialSecurityWageAccounting = request.SocialSecurityWageAccounting;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByVacationDays(int vacationdays, StaffLog1 request)
        {
            var log = await _context.StaffLog1.Where(l => l.VacationDays == vacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.VacationDays = request.VacationDays;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.NumberOfExhaustedVacationDays == numberofexhaustedvacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.NumberOfExhaustedVacationDays = request.NumberOfExhaustedVacationDays;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> UpdateLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays, StaffLog1 request)
        {
             var log = await _context.StaffLog1.Where(l => l.NumberOfUnExhaustedVacationDays == numberofunexhaustedvacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            log.NumberOfUnExhaustedVacationDays = request.NumberOfUnExhaustedVacationDays;
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByFirstName(string firstname)
        {
            var log = await _context.StaffLog1.Where(l => l.FirstName == firstname).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();

        }

        public async Task<List<StaffLog1>> DeleteLogByMiddleName(string middlename)
        {
             var log = await _context.StaffLog1.Where(l => l.MiddleName == middlename).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByLastName(string lastname)
        {
             var log = await _context.StaffLog1.Where(l => l.LastName == lastname).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByDateOfBirth(string dateofbirth)
        {
            var log = await _context.StaffLog1.Where(l => l.DateOfBirth == dateofbirth).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByAddress(string address)
        {
           var log = await _context.StaffLog1.Where(l => l.Address == address).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByDepartment(string department)
        {
           var log = await _context.StaffLog1.Where(l => l.Department == department).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByTelephone(int telephone)
        {
           var log = await _context.StaffLog1.Where(l => l.Telephone == telephone).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByRoleTitle(string roletitle)
        {
            var log = await _context.StaffLog1.Where(l => l.RoleTitle == roletitle).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByStaffIDNumber(int staffidnumber)
        {
            var log = await _context.StaffLog1.Where(l => l.StaffIDNumber == staffidnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByContractAgreement(DateTime contractagreement)
        {
             var log = await _context.StaffLog1.Where(l => l.ContractAgreement == contractagreement).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
             var log = await _context.StaffLog1.Where(l => l.ContractAgreementExpiration == contractagreementexpiration).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByGrossWage(int grosswage)
        {
            var log = await _context.StaffLog1.Where(l => l.GrossWage == grosswage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByNetWage(int netwage)
        {
             var log = await _context.StaffLog1.Where(l => l.NetWage == netwage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByModeOfPayment(string modeofpayment)
        {
            var log = await _context.StaffLog1.Where(l => l.ModeOfPayment == modeofpayment).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByEWageAccountNumber(int ewageaccountnumber)
        {
          var log = await _context.StaffLog1.Where(l => l.EWageAccountNumber == ewageaccountnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByNetWageAccounting(DateTime netwageaccounting)
        {
           var log = await _context.StaffLog1.Where(l => l.NetWageAccounting == netwageaccounting).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogBySocialSecurityAddress(string socialsecurityaddress)
        {
          var log = await _context.StaffLog1.Where(l => l.SocialSecurityAddress == socialsecurityaddress).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }


        public async Task<List<StaffLog1>> DeleteLogBySocialSecurityWage(int socialsecuritywage)
        {
           var log = await _context.StaffLog1.Where(l => l.SocialSecurityWage == socialsecuritywage).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogBySocialSecurityModeOfPayment(string socialsecuritymodeofpayment)
        {
            var log = await _context.StaffLog1.Where(l => l.SocialSecurityModeOfPayment == socialsecuritymodeofpayment).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogBySocialSecurityEWageAccountNumber(int socialsecurityewageaccountnumber)
        {
             var log = await _context.StaffLog1.Where(l => l.SocialSecurityEWageAccountNumber == socialsecurityewageaccountnumber).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogBySocialSecurityWageAccounting(DateTime socialsecuritywageaccounting)
        {
        var log = await _context.StaffLog1.Where(l => l.SocialSecurityWageAccounting == socialsecuritywageaccounting).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByVacationDays(int vacationdays)
        {
          var log = await _context.StaffLog1.Where(l => l.VacationDays == vacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByNumberOfExhaustedVacationDays(int numberofexhaustedvacationdays)
        {
            var log = await _context.StaffLog1.Where(l => l.NumberOfExhaustedVacationDays == numberofexhaustedvacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }

        public async Task<List<StaffLog1>> DeleteLogByNumberOfUnExhaustedVacationDays(int numberofunexhaustedvacationdays)
        {
             var log = await _context.StaffLog1.Where(l => l.NumberOfUnExhaustedVacationDays == numberofunexhaustedvacationdays).FirstOrDefaultAsync();
            if (log is null)
                return null;

            _context.StaffLog1.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.StaffLog1.ToListAsync();
        }
    }
}


