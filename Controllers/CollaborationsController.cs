using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using System.Net;
using System.Text;
using SIBLEYBLAYOPERA.Services.CollaborationsService;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaborationsController : ControllerBase
    {
        private readonly ICollaborationsService _collaborationsService;

        public CollaborationsController(ICollaborationsService collaborationsService)
        {
            _collaborationsService = collaborationsService;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Collaborations>>> GetAllCollabos()
        {
            return await _collaborationsService.GetAllCollabos();
        }

        [HttpGet("GetSingleCollaboByFirstName/{FirstName}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByFirstName(string firstname)
        {
            var result = await _collaborationsService.GetSingleCollaboByFirstName(firstname);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByMiddleName/{MiddleName}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByMiddleName(string middlename)
        {
            var result = await _collaborationsService.GetSingleCollaboByMiddleName(middlename);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByLastName/{LastName}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByLastName(string lastname)
        {
            var result = await _collaborationsService.GetSingleCollaboByLastName(lastname);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByDateOfBirth(string dateofbirth)
        {
            var result = await _collaborationsService.GetSingleCollaboByDateOfBirth(dateofbirth);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByAddress/{Address}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByAddress(string address)
        {
            var result = await _collaborationsService.GetSingleCollaboByAddress(address);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByDepartment/{Department}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByDepartment(string department)
        {
            var result = await _collaborationsService.GetSingleCollaboByDepartment(department);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByTelephone/{Telephone}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByTelephone(int telephone)
        {
            var result = await _collaborationsService.GetSingleCollaboByTelephone(telephone);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByRoleStatus/{RoleStatus}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByRoleStatus(string rolestatus)
        {
            var result = await _collaborationsService.GetSingleCollaboByRoleStatus(rolestatus);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByContractAgreement(DateTime contractagreement)
        {
            var result = await _collaborationsService.GetSingleCollaboByContractAgreement(contractagreement);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByContractDetails/{ContractDetails}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByContractDetails(string contractdetails)
        {
            var result = await _collaborationsService.GetSingleCollaboByContractDetails(contractdetails);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var result = await _collaborationsService.GetSingleCollaboByContractAgreementExpiration(contractagreementexpiration);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByAgreedContractPayment/{AgreedContractPayment}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByAgreedContractPayment(int agreedcontractpayment)
        {
            var result = await _collaborationsService.GetSingleCollaboByAgreedContractPayment(agreedcontractpayment);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByAgreedPayment/{AgreedPayment}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByAgreedPayment(DateTime agreedpayment)
        {
            var result = await _collaborationsService.GetSingleCollaboByAgreedPayment(agreedpayment);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByHonouredContractPayment1/{HonouredContractPayment1}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByHonouredContractPayment1(int honouredcontractpayment1)
        {
            var result = await _collaborationsService.GetSingleCollaboByHonouredContractPayment1(honouredcontractpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByHonouredContractPayment2/{HonouredContractPayment2}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByHonouredContractPayment2(int honouredcontractpayment2)
        {
            var result = await _collaborationsService.GetSingleCollaboByHonouredContractPayment2(honouredcontractpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByUnHonouredContractPayment1/{UnHonouredContractPayment1}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1)
        {
            var result = await _collaborationsService.GetSingleCollaboByUnHonouredContractPayment1(unhonouredcontractpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByUnHonouredContractPayment2/{UnHonouredContractPayment2}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2)
        {
            var result = await _collaborationsService.GetSingleCollaboByUnHonouredContractPayment2(unhonouredcontractpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByHonouredPayment1/{HonouredPayment1}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByHonouredPayment1(DateTime honouredpayment1)
        {
            var result = await _collaborationsService.GetSingleCollaboByHonouredPayment1(honouredpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByHonouredPayment2/{HonouredPayment2}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByHonouredPayment2(DateTime honouredpayment2)
        {
            var result = await _collaborationsService.GetSingleCollaboByHonouredPayment2(honouredpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByUnHonouredPayment1/{UnHonouredPayment1}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByUnHonouredPayment1(DateTime unhonouredpayment1)
        {
            var result = await _collaborationsService.GetSingleCollaboByUnHonouredPayment1(unhonouredpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByUnHonouredPayment2/{UnHonouredPayment2}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByUnHonouredPayment2(DateTime unhonouredpayment2)
        {
            var result = await _collaborationsService.GetSingleCollaboByUnHonouredPayment2(unhonouredpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByModeOfPayment(string modeofpayment)
        {
            var result = await _collaborationsService.GetSingleCollaboByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByEContractPaymentAccountNumber/{EContractPaymentAccountNumber}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber)
        {
            var result = await _collaborationsService.GetSingleCollaboByEContractPaymentAccountNumber(econtractpaymentaccountnumber);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleCollaboByContractPaymentAddress/{ContractPaymentAddress}")]
        public async Task<ActionResult<Collaborations>> GetSingleCollaboByContractPaymentAddress(string contractpaymentaddress)
        {
            var result = await _collaborationsService.GetSingleCollaboByContractPaymentAddress(contractpaymentaddress);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

  
        [HttpPost]
        public async Task<ActionResult<List<Collaborations>>> AddCollaborations(Collaborations collaborations)
        {
            var result = await _collaborationsService.AddCollaborations(collaborations);
            return Ok(result);
        }

     
        [HttpPut("UpdateCollaboByFirstName/{FirstName}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByFirstName(string firstname, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByFirstName(firstname, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByMiddleName/{MiddleName}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByMiddleName(string middlename, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByMiddleName(middlename, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByLastName/{LastName}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByLastName(string lastname, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByLastName(lastname, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByDateOfBirth(string dateofbirth, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByDateOfBirth(dateofbirth, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByAddress/{Address}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByAddress(string address, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByAddress(address, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByDepartment/{Department}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByDepartment(string department, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByDepartment(department, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByTelephone/{Telephone}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByTelephone(int telephone, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByTelephone(telephone, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByRoleStatus/{RoleStatus}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByRoleStatus(string rolestatus, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByRoleStatus(rolestatus, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByContractAgreement(DateTime contractagreement, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByContractAgreement(contractagreement, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByContractDetails/{ContractDetails}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByContractDetails(string contractdetails, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByContractDetails(contractdetails, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCallaboByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByContractAgreementExpiration(DateTime contractagreementexpiration, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByContractAgreementExpiration(contractagreementexpiration, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByAgreedContractPayment/{AgreedContractPayment}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByAgreedContractPayment(int agreedcontractpayment, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByAgreedContractPayment(agreedcontractpayment, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByAgreedPayment/{AgreedPayment}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByAgreedPayment(DateTime agreedpayment, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByAgreedPayment(agreedpayment, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByHonouredContractPayment1/{HonouredContractPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByHonouredContractPayment1(int honouredcontractpayment1, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByHonouredContractPayment1(honouredcontractpayment1, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByHonouredContractPayment2/{HonouredContractPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByHonouredContractPayment2(int honouredcontractpayment2, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByHonouredContractPayment2(honouredcontractpayment2, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByUnHonouredContractPayment1/{UnHonouredContractPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByUnHonouredContractPayment1(unhonouredcontractpayment1, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByUnHonouredContractPayment2/{UnHonouredContractPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByUnHonouredContractPayment2(unhonouredcontractpayment2, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByHonouredPayment1/{HonouredPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByHonouredPayment1(DateTime honouredpayment1, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByHonouredPayment1(honouredpayment1, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByHonouredPayment2/{HonouredPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByHonouredPayment2(DateTime honouredpayment2, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByHonouredPayment2(honouredpayment2, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByUnHonouredPayment1/{UnHonouredPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByUnHonouredPayment1(DateTime unhonouredpayment1, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByUnHonouredPayment1(unhonouredpayment1, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByUnHonouredPayment2/{UnHonouredPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByUnHonouredPayment2(DateTime unhonouredpayment2, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByUnHonouredPayment2(unhonouredpayment2, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByModeOfPayment(string modeofpayment, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByModeOfPayment(modeofpayment, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCollaboByEContractPaymentAccountNumber/{EContractPaymentAccountNumber}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByEContractPaymentAccountNumber(econtractpaymentaccountnumber, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

        [HttpPut("UpdateCallaboByContractPaymentAddress/{ContractPaymentAddress}")]
        public async Task<ActionResult<List<Collaborations>>> UpdateCollaboByContractPaymentAddress(string contractpaymentaddress, Collaborations request)
        {
            var result = await _collaborationsService.UpdateCollaboByContractPaymentAddress(contractpaymentaddress, request);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);
        }

       
        [HttpDelete("DeleteCollaboByFirstName/{FirstName}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByFirstName(string firstname)
        {
            var result = await _collaborationsService.DeleteCollaboByFirstName(firstname);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByMiddleName/{MiddleName}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByMiddleName(string middlename)
        {
            var result = await _collaborationsService.DeleteCollaboByMiddleName(middlename);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByLastName/{LastName}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByLastName(string lastname)
        {
            var result = await _collaborationsService.DeleteCollaboByLastName(lastname);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByDateOfBirth/{DateOfBirth}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByDateOfBirth(string dateofbirth)
        {
            var result = await _collaborationsService.DeleteCollaboByDateOfBirth(dateofbirth);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByAddress/{Address}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByAddress(string address)
        {
            var result = await _collaborationsService.DeleteCollaboByAddress(address);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByDepartment/{Department}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByDepartment(string department)
        {
            var result = await _collaborationsService.DeleteCollaboByDepartment(department);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByTelephone/{Telephone}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByTelephone(int telephone)
        {
            var result = await _collaborationsService.DeleteCollaboByTelephone(telephone);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByRoleStatus/{RoleStatus}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByRoleStatus(string rolestatus)
        {
            var result = await _collaborationsService.DeleteCollaboByRoleStatus(rolestatus);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByContractAgreement/{ContractAgreement}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByContractAgreement(DateTime contractagreement)
        {
            var result = await _collaborationsService.DeleteCollaboByContractAgreement(contractagreement);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByContractDetails/{ContractDetails}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByContractDetails(string contractdetails)
        {
            var result = await _collaborationsService.DeleteCollaboByContractDetails(contractdetails);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByContractAgreementExpiration/{ContractAgreementExpiration}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByContractAgreementExpiration(DateTime contractagreementexpiration)
        {
            var result = await _collaborationsService.DeleteCollaboByContractAgreementExpiration(contractagreementexpiration);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByAgreedContractPayment/{AgreedContractPayment}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByAgreedContractPayment(int agreedcontractpayment)
        {
            var result = await _collaborationsService.DeleteCollaboByAgreedContractPayment(agreedcontractpayment);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByAgreedPayment/{AgreedPayment}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByAgreedPayment(DateTime agreedpayment)
        {
            var result = await _collaborationsService.DeleteCollaboByAgreedPayment(agreedpayment);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByHonouredContractPayment1/{HonouredContractPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByHonouredContractPayment1(int honouredcontractpayment1)
        {
            var result = await _collaborationsService.DeleteCollaboByHonouredContractPayment1(honouredcontractpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByHonouredContractPayment2/{HonouredContractPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByHonouredContractPayment2(int honouredcontractpayment2)
        {
            var result = await _collaborationsService.DeleteCollaboByHonouredContractPayment2(honouredcontractpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByUnHonouredContractPayment1/{UnHonouredContractPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByUnHonouredContractPayment1(int unhonouredcontractpayment1)
        {
            var result = await _collaborationsService.DeleteCollaboByUnHonouredContractPayment1(unhonouredcontractpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByUnHonouredContractPayment2/{UnHonouredContractPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByUnHonouredContractPayment2(int unhonouredcontractpayment2)
        {
            var result = await _collaborationsService.DeleteCollaboByUnHonouredContractPayment2(unhonouredcontractpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByHonouredPayment1/{HonouredPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByHonouredPayment1(DateTime honouredpayment1)
        {
            var result = await _collaborationsService.DeleteCollaboByHonouredPayment1(honouredpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByHonouredPayment2/{HonouredPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByHonouredPayment2(DateTime honouredpayment2)
        {
            var result = await _collaborationsService.DeleteCollaboByHonouredPayment2(honouredpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByUnHonouredPayment1/{UnHonouredPayment1}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByUnHonouredPayment1(DateTime unhonouredpayment1)
        {
            var result = await _collaborationsService.DeleteCollaboByUnHonouredPayment1(unhonouredpayment1);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByUnHonouredPayment2/{UnHonouredPayment2}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByUnHonouredPayment2(DateTime unhonouredpayment2)
        {
            var result = await _collaborationsService.DeleteCollaboByUnHonouredPayment2(unhonouredpayment2);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByModeOfPayment(string modeofpayment)
        {
            var result = await _collaborationsService.DeleteCollaboByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByEContractPaymentAccountNumber/{EContractPaymentAccountNumber}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByEContractPaymentAccountNumber(int econtractpaymentaccountnumber)
        {
            var result = await _collaborationsService.DeleteCollaboByEContractPaymentAccountNumber(econtractpaymentaccountnumber);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteCollaboByContractPaymentAddress/{ContractPaymentAddress}")]
        public async Task<ActionResult<List<Collaborations>>> DeleteCollaboByContractPaymentAddress(string contractpaymentaddress)
        {
            var result = await _collaborationsService.DeleteCollaboByContractPaymentAddress(contractpaymentaddress);
            if (result is null)
                return NotFound("Collabo not found.");

            return Ok(result);

        }
    }
}

