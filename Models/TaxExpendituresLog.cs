using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Models
{
    //Tax Expenditures Log for the Opera.

    public class TaxExpendituresLog
    {
        public int Id { get; set; }

        public int? UsersId { get; set; }

        public Users Users { get; set; }

        public string TypeOfTax { get; set; } = string.Empty;

        public DateTime Year { get; set; }

        public int TotalYearlyExpenditure { get; set; }

        public string TaxPaymentLocation { get; set; } = string.Empty;

        public int ClearedAmount { get; set; }

        public int UnClearedAmount { get; set; }

        public string ModeOfPayment { get; set; } = string.Empty;

        public DateTime FirstPayment { get; set; }

        public DateTime SecondPayment { get; set; }

        public int AmountOfFirstPayment { get; set; }

        public int AmountOfSecondPayment { get; set; }

        public int TaxReceiptIDNumber { get; set; }
    }
}

    
