using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.CollaborationsService
{
    public interface ICollaborationsService
    {
        public Task<List<Collaborations>> GetAllCollabos();

        public Task<Collaborations> GetSingleCollaboByFirstName(string firstname);

        public Task<Collaborations> GetSingleCollaboByMiddleName(string middlename);

        public Task<Collaborations> GetSingleCollaboByLastName(string lastname);

        public Task<Collaborations> GetSingleCollaboByDateOfBirth(string dateofbirth);

        public Task<Collaborations> GetSingleCollaboByAddress(string address);

        public Task<Collaborations> GetSingleCollaboByDepartment(string department);

        public Task<Collaborations> GetSingleCollaboByTelephone(int telephone);

        public Task<Collaborations> GetSingleCollaboByRoleStatus(string rolestatus);

        public Task<Collaborations> GetSingleCollaboByContractAgreement(DateTime contractagreement);

        public Task<Collaborations> GetSingleCollaboByContractDetails(string contractdetails);

        public Task<Collaborations> GetSingleCollaboByContractAgreementExpiration(DateTime contractagreementexpiration);

        public Task<Collaborations> GetSingleCollaboByAgreedContractPayment(int agreedcontractpayment);

        public Task<Collaborations> GetSingleCollaboByAgreedPayment(DateTime agreedpayment);

        public Task<Collaborations> GetSingleCollaboByHonouredContractPayment1(int honouredcontractpayment1);

        public Task<Collaborations> GetSingleCollaboByHonouredContractPayment2(int honouredcontractpayment2);

        public Task<Collaborations> GetSingleCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1);

        public Task<Collaborations> GetSingleCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2);

        public Task<Collaborations> GetSingleCollaboByHonouredPayment1(DateTime honouredpayment1);

        public Task<Collaborations> GetSingleCollaboByHonouredPayment2(DateTime honouredpayment2);

        public Task<Collaborations> GetSingleCollaboByUnHonouredPayment1(DateTime unhonouredpayment1);

        public Task<Collaborations> GetSingleCollaboByUnHonouredPayment2(DateTime unhonouredpayment2);

        public Task<Collaborations> GetSingleCollaboByModeOfPayment(string modeofpayment);

        public Task<Collaborations> GetSingleCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber);

        public Task<Collaborations> GetSingleCollaboByContractPaymentAddress(string contractpaymentaddress);

        public Task<ActionResult<List<Collaborations>>> AddCollaborations(Collaborations collaborations);

        public Task<List<Collaborations>> UpdateCollaboByFirstName(string firstname, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByMiddleName(string middlename, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByLastName(string lastname, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByDateOfBirth(string dateofbirth, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByAddress(string address, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByDepartment(string department, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByTelephone(int telephone, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByRoleStatus(string rolestatus, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByContractAgreement(DateTime contractagreement, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByContractDetails(string contractdetails, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByContractAgreementExpiration(DateTime contractagreementexpiration, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByAgreedContractPayment(int agreedcontractpayment, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByAgreedPayment(DateTime agreedpayment, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByHonouredContractPayment1(int honouredcontractpayment1, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByHonouredContractPayment2(int honouredcontractpayment2, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByHonouredPayment1(DateTime honouredpayment1, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByHonouredPayment2(DateTime honouredpayment2, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByUnHonouredPayment1(DateTime unhonouredpayment1, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByUnHonouredPayment2(DateTime unhonouredpayment2, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByModeOfPayment(string modeofpayment, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber, Collaborations request);

        public Task<List<Collaborations>> UpdateCollaboByContractPaymentAddress(string contractpaymentaddress, Collaborations request);

        public Task<List<Collaborations>> DeleteCollaboByFirstName(string firstname);

        public Task<List<Collaborations>> DeleteCollaboByMiddleName(string middlename);

        public Task<List<Collaborations>> DeleteCollaboByLastName(string lastname);

        public Task<List<Collaborations>> DeleteCollaboByDateOfBirth(string dateofbirth);

        public Task<List<Collaborations>> DeleteCollaboByAddress(string address);

        public Task<List<Collaborations>> DeleteCollaboByDepartment(string department);

        public Task<List<Collaborations>> DeleteCollaboByTelephone(int telephone);

        public Task<List<Collaborations>> DeleteCollaboByRoleStatus(string rolestatus);

        public Task<List<Collaborations>> DeleteCollaboByContractAgreement(DateTime contractagreement);

        public Task<List<Collaborations>> DeleteCollaboByContractDetails(string contractdetails);

        public Task<List<Collaborations>> DeleteCollaboByContractAgreementExpiration(DateTime contractagreementexpiration);

        public Task<List<Collaborations>> DeleteCollaboByAgreedContractPayment(int agreedcontractpayment);

        public Task<List<Collaborations>> DeleteCollaboByAgreedPayment(DateTime agreedpayment);

        public Task<List<Collaborations>> DeleteCollaboByHonouredContractPayment1(int honouredcontractpayment1);

        public Task<List<Collaborations>> DeleteCollaboByHonouredContractPayment2(int honouredcontractpayment2);

        public Task<List<Collaborations>> DeleteCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1);

        public Task<List<Collaborations>> DeleteCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2);

        public Task<List<Collaborations>> DeleteCollaboByHonouredPayment1(DateTime honouredpayment1);

        public Task<List<Collaborations>> DeleteCollaboByHonouredPayment2(DateTime honouredpayment2);

        public Task<List<Collaborations>> DeleteCollaboByUnHonouredPayment1(DateTime unhonouredpayment1);

        public Task<List<Collaborations>> DeleteCollaboByUnHonouredPayment2(DateTime unhonouredpayment2);

        public Task<List<Collaborations>> DeleteCollaboByModeOfPayment(string modeofpayment);

        public Task<List<Collaborations>> DeleteCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber);

        public Task<List<Collaborations>> DeleteCollaboByContractPaymentAddress(string contractpaymentaddress);
            }
    }


