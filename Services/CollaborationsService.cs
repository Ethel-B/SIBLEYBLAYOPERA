using System;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Services;
using SIBLEYBLAYOPERA.Services.CollaborationsService;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;


namespace SIBLEYBLAYOPERA.Services.CollaborationsService
{
    public class CollaborationsService : ICollaborationsService
    {
        private readonly DataContext _context;

        public CollaborationsService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Collaborations>> GetAllCollabos()
        {
            var collabos = await _context.Collaborations.ToListAsync();
            return collabos;
        }

        public async Task<Collaborations> GetSingleCollaboByFirstName(string firstname)
        {
            var collabo = await _context.Collaborations.FindAsync(firstname);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByMiddleName(string middlename)
        {
            var collabo = await _context.Collaborations.FindAsync(middlename);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByLastName(string lastname)
        {
            var collabo = await _context.Collaborations.FindAsync(lastname);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByDateOfBirth(string dateofbirth)
        {
            var collabo = await _context.Collaborations.FindAsync(dateofbirth);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByAddress(string address)
        {
            var collabo = await _context.Collaborations.FindAsync(address);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByDepartment(string department)
        {
            var collabo = await _context.Collaborations.FindAsync(department);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByTelephone(int telephone)
        {
            var collabo = await _context.Collaborations.FindAsync(telephone);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByRoleStatus(string rolestatus)
        {
            var collabo = await _context.Collaborations.FindAsync(rolestatus);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByContractAgreement(DateTime contractagreement)
        {
            var collabo = await _context.Collaborations.FindAsync(contractagreement);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByContractDetails(string contractdetails)
        {
            var collabo = await _context.Collaborations.FindAsync(contractdetails);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var collabo = await _context.Collaborations.FindAsync(contractagreementexpiration);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByAgreedContractPayment(int agreedcontractpayment)
        {
            var collabo = await _context.Collaborations.FindAsync(agreedcontractpayment);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByAgreedPayment(DateTime agreedpayment)
        {
            var collabo = await _context.Collaborations.FindAsync(agreedpayment);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByHonouredContractPayment1(int honouredcontractpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredcontractpayment1);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByHonouredContractPayment2(int honouredcontractpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredcontractpayment2);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredcontractpayment1);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredcontractpayment2);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByHonouredPayment1(DateTime honouredpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredpayment1);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByHonouredPayment2(DateTime honouredpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredpayment2);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByUnHonouredPayment1(DateTime unhonouredpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredpayment1);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByUnHonouredPayment2(DateTime unhonouredpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredpayment2);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByModeOfPayment(string modeofpayment)
        {
            var collabo = await _context.Collaborations.FindAsync(modeofpayment);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber)
        {
            var collabo = await _context.Collaborations.FindAsync(econtractpaymentaccountnumber);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<Collaborations> GetSingleCollaboByContractPaymentAddress(string contractpaymentaddress)
        {
            var collabo = await _context.Collaborations.FindAsync(contractpaymentaddress);
            if (collabo is null)
                return null;

            return collabo;
        }

        public async Task<ActionResult<List<Collaborations>>> AddCollaborations(Collaborations collaborations)
        {
            _context.Collaborations.Add(collaborations);
            await _context.SaveChangesAsync();
            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByFirstName(string firstname, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(firstname);
            if (collabo is null)
                return null;

            collabo.FirstName = request.FirstName;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByMiddleName(string middlename, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(middlename);
            if (collabo is null)
                return null;

            collabo.MiddleName = request.MiddleName;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByLastName(string lastname, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(lastname);
            if (collabo is null)
                return null;

            collabo.LastName = request.LastName;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByDateOfBirth(string dateofbirth, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(dateofbirth);
            if (collabo is null)
                return null;

            collabo.DateOfBirth = request.DateOfBirth;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByAddress(string address, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(address);
            if (collabo is null)
                return null;

            collabo.Address = request.Address;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByDepartment(string department, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(department);
            if (collabo is null)
                return null;

            collabo.Department = request.Department;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByTelephone(int telephone, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(telephone);
            if (collabo is null)
                return null;

            collabo.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByRoleStatus(string rolestatus, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(rolestatus);
            if (collabo is null)
                return null;

            collabo.RoleStatus = request.RoleStatus;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByContractAgreement(DateTime contractagreement, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(contractagreement);
            if (collabo is null)
                return null;

            collabo.ContractAgreement = request.ContractAgreement;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByContractDetails(string contractdetails, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(contractdetails);
            if (collabo is null)
                return null;

            collabo.ContractDetails = request.ContractDetails;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByContractAgreementExpiration(DateTime contractagreementexpiration, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(contractagreementexpiration);
            if (collabo is null)
                return null;

            collabo.ContractAgreementExpiration = request.ContractAgreementExpiration;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByAgreedContractPayment(int agreedcontractpayment, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(agreedcontractpayment);
            if (collabo is null)
                return null;

            collabo.AgreedContractPayment = request.AgreedContractPayment;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByAgreedPayment(DateTime agreedpayment, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(agreedpayment);
            if (collabo is null)
                return null;

            collabo.AgreedPayment = request.AgreedPayment;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByHonouredContractPayment1(int honouredcontractpayment1, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredcontractpayment1);
            if (collabo is null)
                return null;

            collabo.HonouredContractPayment1 = request.HonouredContractPayment1;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByHonouredContractPayment2(int honouredcontractpayment2, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredcontractpayment2);
            if (collabo is null)
                return null;

            collabo.HonouredContractPayment2 = request.HonouredContractPayment2;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredcontractpayment1);
            if (collabo is null)
                return null;

            collabo.UnHonouredContractPayment1 = request.UnHonouredContractPayment1;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredcontractpayment2);
            if (collabo is null)
                return null;

            collabo.UnHonouredContractPayment2 = request.UnHonouredContractPayment2;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByHonouredPayment1(DateTime honouredpayment1, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredpayment1);
            if (collabo is null)
                return null;

            collabo.HonouredPayment1 = request.HonouredPayment1;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByHonouredPayment2(DateTime honouredpayment2, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredpayment2);
            if (collabo is null)
                return null;

            collabo.HonouredPayment2 = request.HonouredPayment2;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByUnHonouredPayment1(DateTime unhonouredpayment1, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredpayment1);
            if (collabo is null)
                return null;

            collabo.UnHonouredPayment1 = request.UnHonouredPayment1;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByUnHonouredPayment2(DateTime unhonouredpayment2, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredpayment2);
            if (collabo is null)
                return null;

            collabo.UnHonouredPayment2 = request.UnHonouredPayment2;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByModeOfPayment(string modeofpayment, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(modeofpayment);
            if (collabo is null)
                return null;

            collabo.ModeOfPayment = request.ModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(econtractpaymentaccountnumber);
            if (collabo is null)
                return null;

            collabo.EContractPaymentAccountNumber = request.EContractPaymentAccountNumber;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> UpdateCollaboByContractPaymentAddress(string contractpaymentaddress, Collaborations request)
        {
            var collabo = await _context.Collaborations.FindAsync(contractpaymentaddress);
            if (collabo is null)
                return null;

            collabo.ContractPaymentAddress = request.ContractPaymentAddress;
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

        public async Task<List<Collaborations>> DeleteCollaboByFirstName(string firstname)
        {
            var collabo = await _context.Collaborations.FindAsync(firstname);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByMiddleName(string middlename)
        {
            var collabo = await _context.Collaborations.FindAsync(middlename);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByLastName(string lastname)
        {
            var collabo = await _context.Collaborations.FindAsync(lastname);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByDateOfBirth(string dateofbirth)
        {
            var collabo = await _context.Collaborations.FindAsync(dateofbirth);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByAddress(string address)
        {
            var collabo = await _context.Collaborations.FindAsync(address);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByDepartment(string department)
        {
            var collabo = await _context.Collaborations.FindAsync(department);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByTelephone(int telephone)
        {
            var collabo = await _context.Collaborations.FindAsync(telephone);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByRoleStatus(string rolestatus)
        {
            var collabo = await _context.Collaborations.FindAsync(rolestatus);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByContractAgreement(DateTime contractagreement)
        {
            var collabo = await _context.Collaborations.FindAsync(contractagreement);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByContractDetails(string contractdetails)
        {
            var collabo = await _context.Collaborations.FindAsync(contractdetails);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var collabo = await _context.Collaborations.FindAsync(contractagreementexpiration);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByAgreedContractPayment(int agreedcontractpayment)
        {
            var collabo = await _context.Collaborations.FindAsync(agreedcontractpayment);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByAgreedPayment(DateTime agreedpayment)
        {
            var collabo = await _context.Collaborations.FindAsync(agreedpayment);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByHonouredContractPayment1(int honouredcontractpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredcontractpayment1);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByHonouredContractPayment2(int honouredcontractpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredcontractpayment2);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredcontractpayment1);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredcontractpayment2);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByHonouredPayment1(DateTime honouredpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredpayment1);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByHonouredPayment2(DateTime honouredpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(honouredpayment2);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByUnHonouredPayment1(DateTime unhonouredpayment1)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredpayment1);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByUnHonouredPayment2(DateTime unhonouredpayment2)
        {
            var collabo = await _context.Collaborations.FindAsync(unhonouredpayment2);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByModeOfPayment(string modeofpayment)
        {
            var collabo = await _context.Collaborations.FindAsync(modeofpayment);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber)
        {
            var collabo = await _context.Collaborations.FindAsync(econtractpaymentaccountnumber);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();

        }

        public async Task<List<Collaborations>> DeleteCollaboByContractPaymentAddress(string contractpaymentaddress)
        {
            var collabo = await _context.Collaborations.FindAsync(contractpaymentaddress);
            if (collabo is null)
                return null;

            _context.Collaborations.Remove(collabo);
            await _context.SaveChangesAsync();

            return await _context.Collaborations.ToListAsync();
        }

    }
}
