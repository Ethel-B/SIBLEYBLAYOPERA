using System;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Services;
using SIBLEYBLAYOPERA.Services.BookingsService;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;


namespace SIBLEYBLAYOPERA.Services.BookingsService
{
    public class BookingsService : IBookingsService
    {
    private readonly DataContext _context;

    public BookingsService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Bookings>> GetAllBookings()
    {
        var bookings = await _context.Bookings.ToListAsync();
        return bookings;
    }

    public async Task<Bookings> GetSingleBookByNameOfBooking(string nameofbooking)
    {
        var book = await _context.Bookings.FindAsync(nameofbooking);
        if (book is null)
            return null;

        return book;
    }

        public async Task<Bookings> GetSingleBookByNameOfBooker(string nameofbooker)
        {
            var book = await _context.Bookings.FindAsync(nameofbooker);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByTicketType(string tickettype)
        {
            var book = await _context.Bookings.FindAsync(tickettype);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByFixedPriceOfTicket(int fixedpriceofticket)
        {
            var book = await _context.Bookings.FindAsync(fixedpriceofticket);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByTicketId(int ticketid)
        {
            var book = await _context.Bookings.FindAsync(ticketid);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByNumberOfTicketsPurchased(int numberofticketspurchased)
        {
            var book = await _context.Bookings.FindAsync(numberofticketspurchased);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByBooking(DateTime booking)
        {
            var book = await _context.Bookings.FindAsync(booking);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByTicketPurchase(DateTime ticketpurchase)
        {
            var book = await _context.Bookings.FindAsync(ticketpurchase);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByModeOfPayment(string modeofpayment)
        {
            var book = await _context.Bookings.FindAsync(modeofpayment);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber)
        {
            var book = await _context.Bookings.FindAsync(eticketpaymentaccountnumber);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByTicketPaymentAddress(string ticketpaymentaddress)
        {
            var book = await _context.Bookings.FindAsync(ticketpaymentaddress);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByBookingAddress(string bookingaddress)
        {
            var book = await _context.Bookings.FindAsync(bookingaddress);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var book = await _context.Bookings.FindAsync(amountoffirstpayment);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var book = await _context.Bookings.FindAsync(amountofsecondpayment);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var book = await _context.Bookings.FindAsync(receiveddateoffirstpayment);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var book = await _context.Bookings.FindAsync(receiveddateofsecondpayment);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var book = await _context.Bookings.FindAsync(totalmonthlyexpenditure);
            if (book is null)
                return null;

            return book;
        }

        public async Task<Bookings> GetSingleBookByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var book = await _context.Bookings.FindAsync(totalyearlyexpenditure);
            if (book is null)
                return null;

            return book;
        }

        public async Task<ActionResult<List<Bookings>>> AddBookings(Bookings bookings)
        {
            _context.Bookings.Add(bookings);
            await _context.SaveChangesAsync();
            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByNameOfBooking(string nameofbooking, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(nameofbooking);
            if (book is null)
                return null;

            book.NameOfBooking = request.NameOfBooking;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByNameOfBooker(string nameofbooker, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(nameofbooker);
            if (book is null)
                return null;

            book.NameOfBooker = request.NameOfBooker;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByTicketType(string tickettype, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(tickettype);
            if (book is null)
                return null;

            book.TicketType = request.TicketType;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByFixedPriceOfTicket(int fixedpriceofticket, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(fixedpriceofticket);
            if (book is null)
                return null;

            book.FixedPriceOfTicket = request.FixedPriceOfTicket;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByTicketId(int ticketid, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(ticketid);
            if (book is null)
                return null;

            book.TicketId = request.TicketId;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByNumberOfTicketsPurchased(int numberofticketspurchased, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(numberofticketspurchased);
            if (book is null)
                return null;

            book.NumberOfTicketsPurchased = request.NumberOfTicketsPurchased;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByBooking(DateTime booking, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(booking);
            if (book is null)
                return null;

            book.Booking = request.Booking;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByTicketPurchase(DateTime ticketpurchase, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(ticketpurchase);
            if (book is null)
                return null;

            book.TicketPurchase = request.TicketPurchase;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByModeOfPayment(string modeofpayment, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(modeofpayment);
            if (book is null)
                return null;

            book.ModeOfPayment = request.ModeOfPayment;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(eticketpaymentaccountnumber);
            if (book is null)
                return null;

            book.ETicketPaymentAccountNumber = request.ETicketPaymentAccountNumber;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByTicketPaymentAddress(string ticketpaymentaddress, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(ticketpaymentaddress);
            if (book is null)
                return null;

            book.TicketPaymentAddress = request.TicketPaymentAddress;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByBookingAddress(string bookingaddress, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(bookingaddress);
            if (book is null)
                return null;

            book.BookingAddress = request.BookingAddress;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByAmountOfFirstPayment(int amountoffirstpayment, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(amountoffirstpayment);
            if (book is null)
                return null;

            book.AmountOfFirstPayment = request.AmountOfFirstPayment;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByAmountOfSecondPayment(int amountofsecondpayment, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(amountofsecondpayment);
            if (book is null)
                return null;

            book.AmountOfSecondPayment = request.AmountOfSecondPayment;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(receiveddateoffirstpayment);
            if (book is null)
                return null;

            book.ReceivedDateOfFirstPayment = request.ReceivedDateOfFirstPayment;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(receiveddateofsecondpayment);
            if (book is null)
                return null;

            book.ReceivedDateOfSecondPayment = request.ReceivedDateOfSecondPayment;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(totalmonthlyexpenditure);
            if (book is null)
                return null;

            book.TotalMonthlyExpenditure = request.TotalMonthlyExpenditure;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> UpdateBookByTotalYearlyExpenditure(int totalyearlyexpenditure, Bookings request)
        {
            var book = await _context.Bookings.FindAsync(totalyearlyexpenditure);
            if (book is null)
                return null;

            book.TotalYearlyExpenditure = request.TotalYearlyExpenditure;
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }

        public async Task<List<Bookings>> DeleteBookByNameOfBooking(string nameofbooking)
        {
            var book = await _context.Bookings.FindAsync(nameofbooking);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByNameOfBooker(string nameofbooker)
        {
            var book = await _context.Bookings.FindAsync(nameofbooker);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByTicketType(string tickettype)
        {
            var book = await _context.Bookings.FindAsync(tickettype);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByFixedPriceOfTicket(int fixedpriceofticket)
        {
            var book = await _context.Bookings.FindAsync(fixedpriceofticket);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByTicketId(int ticketid)
        {
            var book = await _context.Bookings.FindAsync(ticketid);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByNumberOfTicketsPurchased(int numberofticketspurchased)
        {
            var book = await _context.Bookings.FindAsync(numberofticketspurchased);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByBooking(DateTime booking)
        {
            var book = await _context.Bookings.FindAsync(booking);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByTicketPurchase(DateTime ticketpurchase)
        {
            var book = await _context.Bookings.FindAsync(ticketpurchase);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByModeOfPayment(string modeofpayment)
        {
            var book = await _context.Bookings.FindAsync(modeofpayment);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByETicketPaymentAccountNumber(int eticketpaymentaccountnumber)
        {
            var book = await _context.Bookings.FindAsync(eticketpaymentaccountnumber);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByTicketPaymentAddress(string ticketpaymentaddress)
        {
            var book = await _context.Bookings.FindAsync(ticketpaymentaddress);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByBookingAddress(string bookingaddress)
        {
            var book = await _context.Bookings.FindAsync(bookingaddress);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByAmountOfFirstPayment(int amountoffirstpayment)
        {
            var book = await _context.Bookings.FindAsync(amountoffirstpayment);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByAmountOfSecondPayment(int amountofsecondpayment)
        {
            var book = await _context.Bookings.FindAsync(amountofsecondpayment);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByReceivedDateOfFirstPayment(DateTime receiveddateoffirstpayment)
        {
            var book = await _context.Bookings.FindAsync(receiveddateoffirstpayment);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByReceivedDateOfSecondPayment(DateTime receiveddateofsecondpayment)
        {
            var book = await _context.Bookings.FindAsync(receiveddateofsecondpayment);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var book = await _context.Bookings.FindAsync(totalmonthlyexpenditure);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();

        }

        public async Task<List<Bookings>> DeleteBookByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var book = await _context.Bookings.FindAsync(totalyearlyexpenditure);
            if (book is null)
                return null;

            _context.Bookings.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Bookings.ToListAsync();
        }
        }
   }


