using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using System.Net;
using System.Text;
using System.Net.Sockets;
using SIBLEYBLAYOPERA.Migrations;
using SIBLEYBLAYOPERA.Services.BookingsService;
using Bookings = SIBLEYBLAYOPERA.Models.Bookings;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingsService _bookingsService;

        public BookingsController(IBookingsService bookingsService)
        {
            _bookingsService = bookingsService;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Bookings>>> GetAllBookings()
        {
            return await _bookingsService.GetAllBookings();
        }

        [HttpGet("GetSingleBookByNameOfBooking/{NameOfBooking}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByNameOfBooking(string nameofbooking)
        {
            var result = await _bookingsService.GetSingleBookByNameOfBooking(nameofbooking);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByNameOfBooker/{NameOfBooker}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByNameOfBooker(string nameofbooker)
        {
            var result = await _bookingsService.GetSingleBookByNameOfBooker(nameofbooker);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByTicketType/{TicketType}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByTicketType(string tickettype)
        {
            var result = await _bookingsService.GetSingleBookByTicketType(tickettype);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByFixedPriceOfTicket/{FixedPriceOfTicket}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByFixedPriceOfTicket(int fixedpriceofticket)
        {
            var result = await _bookingsService.GetSingleBookByFixedPriceOfTicket(fixedpriceofticket);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByTicketId/{TicketId}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByTicketId(int ticketid)
        {
            var result = await _bookingsService.GetSingleBookByTicketId(ticketid);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByNumberOfTicketsPurchased/{NumberOfTicketsPurchased}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByNumberOfTicketsPurchased(int numberofticketspurchased)
        {
            var result = await _bookingsService.GetSingleBookByNumberOfTicketsPurchased(numberofticketspurchased);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByBooking/{Booking}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByBooking(DateTime booking)
        {
            var result = await _bookingsService.GetSingleBookByBooking(booking);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByTicketPurchase/{TicketPurchase}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByTicketPurchase(DateTime ticketpurchase)
        {
            var result = await _bookingsService.GetSingleBookByTicketPurchase(ticketpurchase);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByModeOfPayment(string modeofpayment)
        {
            var result = await _bookingsService.GetSingleBookByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByETicketPaymentAccountNumber/{ETicketPaymentAccountNumber}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber)
        {
            var result = await _bookingsService.GetSingleBookByETicketPaymentAccountNumber(eticketpaymentaccountnumber);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByTicketPaymentAddress/{TicketPaymentAddress}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByTicketPaymentAddress(string ticketpaymentaddress)
        {
            var result = await _bookingsService.GetSingleBookByTicketPaymentAddress(ticketpaymentaddress);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByBookingAddress/{BookingAddress}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByBookingAddress(string bookingaddress)
        {
            var result = await _bookingsService.GetSingleBookByBookingAddress(bookingaddress);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var result = await _bookingsService.GetSingleBookByAmountOfFirstPayment(amountoffirstpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var result = await _bookingsService.GetSingleBookByAmountOfSecondPayment(amountofsecondpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByReceivedDateOfFirstPayment/{ReceivedDateOfFirstPayment}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var result = await _bookingsService.GetSingleBookByReceivedDateOfFirstPayment(receiveddateoffirstpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByReceivedDateOfSecondPayment/{ReceivedDateOfSecondPayment}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var result = await _bookingsService.GetSingleBookByReceivedDateOfSecondPayment(receiveddateofsecondpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByTotalMonthlyExpenditure/{TotalMonthlyExpenditure}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var result = await _bookingsService.GetSingleBookByTotalMonthlyExpenditure(totalmonthlyexpenditure);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleBookByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<Bookings>> GetSingleBookByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var result = await _bookingsService.GetSingleBookByTotalYearlyExpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

     
        [HttpPost]
        public async Task<ActionResult<List<Bookings>>> AddBookings(Bookings  bookings)
        {
            var result = await _bookingsService.AddBookings(bookings);
            return Ok(result);
        }

       
        [HttpPut("UpdateBookByNameOfBooking/{NameOfBooking}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByNameOfBooking(string nameofbooking, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByNameOfBooking(nameofbooking, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByNameOfBooker/{NameOfBooker}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByNameOfBooker(string nameofbooker, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByNameOfBooker(nameofbooker, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByTicketType/{TicketType}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByTicketType(string tickettype, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByTicketType(tickettype, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByFixedPriceOfTicket/{FixedPriceOfTicket}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByFixedPriceOfTicket(int fixedpriceofticket, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByFixedPriceOfTicket(fixedpriceofticket, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByTicketId/{TicketId}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByTicketId(int ticketid, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByTicketId(ticketid, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBook/{NumberOfTicketsPurchased}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByNumberOfTicketsPurchased(int numberofticketspurchased, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByNumberOfTicketsPurchased(numberofticketspurchased, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByBooking/{Booking}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByBooking(DateTime booking, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByBooking(booking, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByTicketPurchase/{TicketPurchase}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByTicketPurchase(DateTime ticketpurchase, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByTicketPurchase(ticketpurchase, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByModeOfPayment(string modeofpayment, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByModeOfPayment(modeofpayment, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByETicketPaymentAccountNumber/{ETicketPaymentAccountNumber}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByETicketPaymentAccountNumber(eticketpaymentaccountnumber, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByTicketPaymentAddress/{TicketPaymentAddress}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByTicketPaymentAddress(string ticketpaymentaddress, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByTicketPaymentAddress(ticketpaymentaddress, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByBookingAddress/{BookingAddress}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByBookingAddress(string bookingaddress, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByBookingAddress(bookingaddress, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByAmountOfFirstPayment(int amountoffirstpayment, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByAmountOfFirstPayment(amountoffirstpayment, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByAmountOfSecondPayment(int amountofsecondpayment, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByAmountOfSecondPayment(amountofsecondpayment, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByReceivedDateOfFirstPayment/{ReceivedDateOfFirstPayment}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByReceivedDateOfFirstPayment(receiveddateoffirstpayment, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByReceivedDateOfSecondPayment/{ReceivedDateOfSecondPayment}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByReceivedDateOfFirstPayment(receiveddateofsecondpayment, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByTotalMonthlyExpenditure/{TotalMonthlyExpenditure}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByTotalMonthlyExpenditure(totalmonthlyexpenditure, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

        [HttpPut("UpdateBookByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<List<Bookings>>> UpdateBookByTotalYearlyExpenditure(int totalyearlyexpenditure, Bookings request)
        {
            var result = await _bookingsService.UpdateBookByTotalYearlyExpenditure(totalyearlyexpenditure, request);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);
        }

       
        [HttpDelete("DeleteBookByNameOfBooking/{NameOfBooking}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByNameOfBooking(string nameofbooking)
        {
            var result = await _bookingsService.DeleteBookByNameOfBooking(nameofbooking);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByNameOfBooker/{NameOfBooker}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByNameOfBooker(string nameofbooker)
        {
            var result = await _bookingsService.DeleteBookByNameOfBooker(nameofbooker);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByTicketType/{TicketType}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByTicketType(string tickettype)
        {
            var result = await _bookingsService.DeleteBookByTicketType(tickettype);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByFixedPriceOfTicket/{FixedPriceOfTicket}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByFixedPriceOfTicket(int fixedpriceofticket)
        {
            var result = await _bookingsService.DeleteBookByFixedPriceOfTicket(fixedpriceofticket);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByTicketId/{TicketId}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByTicketId(int ticketid)
        {
            var result = await _bookingsService.DeleteBookByTicketId(ticketid);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByNumberOfTicketsPurchased/{NumberOfTicketsPurchased}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByNumberOfTicketsPurchased(int numberofticketspurchased)
        {
            var result = await _bookingsService.DeleteBookByNumberOfTicketsPurchased(numberofticketspurchased);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByBooking/{Booking}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByBooking(DateTime booking)
        {
            var result = await _bookingsService.DeleteBookByBooking(booking);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByTicketPurchase/{TicketPurchase}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByTicketPurchase(DateTime ticketpurchase)
        {
            var result = await _bookingsService.DeleteBookByTicketPurchase(ticketpurchase);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByModeOfPayment/{ModeOfPayment}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByModeOfPayment(string modeofpayment)
        {
            var result = await _bookingsService.DeleteBookByModeOfPayment(modeofpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByETicketPaymentAccountNumber/{ETicketPaymentAccountNumber}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber)
        {
            var result = await _bookingsService.DeleteBookByETicketPaymentAccountNumber(eticketpaymentaccountnumber);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByTicketPaymentAddress/{TicketPaymentAddress}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByTicketPaymentAddress(string ticketpaymentaddress)
        {
            var result = await _bookingsService.DeleteBookByTicketPaymentAddress(ticketpaymentaddress);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

      [HttpDelete("DeleteBookByBookingAddress/{BookingAddress}")]
      public async Task<ActionResult<List<Bookings>>> DeleteBookByBookingAddress(string bookingaddress)
        {
            var result = await _bookingsService.DeleteBookByBookingAddress(bookingaddress);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByAmountOfFirstPayment/{AmountOfFirstPayment}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var result = await _bookingsService.DeleteBookByAmountOfFirstPayment(amountoffirstpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByAmountOfSecondPayment/{AmountOfSecondPayment}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var result = await _bookingsService.DeleteBookByAmountOfSecondPayment(amountofsecondpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByReceivedDateOfFirstPayment/{ReceivedDateOfFirstPayment}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var result = await _bookingsService.DeleteBookByReceivedDateOfFirstPayment(receiveddateoffirstpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByReceivedDateOfSecondPayment/{ReceivedDateOfSecondPayment}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var result = await _bookingsService.DeleteBookByReceivedDateOfSecondPayment(receiveddateofsecondpayment);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByTotalMonthlyExpenditure/{TotalMonthlyExpenditure}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var result = await _bookingsService.DeleteBookByTotalMonthlyExpenditure(totalmonthlyexpenditure);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }

        [HttpDelete("DeleteBookByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<List<Bookings>>> DeleteBookByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var result = await _bookingsService.DeleteBookByTotalYearlyExpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Book not found.");

            return Ok(result);

        }
    }
}

