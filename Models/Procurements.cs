namespace SIBLEYBLAYOPERA.Models
{
    //Procurements or Purchasing Log for the Opera.

    public class Procurements
    {
        public int Id { get; set; }

        public int? UsersId { get; set; }

        public Users Users { get; set; }

        public string Item { get; set; } = string.Empty;

        public int DomesticQuantity { get; set; }

        public int FixedPrice { get; set; }

        public string ProcurementCenter { get; set; } = string.Empty;

        public int Telephone { get; set; } 

        public string Address { get; set; } = string.Empty;

        public int MonthlyPlacementOrderQuantity { get; set; }

        public int YearlyPlacementOrderQuantity { get; set; } 

        public DateTime DateOfPlacementOrder { get; set; }

        public DateTime TargetedDeliveryDate { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string ArrivalLocation { get; set; } = string.Empty;

        public string ModeOfPayment { get; set; } = string.Empty;

        public int EProcurementPaymentAccountNumber { get; set; }

        public String ProcurementPaymentAddress { get; set; } = string.Empty;

        public int AmountOfFirstPayment { get; set; }

        public int AmountOfSecondPayment { get; set; }

        public DateTime ReceivedDateOfFirstPayment { get; set; }

        public DateTime ReceivedDateOfSecondPayment { get; set; }

        public int TotalMonthlyEXpenditure { get; set; }

        public int TotalYearlyEXpenditure { get; set; }
    }
}
    
