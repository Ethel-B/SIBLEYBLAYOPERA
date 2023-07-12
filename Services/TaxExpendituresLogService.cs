using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Services.TaxExpendituresLogService;


namespace SIBLEYBLAYOPERA.Services.TaxExpendituresLogService
{
    public class TaxExpendituresLogService : ITaxExpendituresLogService
    {
        private readonly DataContext _context;

        public TaxExpendituresLogService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<TaxExpendituresLog>> GetAllExpenditures()
        {
            var expenditures = await _context.TaxExpendituresLog.ToListAsync();
            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByTypeOfTax(string typeoftax)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(typeoftax);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByYear(DateTime year)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(year);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(totalyearlyexpenditure);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByTaxPaymentLocation(string taxpaymentlocation)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(taxpaymentlocation);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByClearedAmount(int clearedamount)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(clearedamount);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByUnClearedAmount(int unclearedamount)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(unclearedamount);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByModeOfPayment(string modeofpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(modeofpayment);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByFirstPayment(DateTime firstpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(firstpayment);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresBySecondPayment(DateTime secondpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(secondpayment);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(amountoffirstpayment);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(amountofsecondpayment);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<TaxExpendituresLog> GetSingleExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(taxreceiptidnumber);
            if (expenditures is null)
                return null;

            return expenditures;
        }

        public async Task<ActionResult<List<TaxExpendituresLog>>> AddTaxExpendituresLog(TaxExpendituresLog taxexpenditures)
        {
            _context.TaxExpendituresLog.Add(taxexpenditures);
            await _context.SaveChangesAsync();
            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByTypeOfTax(string typeoftax, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(typeoftax);
            if (expenditures is null)
                return null;

            expenditures.TypeOfTax = request.TypeOfTax;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByYear(DateTime year, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(year);
            if (expenditures is null)
                return null;

            expenditures.Year = request.Year;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(totalyearlyexpenditure);
            if (expenditures is null)
                return null;

            expenditures.TotalYearlyExpenditure = request.TotalYearlyExpenditure;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByTaxPaymentLocation(string taxpaymentlocation, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(taxpaymentlocation);
            if (expenditures is null)
                return null;

            expenditures.TaxPaymentLocation = request.TaxPaymentLocation;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByClearedAmount(int clearedamount, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(clearedamount);
            if (expenditures is null)
                return null;

            expenditures.ClearedAmount = request.ClearedAmount;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByUnClearedAmount(int unclearedamount, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(unclearedamount);
            if (expenditures is null)
                return null;

            expenditures.UnClearedAmount = request.UnClearedAmount;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByModeOfPayment(string modeofpayment, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(modeofpayment);
            if (expenditures is null)
                return null;

            expenditures.ModeOfPayment = request.ModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByFirstPayment(DateTime firstpayment, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(firstpayment);
            if (expenditures is null)
                return null;

            expenditures.FirstPayment = request.FirstPayment;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresBySecondPayment(DateTime secondpayment, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(secondpayment);
            if (expenditures is null)
                return null;

            expenditures.SecondPayment = request.SecondPayment;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByAmountOfFirstPayment(int amountoffirstpayment, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(amountoffirstpayment);
            if (expenditures is null)
                return null;

            expenditures.AmountOfFirstPayment = request.AmountOfFirstPayment;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByAmountOfSecondPayment(int amountofsecondpayment, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(amountofsecondpayment);
            if (expenditures is null)
                return null;

            expenditures.AmountOfSecondPayment = request.AmountOfSecondPayment;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> UpdateExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber, TaxExpendituresLog request)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(taxreceiptidnumber);
            if (expenditures is null)
                return null;

            expenditures.TaxReceiptIDNumber = request.TaxReceiptIDNumber;
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByTypeOfTax(string typeoftax)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(typeoftax);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByYear(DateTime year)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(year);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(totalyearlyexpenditure);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByTaxPaymentLocation(string taxpaymentlocation)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(taxpaymentlocation);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByClearedAmount(int clearedamount)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(clearedamount);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByUnClearedAmount(int unclearedamount)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(unclearedamount);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByModeOfPayment(string modeofpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(modeofpayment);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByFirstPayment(DateTime firstpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(firstpayment);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresBySecondPayment(DateTime secondpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(secondpayment);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(amountoffirstpayment);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(amountofsecondpayment);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }

        public async Task<List<TaxExpendituresLog>> DeleteExpendituresByTaxReceiptIDNumber(int taxreceiptidnumber)
        {
            var expenditures = await _context.TaxExpendituresLog.FindAsync(taxreceiptidnumber);
            if (expenditures is null)
                return null;

            _context.TaxExpendituresLog.Remove(expenditures);
            await _context.SaveChangesAsync();

            return await _context.TaxExpendituresLog.ToListAsync();
        }
    }
}
