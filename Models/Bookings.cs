namespace SIBLEYBLAYOPERA.Models
{
    // A Booking and reservations log for the opera.

    public class Bookings
    {
        public int id { get; set; }

        public int? UsersId { get; set; }

        public Users Users { get; set; }

        public string NameOfBooking { get; set; } = string.Empty;

        public string NameOfBooker { get; set; } = string.Empty;

        public string TicketType { get; set; } = string.Empty;

        public int FixedPriceOfTicket { get; set; } 

        public int TicketId { get; set; }

        public int NumberOfTicketsPurchased { get; set; }

        public DateTime Booking { get; set; }

        public DateTime TicketPurchase { get; set; }

        public string ModeOfPayment { get; set; } = string.Empty;

        public int ETicketPaymentAccountNumber { get; set; }

        public String TicketPaymentAddress { get; set; } = string.Empty;

        public string BookingAddress { get; set; } = string.Empty;
        // Which Opera house or venue, that the reservation has been made to.

        public int AmountOfFirstPayment { get; set; }

        public int AmountOfSecondPayment { get; set; }

        public DateTime ReceivedDateOfFirstPayment { get; set; }

        public DateTime ReceivedDateOfSecondPayment { get; set; }

        public int TotalMonthlyExpenditure { get; set; }

        public int TotalYearlyExpenditure { get; set; }
    }
}

