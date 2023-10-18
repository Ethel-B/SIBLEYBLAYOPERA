using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Services.ProcurementsService;


namespace SIBLEYBLAYOPERA.Services.ProcurementsService
{
    public class ProcurementsService : IProcurementsService
    {
        private readonly DataContext _context;

        public ProcurementsService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Procurements>> GetAllProcurements()
        {
            var procurements = await _context.Procurements.ToListAsync();
            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByItem(string item)
        {
            var procurements = await _context.Procurements.Where(p => p.Item == item).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByDomesticQuantity(int domesticquantity)
        {
            var procurements = await _context.Procurements.Where(p => p.DomesticQuantity == domesticquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByFixedPrice(int fixedprice)
        {
            var procurements = await _context.Procurements.Where(p => p.FixedPrice == fixedprice).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByProcurementCenter(string procurementcenter)
        {
            var procurements = await _context.Procurements.Where(p => p.ProcurementCenter == procurementcenter).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByTelephone(int telephone)
        {
            var procurements = await _context.Procurements.Where(p => p.Telephone == telephone).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByAddress(string address)
        {
            var procurements = await _context.Procurements.Where(p => p.Address == address).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var procurements = await _context.Procurements.Where(p => p.MonthlyPlacementOrderQuantity == monthlyplacementorderquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var procurements = await _context.Procurements.Where(p => p.YearlyPlacementOrderQuantity == yearlyplacementorderquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var procurements = await _context.Procurements.Where(p => p.DateOfPlacementOrder == dateofplacementorder).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var procurements = await _context.Procurements.Where(p => p.TargetedDeliveryDate == targeteddeliverydate).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var procurements = await _context.Procurements.Where(p => p.ArrivalDate == arrivaldate).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByArrivalLocation(string arrivallocation)
        {
            var procurements = await _context.Procurements.Where(p => p.ArrivalLocation== arrivallocation).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByModeOfPayment(string modeofpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.ModeOfPayment == modeofpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber)
        { 
            var procurements = await _context.Procurements.Where(p => p.EProcurementPaymentAccountNumber == eprocurementpaymentaccountnumber).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByProcurementPaymentAddress(string procurementpaymentaddress)
        {
            var procurements = await _context.Procurements.Where(p => p.ProcurementPaymentAddress == procurementpaymentaddress).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.AmountOfFirstPayment== amountoffirstpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.AmountOfSecondPayment == amountofsecondpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.ReceivedDateOfFirstPayment == receiveddateoffirstpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.ReceivedDateOfSecondPayment == receiveddateofsecondpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure)
        {
            var procurements = await _context.Procurements.Where(p => p.TotalMonthlyEXpenditure == totalmonthlyexpenditure).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<Procurements> GetSingleProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure)
        {
            var procurements = await _context.Procurements.Where(p => p.TotalYearlyEXpenditure == totalyearlyexpenditure).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            return procurements;
        }

        public async Task<ActionResult<List<Procurements>>> AddProcurements(Procurements procurements)
        {
            _context.Procurements.Add(procurements);
            await _context.SaveChangesAsync();
            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByItem(string item, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.Item == item).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.Item = request.Item;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByDomesticQuantity(int domesticquantity, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.DomesticQuantity == domesticquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.DomesticQuantity = request.DomesticQuantity;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByFixedPrice(int fixedprice, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.FixedPrice == fixedprice).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.FixedPrice = request.FixedPrice;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByProcurementCenter(string procurementcenter, Procurements request)
        {
           var procurements = await _context.Procurements.Where(p => p.ProcurementCenter == procurementcenter).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.ProcurementCenter = request.ProcurementCenter;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByTelephone(int telephone, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.Telephone == telephone).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByAddress(string address, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.Address == address).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.Address = request.Address;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.MonthlyPlacementOrderQuantity == monthlyplacementorderquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.MonthlyPlacementOrderQuantity = request.MonthlyPlacementOrderQuantity;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.YearlyPlacementOrderQuantity == yearlyplacementorderquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.YearlyPlacementOrderQuantity = request.YearlyPlacementOrderQuantity;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.DateOfPlacementOrder == dateofplacementorder).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.DateOfPlacementOrder = request.DateOfPlacementOrder;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.TargetedDeliveryDate == targeteddeliverydate).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.TargetedDeliveryDate = request.TargetedDeliveryDate;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByArrivalDate(DateTime arrivaldate, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.ArrivalDate == arrivaldate).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.ArrivalDate = request.ArrivalDate;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByArrivalLocation(string arrivallocation, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.ArrivalLocation == arrivallocation).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.ArrivalLocation = request.ArrivalLocation;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByModeOfPayment(string modeofpayment, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.ModeOfPayment == modeofpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.ModeOfPayment = request.ModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.EProcurementPaymentAccountNumber == eprocurementpaymentaccountnumber).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.EProcurementPaymentAccountNumber = request.EProcurementPaymentAccountNumber;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByProcurementPaymentAddress(string procurementpaymentaddress, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.ProcurementPaymentAddress == procurementpaymentaddress).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.ProcurementPaymentAddress = request.ProcurementPaymentAddress;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByAmountOfFirstPayment(int amountoffirstpayment, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.AmountOfFirstPayment == amountoffirstpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.AmountOfFirstPayment = request.AmountOfFirstPayment;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByAmountOfSecondPayment(int amountofsecondpayment, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.AmountOfSecondPayment == amountofsecondpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.AmountOfSecondPayment = request.AmountOfSecondPayment;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.ReceivedDateOfFirstPayment == receiveddateoffirstpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.ReceivedDateOfFirstPayment = request.ReceivedDateOfFirstPayment;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.ReceivedDateOfSecondPayment == receiveddateofsecondpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.ReceivedDateOfSecondPayment = request.ReceivedDateOfSecondPayment;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.TotalMonthlyEXpenditure == totalmonthlyexpenditure).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.TotalMonthlyEXpenditure = request.TotalMonthlyEXpenditure;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> UpdateProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure, Procurements request)
        {
            var procurements = await _context.Procurements.Where(p => p.TotalYearlyEXpenditure == totalyearlyexpenditure).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            procurements.TotalYearlyEXpenditure = request.TotalYearlyEXpenditure;
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByItem(string item)
        {
            var procurements = await _context.Procurements.Where(p => p.Item == item).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByDomesticQuantity(int domesticquantity)
        {
            var procurements = await _context.Procurements.Where(p => p.DomesticQuantity == domesticquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByFixedPrice(int fixedprice)
        {
            var procurements = await _context.Procurements.Where(p => p.FixedPrice == fixedprice).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByProcurementCenter(string procurementcenter)
        {
            var procurements = await _context.Procurements.Where(p => p.ProcurementCenter == procurementcenter).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByTelephone(int telephone)
        {
            var procurements = await _context.Procurements.Where(p => p.Telephone == telephone).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByAddress(string address)
        {
            var procurements = await _context.Procurements.Where(p => p.Address == address).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var procurements = await _context.Procurements.Where(p => p.MonthlyPlacementOrderQuantity == monthlyplacementorderquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var procurements = await _context.Procurements.Where(p => p.YearlyPlacementOrderQuantity == yearlyplacementorderquantity).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var procurements = await _context.Procurements.Where(p => p.DateOfPlacementOrder == dateofplacementorder).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var procurements = await _context.Procurements.Where(p => p.TargetedDeliveryDate == targeteddeliverydate).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var procurements = await _context.Procurements.Where(p => p.ArrivalDate == arrivaldate).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByArrivalLocation(string arrivallocation)
        {
            var procurements = await _context.Procurements.Where(p => p.ArrivalLocation == arrivallocation).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByModeOfPayment(string modeofpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.ModeOfPayment == modeofpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber)
        {
            var procurements = await _context.Procurements.Where(p => p.EProcurementPaymentAccountNumber == eprocurementpaymentaccountnumber).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByProcurementPaymentAddress(string procurementpaymentaddress)
        {
            var procurements = await _context.Procurements.Where(p => p.ProcurementPaymentAddress == procurementpaymentaddress).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.AmountOfFirstPayment == amountoffirstpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();
        }

        public async Task<List<Procurements>> DeleteProcurementsByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.AmountOfSecondPayment == amountofsecondpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();

        }

        public async Task<List<Procurements>> DeleteProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.ReceivedDateOfFirstPayment == receiveddateoffirstpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();

        }

        public async Task<List<Procurements>> DeleteProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var procurements = await _context.Procurements.Where(p => p.ReceivedDateOfSecondPayment == receiveddateofsecondpayment).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();

        }

        public async Task<List<Procurements>> DeleteProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure)
        {
            var procurements = await _context.Procurements.Where(p => p.TotalMonthlyEXpenditure == totalmonthlyexpenditure).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();

        }

        public async Task<List<Procurements>> DeleteProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure)
        {
            var procurements = await _context.Procurements.Where(p => p.TotalYearlyEXpenditure == totalyearlyexpenditure).FirstOrDefaultAsync();
            if (procurements is null)
                return null;

            _context.Procurements.Remove(procurements);
            await _context.SaveChangesAsync();

            return await _context.Procurements.ToListAsync();

        }
    }
}

