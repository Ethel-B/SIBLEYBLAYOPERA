using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.TaxExpendituresLogService
{
    public interface ITaxExpendituresLogService
    {

        public Task<List<TaxExpendituresLog>> GetAllExpenditures();

    public Task<TaxExpendituresLog> GetSingleExpendituresByTypeOfTax(string typeoftax);

        public Task<TaxExpendituresLog> GetSingleExpendituresByYear(DateTime year);

        public Task<TaxExpendituresLog> GetSingleExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure);

        public Task<TaxExpendituresLog> GetSingleExpendituresByTaxPaymentLocation(string taxpaymentlocation);

        public Task<TaxExpendituresLog> GetSingleExpendituresByClearedAmount(int clearedamount);

        public Task<TaxExpendituresLog> GetSingleExpendituresByUnClearedAmount(int unclearedamount);

        public Task<TaxExpendituresLog> GetSingleExpendituresByModeOfPayment(string modeofpayment);

        public Task<TaxExpendituresLog> GetSingleExpendituresByFirstPayment(DateTime firstpayment);

        public Task<TaxExpendituresLog> GetSingleExpendituresBySecondPayment(DateTime secondpayment);

        public Task<TaxExpendituresLog> GetSingleExpendituresByAmountOfFirstPayment(int amountoffirstpayment);

        public Task<TaxExpendituresLog> GetSingleExpendituresByAmountOfSecondPayment(int amountofsecondpayment);

        public Task<TaxExpendituresLog> GetSingleExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber);

        public Task<ActionResult<List<TaxExpendituresLog>>> AddTaxExpendituresLog(TaxExpendituresLog taxexpenditures);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByTypeOfTax(string typeoftax, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByYear(DateTime year, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByTaxPaymentLocation(string taxpaymentlocation, TaxExpendituresLog request);

      public Task<List<TaxExpendituresLog>> UpdateExpendituresByClearedAmount(int clearedamount, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByUnClearedAmount(int unclearedamount, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByModeOfPayment(string modeofpayment, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByFirstPayment(DateTime firstpayment, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresBySecondPayment(DateTime secondpayment, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByAmountOfFirstPayment(int amountoffirstpayment, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByAmountOfSecondPayment(int amountofsecondpayment, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> UpdateExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber, TaxExpendituresLog request);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByTypeOfTax(string typeoftax);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByYear(DateTime year);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByTaxPaymentLocation(string taxpaymentlocation);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByClearedAmount(int clearedamount);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByUnClearedAmount(int unclearedamount);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByModeOfPayment(string modeofpayment);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByFirstPayment(DateTime firstpayment);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresBySecondPayment(DateTime secondpayment);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByAmountOfFirstPayment(int amountoffirstpayment);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByAmountOfSecondPayment(int amountofsecondpayment);

        public Task<List<TaxExpendituresLog>> DeleteExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber);
            }
    }

