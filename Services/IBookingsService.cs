using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.BookingsService
{
    public interface IBookingsService
    {

        public Task<List<Bookings>> GetAllBookings();

        public Task<Bookings> GetSingleBookByNameOfBooking(string nameofbooking);

        public Task<Bookings> GetSingleBookByNameOfBooker(string nameofbooker);

        public Task<Bookings> GetSingleBookByTicketType(string tickettype);

        public Task<Bookings> GetSingleBookByFixedPriceOfTicket(int fixedpriceofticket);

        public Task<Bookings> GetSingleBookByTicketId(int ticketid);

        public Task<Bookings> GetSingleBookByNumberOfTicketsPurchased(int numberofticketspurchased);

        public Task<Bookings> GetSingleBookByBooking(DateTime booking);

        public Task<Bookings> GetSingleBookByTicketPurchase(DateTime ticketpurchase);

        public Task<Bookings> GetSingleBookByModeOfPayment(string modeofpayment);

        public Task<Bookings> GetSingleBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber);

        public Task<Bookings> GetSingleBookByTicketPaymentAddress(string ticketpaymentaddress);

        public Task<Bookings> GetSingleBookByBookingAddress(string bookingaddress);

        public Task<Bookings> GetSingleBookByAmountOfFirstPayment(int amountoffirstpayment);

        public Task<Bookings> GetSingleBookByAmountOfSecondPayment(int amountofsecondpayment);

        public Task<Bookings> GetSingleBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment);

        public Task<Bookings> GetSingleBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment);

        public Task<Bookings> GetSingleBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure);

        public Task<Bookings> GetSingleBookByTotalYearlyExpenditure(int totalyearlyexpenditure);

        public Task<ActionResult<List<Bookings>>> AddBookings(Bookings bookings);

        public Task<List<Bookings>> UpdateBookByNameOfBooking(string nameofbooking, Bookings request);

        public Task<List<Bookings>> UpdateBookByNameOfBooker(string nameofbooker, Bookings request);

        public Task<List<Bookings>> UpdateBookByTicketType(string tickettype, Bookings request);

        public Task<List<Bookings>> UpdateBookByFixedPriceOfTicket(int fixedpriceofticket, Bookings request);

        public Task<List<Bookings>> UpdateBookByTicketId(int ticketid, Bookings request);

        public Task<List<Bookings>> UpdateBookByNumberOfTicketsPurchased(int numberofticketspurchased, Bookings request);

        public Task<List<Bookings>> UpdateBookByBooking(DateTime booking, Bookings request);

        public Task<List<Bookings>> UpdateBookByTicketPurchase(DateTime ticketpurchase, Bookings request);

        public Task<List<Bookings>> UpdateBookByModeOfPayment(string modeofpayment, Bookings request);

        public Task<List<Bookings>> UpdateBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber, Bookings request);

        public Task<List<Bookings>> UpdateBookByTicketPaymentAddress(string ticketpaymentaddress, Bookings request);

        public Task<List<Bookings>> UpdateBookByBookingAddress(string bookingaddress, Bookings request);

        public Task<List<Bookings>> UpdateBookByAmountOfFirstPayment(int amountoffirstpayment, Bookings request);

        public Task<List<Bookings>> UpdateBookByAmountOfSecondPayment(int amountofsecondpayment, Bookings request);

        public Task<List<Bookings>> UpdateBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment, Bookings request);

        public Task<List<Bookings>> UpdateBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment, Bookings request);

        public Task<List<Bookings>> UpdateBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure, Bookings request);

        public Task<List<Bookings>> UpdateBookByTotalYearlyExpenditure(int totalyearlyexpenditure, Bookings request);

        public Task<List<Bookings>> DeleteBookByNameOfBooking(string nameofbooking);

        public Task<List<Bookings>> DeleteBookByNameOfBooker(string nameofbooker);

        public Task<List<Bookings>> DeleteBookByTicketType(string tickettype);

        public Task<List<Bookings>> DeleteBookByFixedPriceOfTicket(int fixedpriceofticket);

        public Task<List<Bookings>> DeleteBookByTicketId(int ticketid);

        public Task<List<Bookings>> DeleteBookByNumberOfTicketsPurchased(int numberofticketspurchased);

        public Task<List<Bookings>> DeleteBookByBooking(DateTime booking);

        public Task<List<Bookings>> DeleteBookByTicketPurchase(DateTime ticketpurchase);

        public Task<List<Bookings>> DeleteBookByModeOfPayment(string modeofpayment);

        public Task<List<Bookings>> DeleteBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber);

        public Task<List<Bookings>> DeleteBookByTicketPaymentAddress(string ticketpaymentaddress);

        public Task<List<Bookings>> DeleteBookByBookingAddress(string bookingaddress);

        public Task<List<Bookings>> DeleteBookByAmountOfFirstPayment(int amountoffirstpayment);

        public Task<List<Bookings>> DeleteBookByAmountOfSecondPayment(int amountofsecondpayment);

        public Task<List<Bookings>> DeleteBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment);

        public Task<List<Bookings>> DeleteBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment);

        public Task<List<Bookings>> DeleteBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure);

        public Task<List<Bookings>> DeleteBookByTotalYearlyExpenditure(int totalyearlyexpenditure);

    }
}



