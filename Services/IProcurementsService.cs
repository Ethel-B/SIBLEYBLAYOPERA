using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.ProcurementsService
{
    public interface IProcurementsService
    {
        public Task<List<Procurements>> GetAllProcurements();

        public Task<Procurements> GetSingleProcurementsByItem(string item);

        public Task<Procurements> GetSingleProcurementsByDomesticQuantity(int domesticquantity);

        public Task<Procurements> GetSingleProcurementsByFixedPrice(int fixedprice);

        public Task<Procurements> GetSingleProcurementsByProcurementCenter(string procurementcenter);

        public Task<Procurements> GetSingleProcurementsByTelephone(int telephone);

        public Task<Procurements> GetSingleProcurementsByAddress(string address);

        public Task<Procurements> GetSingleProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity);

        public Task<Procurements> GetSingleProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity);

        public Task<Procurements> GetSingleProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder);

        public Task<Procurements> GetSingleProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate);

        public Task<Procurements> GetSingleProcurementsByArrivalDate(DateTime arrivaldate);

        public Task<Procurements> GetSingleProcurementsByArrivalLocation(string arrivallocation);

        public Task<Procurements> GetSingleProcurementsByModeOfPayment(string modeofpayment);

        public Task<Procurements> GetSingleProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber);

        public Task<Procurements> GetSingleProcurementsByProcurementPaymentAddress(string procurementpaymentaddress);

        public Task<Procurements> GetSingleProcurementsByAmountOfFirstPayment(int amountoffirstpayment);

        public Task<Procurements> GetSingleProcurementsByAmountOfSecondPayment(int amountofsecondpayment);

        public Task<Procurements> GetSingleProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment);

        public Task<Procurements> GetSingleProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment);

        public Task<Procurements> GetSingleProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure);

        public Task<Procurements> GetSingleProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure);

        public Task<ActionResult<List<Procurements>>> AddProcurements(Procurements procurements);

        public Task<List<Procurements>> UpdateProcurementsByItem(string item, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByDomesticQuantity(int domesticquantity, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByFixedPrice(int fixedprice, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByProcurementCenter(string procurementcenter, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByTelephone(int telephone, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByAddress(string address, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByArrivalDate(DateTime arrivaldate, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByArrivalLocation(string arrivallocation, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByModeOfPayment(string modeofpayment, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByProcurementPaymentAddress(string procurementpaymentaddress, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByAmountOfFirstPayment(int amountoffirstpayment, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByAmountOfSecondPayment(int amountofsecondpayment, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure, Procurements request);

        public Task<List<Procurements>> UpdateProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure, Procurements request);

        public Task<List<Procurements>> DeleteProcurementsByItem(string item);

        public Task<List<Procurements>> DeleteProcurementsByDomesticQuantity(int domesticquantity);

        public Task<List<Procurements>> DeleteProcurementsByFixedPrice(int fixedprice);

        public Task<List<Procurements>> DeleteProcurementsByProcurementCenter(string procurementcenter);

        public Task<List<Procurements>> DeleteProcurementsByTelephone(int telephone);

        public Task<List<Procurements>> DeleteProcurementsByAddress(string address);

        public Task<List<Procurements>> DeleteProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity);

        public Task<List<Procurements>> DeleteProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity);

        public Task<List<Procurements>> DeleteProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder);

        public Task<List<Procurements>> DeleteProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate);

        public Task<List<Procurements>> DeleteProcurementsByArrivalDate(DateTime arrivaldate);

        public Task<List<Procurements>> DeleteProcurementsByArrivalLocation(string arrivallocation);

        public Task<List<Procurements>> DeleteProcurementsByModeOfPayment(string modeofpayment);

       public Task<List<Procurements>> DeleteProcurementsByEProcurementPaymentAccountNumber(int eprocurementpaymentaccountnumber);

      public Task<List<Procurements>> DeleteProcurementsByProcurementPaymentAddress(string procurementpaymentaddress);

      public Task<List<Procurements>> DeleteProcurementsByAmountOfFirstPayment(int amountoffirstpayment);

      public Task<List<Procurements>> DeleteProcurementsByAmountOfSecondPayment(int amountofsecondpayment);

       public Task<List<Procurements>> DeleteProcurementsByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment);

       public Task<List<Procurements>> DeleteProcurementsByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment);

       public Task<List<Procurements>> DeleteProcurementsByTotalMonthlyEXpenditure(int totalmonthlyexpenditure);

      public Task<List<Procurements>> DeleteProcurementsByTotalYearlyEXpenditure(int totalyearlyexpenditure);
    }
}


