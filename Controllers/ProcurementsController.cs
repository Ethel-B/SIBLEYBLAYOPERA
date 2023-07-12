using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using System.Net;
using System.Text;
using SIBLEYBLAYOPERA.Services.ProcurementsService;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcurementsController : ControllerBase
    {
        private readonly IProcurementsService _procurementsService;

        public ProcurementsController(IProcurementsService procurementsService)
        {
            _procurementsService = procurementsService;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Procurements>>> GetAllProcurements()
        {
            return await _procurementsService.GetAllProcurements();
        }

        [HttpGet("GetSingleProcurementsByItem/{Item}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByItem(string item)
        {
            var result = await _procurementsService.GetSingleProcurementsByItem(item);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByDomesticQuantity/{DomesticQuantity}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByDomesticQuantity(int domesticquantity)
        {
            var result = await _procurementsService.GetSingleProcurementsByDomesticQuantity(domesticquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByFixedPrice/{FixedPrice}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByFixedPrice(int fixedprice)
        {
            var result = await _procurementsService.GetSingleProcurementsByFixedPrice(fixedprice);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByProcurementCenter/{ProcurementCenter}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByProcurementCenter(string procurementcenter)
        {
            var result = await _procurementsService.GetSingleProcurementsByProcurementCenter(procurementcenter);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByTelephone/{Telephone}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByTelephone(int telephone)
        {
            var result = await _procurementsService.GetSingleProcurementsByTelephone(telephone);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByAddress/{Address}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByAddress(string address)
        {
            var result = await _procurementsService.GetSingleProcurementsByAddress(address);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByMonthlyPlacementOrderQuantity/{MonthlyPlacementOrderQuantity}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var result = await _procurementsService.GetSingleProcurementsByMonthlyPlacementOrderQuantity(monthlyplacementorderquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByYearlyPlacementOrderQuantity/{YearlyPlacementOrderQuantity}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var result = await _procurementsService.GetSingleProcurementsByYearlyPlacementOrderQuantity(yearlyplacementorderquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurements/{DateOfPlacementOrder}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var result = await _procurementsService.GetSingleProcurementsByDateOfPlacementOrder(dateofplacementorder);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByTargetedDeliveryDate/{TargetedDeliveryDate}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var result = await _procurementsService.GetSingleProcurementsByTargetedDeliveryDate(targeteddeliverydate);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByArrivalDate/{ArrivalDate}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var result = await _procurementsService.GetSingleProcurementsByArrivalDate(arrivaldate);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByArrivalLocation/{ArrivalLocation}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByArrivalLocation(string arrivallocation)
        {
            var result = await _procurementsService.GetSingleProcurementsByArrivalLocation(arrivallocation);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByModeOfPayment(string modeofpayment)
        {
            var result = await _procurementsService.GetSingleProcurementsByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByEProcurementPaymentAccountNumber/{EProcurementPaymentAccountNumber}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber)
        {
            var result = await _procurementsService.GetSingleProcurementsByEProcurementPaymentAccountNumber(eprocurementpaymentaccountnumber);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByProcurementPaymentAddress/{ProcurementPaymentAddress}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByProcurementPaymentAddress(string procurementpaymentaddress)
        {
            var result = await _procurementsService.GetSingleProcurementsByProcurementPaymentAddress(procurementpaymentaddress);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var result = await _procurementsService.GetSingleProcurementsByAmountOfFirstPayment(amountoffirstpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var result = await _procurementsService.GetSingleProcurementsByAmountOfSecondPayment(amountofsecondpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByReceivedDateOfFirstPayment/{ReceivedDateOfFirstPayment}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var result = await _procurementsService.GetSingleProcurementsByReceivedDateOfFirstPayment(receiveddateoffirstpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByReceivedDateOfSecondPayment/{ReceivedDateOfSecondPayment}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var result = await _procurementsService.GetSingleProcurementsByReceivedDateOfSecondPayment(receiveddateofsecondpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByTotalMonthlyEXpenditure/{TotalMonthlyEXpenditure}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure)
        {
            var result = await _procurementsService.GetSingleProcurementsByTotalMonthlyEXpenditure(totalmonthlyexpenditure);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleProcurementsByTotalYearlyEXpenditure/{TotalYearlyEXpenditure}")]
        public async Task<ActionResult<Procurements>> GetSingleProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure)
        {
            var result = await _procurementsService.GetSingleProcurementsByTotalYearlyEXpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }
       
        [HttpPost]
        public async Task<ActionResult<List<Procurements>>> AddLog(Procurements procurements)
        {
            var result = await _procurementsService.AddProcurements(procurements);
            return Ok(result);
        }

      
        [HttpPut("UpdateProcurementsByItem/{Item}")]
       public async Task<ActionResult<Procurements>> UpdateProcurementsByItem(string item, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByItem(item, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByDomesticQuantity/{DomesticQuantity}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByDomesticQuantity(int domesticquantity, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByDomesticQuantity(domesticquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByFixedPrice/{FixedPrice}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByFixedPrice(int fixedprice, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByFixedPrice(fixedprice, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByProcurementCenter/{ProcurementCenter}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByProcurementCenter(string procurementcenter, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByProcurementCenter(procurementcenter, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByTelephone/{Telephone}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByTelephone(int telephone, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByTelephone(telephone, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByAddress/{Address}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByAddress(string address, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByAddress(address, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByMonthlyPlacementOrderQuantity/{MonthlyPlacementOrderQuantity}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByMonthlyPlacementOrderQuantity(monthlyplacementorderquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByYearlyPlacementOrderQuantity/{YearlyPlacementOrderQuantity}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByYearlyPlacementOrderQuantity(yearlyplacementorderquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByDateOfPlacementOrder/{DateOfPlacementOrder}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByDateOfPlacementOrder(dateofplacementorder, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }
    
        [HttpPut("UpdateProcurementsByTargetedDeliveryDate/{TargetedDeliveryDate}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByTargetedDeliveryDate(targeteddeliverydate, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByArrivalDate/{ArrivalDate}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByArrivalDate(DateTime arrivaldate, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByArrivalDate(arrivaldate, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByArrivalLocation/{ArrivalLocation}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByArrivalLocation(string arrivallocation, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByArrivalLocation(arrivallocation, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByModeOfPayment(string modeofpayment, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByModeOfPayment(modeofpayment, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByEProcurementPaymentAccountNumber/{EProcurementPaymentAccountNumber}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByEProcurementPaymentAccountNumber(eprocurementpaymentaccountnumber, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByProcurementPaymentAddress/{ProcurementPaymentAddress}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByProcurementPaymentAddress(string procurementpaymentaddress, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByProcurementPaymentAddress(procurementpaymentaddress, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByAmountOfFirstPayment(int amountoffirstpayment, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByAmountOfFirstPayment(amountoffirstpayment, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByAmountOfSecondPayment(int amountofsecondpayment, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByAmountOfSecondPayment(amountofsecondpayment, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByReceivedDateOfFirstPayment/{ReceivedDateOfFirstPayment}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByReceivedDateOfFirstPayment(receiveddateoffirstpayment, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByReceivedDateOfSecondPayment/{ReceivedDateOfSecondPayment}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByReceivedDateOfSecondPayment(receiveddateofsecondpayment, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByTotalMonthlyEXpenditure/{TotalMonthlyEXpenditure}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByTotalMonthlyEXpenditure(totalmonthlyexpenditure, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateProcurementsByTotalYearlyEXpenditure/{TotalYearlyEXpenditure}")]
        public async Task<ActionResult<Procurements>> UpdateProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure, Procurements request)
        {
            var result = await _procurementsService.UpdateProcurementsByTotalYearlyEXpenditure(totalyearlyexpenditure, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }
        
        
        [HttpDelete("DeleteProcurementsByItem/{Item}")]
         public async Task<ActionResult<Procurements>> DeleteProcurementsByItem(string item)
        {
            var result = await _procurementsService.DeleteProcurementsByItem(item);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurements/{DomesticQuantity}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByDomesticQuantity(int domesticquantity)
        {
            var result = await _procurementsService.DeleteProcurementsByDomesticQuantity(domesticquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByFixedPrice/{FixedPrice}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByFixedPrice(int fixedprice)
        {
            var result = await _procurementsService.DeleteProcurementsByFixedPrice(fixedprice);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByProcurementCenter/{ProcurementCenter}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByProcurementCenter(string procurementcenter)
        {
            var result = await _procurementsService.DeleteProcurementsByProcurementCenter(procurementcenter);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByTelephone/{Telephone}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByTelephone(int telephone)
        {
            var result = await _procurementsService.DeleteProcurementsByTelephone(telephone);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByAddress/{Address}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByAddress(string address)
        {
            var result = await _procurementsService.DeleteProcurementsByAddress(address);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByMonthlyPlacementOrderQuantity/{MonthlyPlacementOrderQuantity}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var result = await _procurementsService.DeleteProcurementsByMonthlyPlacementOrderQuantity(monthlyplacementorderquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByYearlyPlacementOrderQuantity/{YearlyPlacementOrderQuantity}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var result = await _procurementsService.DeleteProcurementsByYearlyPlacementOrderQuantity(yearlyplacementorderquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByDateOfPlacementOrder/{DateOfPlacementOrder}")]
        public async Task<ActionResult<Procurements>> DeleteProcrementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var result = await _procurementsService.DeleteProcurementsByDateOfPlacementOrder(dateofplacementorder);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByTargetedDeliveryDate/{TargetedDeliveryDate}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var result = await _procurementsService.DeleteProcurementsByTargetedDeliveryDate(targeteddeliverydate);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByArrivalDate/{ArrivalDate}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var result = await _procurementsService.DeleteProcurementsByArrivalDate(arrivaldate);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByArrivalLocation/{ArrivalLocation}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByArrivalLocation(string arrivallocation)
        {
            var result = await _procurementsService.DeleteProcurementsByArrivalLocation(arrivallocation);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByModeOfPayment(string modeofpayment)
        {
            var result = await _procurementsService.DeleteProcurementsByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByEProcurementPaymentAccountNumber/{EProcurementPaymentAccountNumber}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber)
        {
            var result = await _procurementsService.DeleteProcurementsByEProcurementPaymentAccountNumber(eprocurementpaymentaccountnumber);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByProcurementPaymentAddress/{ProcurementPaymentAddress}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByProcurementPaymentAddress(string procurementpaymentaddress)
        {
            var result = await _procurementsService.DeleteProcurementsByProcurementPaymentAddress(procurementpaymentaddress);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var result = await _procurementsService.DeleteProcurementsByAmountOfFirstPayment(amountoffirstpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var result = await _procurementsService.DeleteProcurementsByAmountOfSecondPayment(amountofsecondpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByReceivedDateOfFirstPayment/{ReceivedDateOfFirstPayment}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var result = await _procurementsService.DeleteProcurementsByReceivedDateOfFirstPayment(receiveddateoffirstpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByReceivedDateOfSecondPayment/{ReceivedDateOfSecondPayment}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var result = await _procurementsService.DeleteProcurementsByReceivedDateOfSecondPayment(receiveddateofsecondpayment);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByTotalMonthlyEXpenditure/{TotalMonthlyEXpenditure}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure)
        {
            var result = await _procurementsService.DeleteProcurementsByTotalMonthlyEXpenditure(totalmonthlyexpenditure);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteProcurementsByTotalYearlyEXpenditure/{TotalYearlyEXpenditure}")]
        public async Task<ActionResult<Procurements>> DeleteProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure)
        {
            var result = await _procurementsService.DeleteProcurementsByTotalYearlyEXpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }
    }
}


