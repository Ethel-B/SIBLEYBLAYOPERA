using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using System.Net;
using System.Text;
using SIBLEYBLAYOPERA.Migrations;
using SIBLEYBLAYOPERA.Services.TaxExpendituresLogService;
using TaxExpendituresLog = SIBLEYBLAYOPERA.Models.TaxExpendituresLog;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxExpendituresLogController : ControllerBase
    {
        private readonly ITaxExpendituresLogService _taxexpenditureslogService;

        public TaxExpendituresLogController(ITaxExpendituresLogService taxexpenditureslogService)
        {
            _taxexpenditureslogService= taxexpenditureslogService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TaxExpendituresLog>>> GetAllExpenditures()
        {
            return await _taxexpenditureslogService.GetAllExpenditures();
        }

        [HttpGet("GetSingleExpendituresByTypeOfTax/{TypeOfTax}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByTypeOfTax(string typeoftax)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByTypeOfTax(typeoftax);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByYear/{Year}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByYear(DateTime year)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByYear(year);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByTotalYearlyExpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByTaxPaymentLocation/{TaxPaymentLocation}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByTaxPaymentLocation(string taxpaymentlocation)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByTaxPaymentLocation(taxpaymentlocation);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByClearedAmount/{ClearedAmount}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByClearedAmount(int clearedamount)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByClearedAmount(clearedamount);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByUnClearedAmount/{UnClearedAmount}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByUnClearedAmount(int unclearedamount)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByUnClearedAmount(unclearedamount);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByModeOfPayment(string modeofpayment)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByFirstPayment/{FirstPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByFirstPayment(DateTime firstpayment)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByFirstPayment(firstpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresBySecondPayment/{SecondPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresBySecondPayment(DateTime secondpayment)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresBySecondPayment(secondpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByAmountOfFirstPayment(amountoffirstpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByAmountOfSecondPayment(amountofsecondpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleExpendituresByTaxReceiptIDNumber/{TaxReceiptIDNumber}")]
        public async Task<ActionResult<TaxExpendituresLog>> GetSingleExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber)
        {
            var result = await _taxexpenditureslogService.GetSingleExpendituresByTaxReceiptIDNumber(taxreceiptidnumber);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<TaxExpendituresLog>>> AddTaxExpendituresLog(TaxExpendituresLog taxexpenditures)
        {
            var result = await _taxexpenditureslogService.AddTaxExpendituresLog(taxexpenditures);
            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByTypeOfTax/{TypeOfTax}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByTypeOfTax(string typeoftax, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByTypeOfTax(typeoftax, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByYear/{Year}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByYear(DateTime year, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByYear(year, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByTotalYearlyExpenditure(totalyearlyexpenditure, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByTaxPaymentLocation/{TaxPaymentLocation}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByTaxPaymentLocation(string taxpaymentlocation, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByTaxPaymentLocation(taxpaymentlocation, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByClearedAmount/{ClearedAmount}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByClearedAmount(int clearedamount, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByClearedAmount(clearedamount, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByUnClearedAmount/{UnClearedAmount}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByUnClearedAmount(int unclearedamount, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByUnClearedAmount(unclearedamount, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByModeOfPayment(string modeofpayment, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByModeOfPayment(modeofpayment, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByFirstPayment/{FirstPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByFirstPayment(DateTime firstpayment, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByFirstPayment(firstpayment, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresBySecondPayment/{SecondPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresBySecondPayment(DateTime secondpayment, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresBySecondPayment(secondpayment, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByAmountOfFirstPayment(int amountoffirstpayment, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByAmountOfFirstPayment(amountoffirstpayment, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByAmountOfSecondPayment(int amountofsecondpayment, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByAmountOfFirstPayment(amountofsecondpayment, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpPut("UpdateExpendituresByTaxReceiptIDNumber/{TaxReceiptIDNumber}")]
        public async Task<ActionResult<TaxExpendituresLog>> UpdateExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber, TaxExpendituresLog request)
        {
            var result = await _taxexpenditureslogService.UpdateExpendituresByTaxReceiptIDNumber(taxreceiptidnumber, request);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByTypeOfTax/{TypeOfTax}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByTypeOfTax(string typeoftax)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByTypeOfTax(typeoftax);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByYear/{Year}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByYear(DateTime year)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByYear(year);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByTotalYearlyExpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByTaxPaymentLocation/{TaxPaymentLocation}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByTaxPaymentLocation(string taxpaymentlocation)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByTaxPaymentLocation(taxpaymentlocation);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByClearedAmount/{ClearedAmount}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByClearedAmount(int clearedamount)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByClearedAmount(clearedamount);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByUnClearedAmount/{UnClearedAmount}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByUnClearedAmount(int unclearedamount)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByUnClearedAmount(unclearedamount);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByModeOfPayment(string modeofpayment)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByFirstPayment/{FirstPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByFirstPayment(DateTime firstpayment)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByFirstPayment(firstpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresBySecondPayment/{SecondPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresBySecondPayment(DateTime secondpayment)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresBySecondPayment(secondpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByAmountOfFirstPayment(amountoffirstpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }
 
        [HttpDelete("DeleteExpendituresByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByAmountOfSecondPayment(amountofsecondpayment);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteExpendituresByTaxReceiptIDNumber/{TaxReceiptIDNumber}")]
        public async Task<ActionResult<TaxExpendituresLog>> DeleteExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber)
        {
            var result = await _taxexpenditureslogService.DeleteExpendituresByTaxReceiptIDNumber(taxreceiptidnumber);
            if (result is null)
                return NotFound("Expenditures not found.");

            return Ok(result);
        }
    }
}

