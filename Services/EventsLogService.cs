using System;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Services;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using SIBLEYBLAYOPERA.Services.EventsLogService;

namespace SIBLEYBLAYOPERA.Services.EventsLogService
{
    public class EventsLogService: IEventsLogService
    {
        private readonly DataContext _context;

        public EventsLogService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Eventslog>> GetAllLogs()
        {
            var logs = await _context.EventsLog.ToListAsync();
            return logs;
        }

        public async Task<Eventslog> GetSingleLogByEventName(string eventname)
        {
            var log = await _context.EventsLog.FindAsync(eventname);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByAddress(string address)
        {
            var log = await _context.EventsLog.FindAsync(address);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByRolePerformers(string roleperformers)
        {
            var log = await _context.EventsLog.FindAsync(roleperformers);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByNameOfRolePerformer(string nameofroleperformer)
        {
            var log = await _context.EventsLog.FindAsync(nameofroleperformer);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByTitleOfRolePerformer(string titleofroleperformer)
        {
            var log = await _context.EventsLog.FindAsync(titleofroleperformer);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByEventDetails(DateTime eventdetails)
        {
            var log = await _context.EventsLog.FindAsync(eventdetails);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByAudienceSeatingCapacity(int audienceseatingcapacity)
        {
            var log = await _context.EventsLog.FindAsync(audienceseatingcapacity);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno)
        {
            var log = await _context.EventsLog.FindAsync(expectedaudienceseatingno);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByUnexpectedAudienceSeatingNo(int unexpectedaudienceseatingno)
        {
            var log = await _context.EventsLog.FindAsync(unexpectedaudienceseatingno);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByEventPrice(int eventprice)
        {
            var log = await _context.EventsLog.FindAsync(eventprice);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var log = await _context.EventsLog.FindAsync(totalmonthlyexpenditure);
            if (log is null)
                return null;

            return log;
        }

        public async Task<Eventslog> GetSingleLogByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var log = await _context.EventsLog.FindAsync(totalyearlyexpenditure);
            if (log is null)
                return null;

            return log;
        }

        public async Task<ActionResult<List<Eventslog>>> AddEvents(Eventslog events)
        {
            _context.EventsLog.Add(events);
            await _context.SaveChangesAsync();
            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByEventName(string eventname, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(eventname);
            if (log is null)
                return null;

            log.EventName = request.EventName;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByAddress(string address, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(address);
            if (log is null)
                return null;

            log.Address = request.Address;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByRolePerformers(string roleperformers, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(roleperformers);
            if (log is null)
                return null;

            log.RolePerformers = request.RolePerformers;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByNameOfRolePerformer(string nameofroleperformer, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(nameofroleperformer);
            if (log is null)
                return null;

            log.NameOfRolePerformer = request.NameOfRolePerformer;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByTitleOfRolePerformer(string titleofroleperformer, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(titleofroleperformer);
            if (log is null)
                return null;

            log.TitleOfRolePerformer = request.TitleOfRolePerformer;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByEventDetails(DateTime eventdetails, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(eventdetails);
            if (log is null)
                return null;

            log.EventDetails = request.EventDetails;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByAudienceSeatingCapacity(int audienceseatingcapacity, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(audienceseatingcapacity);
            if (log is null)
                return null;

            log.AudienceSeatingCapacity = request.AudienceSeatingCapacity;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(expectedaudienceseatingno);
            if (log is null)
                return null;

            log.ExpectedAudienceSeatingNo = request.ExpectedAudienceSeatingNo;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByUnExpectedAudienceSeatingNo(int unexpectedaudienceseatingno, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(unexpectedaudienceseatingno);
            if (log is null)
                return null;

            log.UnExpectedAudienceSeatingNo = request.UnExpectedAudienceSeatingNo;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByEventPrice(int eventprice, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(eventprice);
            if (log is null)
                return null;

            log.EventPrice = request.EventPrice;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(totalmonthlyexpenditure);
            if (log is null)
                return null;

            log.TotalMonthlyExpenditure = request.TotalMonthlyExpenditure;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> UpdateLogByTotalYearlyExpenditure(int totalyearlyexpenditure, Eventslog request)
        {
            var log = await _context.EventsLog.FindAsync(totalyearlyexpenditure);
            if (log is null)
                return null;

            log.TotalYearlyExpenditure = request.TotalYearlyExpenditure;
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();
        }

        public async Task<List<Eventslog>> DeleteLogByEventName(string eventname)
        {
            var log = await _context.EventsLog.FindAsync(eventname);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByAddress(string address)
        {
            var log = await _context.EventsLog.FindAsync(address);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByRolePerformers(string roleperformers)
        {
            var log = await _context.EventsLog.FindAsync(roleperformers);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByNameOfRolePerformer(string nameofroleperformer)
        {
            var log = await _context.EventsLog.FindAsync(nameofroleperformer);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByTitleOfRolePerformer(string titleofroleperformer)
        {
            var log = await _context.EventsLog.FindAsync(titleofroleperformer);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByEventDetails(DateTime eventdetails)
        {
            var log = await _context.EventsLog.FindAsync(eventdetails);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByAudienceSeatingCapacity(int audienceseatingcapacity)
        {
            var log = await _context.EventsLog.FindAsync(audienceseatingcapacity);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno)
        {
            var log = await _context.EventsLog.FindAsync(expectedaudienceseatingno);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByUnExpectedAudienceSeatingNo(int unexpectedaudienceseatingno)
        {
            var log = await _context.EventsLog.FindAsync(unexpectedaudienceseatingno);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByEventPrice(int eventprice)
        {
            var log = await _context.EventsLog.FindAsync(eventprice);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var log = await _context.EventsLog.FindAsync(totalmonthlyexpenditure);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }

        public async Task<List<Eventslog>> DeleteLogByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var log = await _context.EventsLog.FindAsync(totalyearlyexpenditure);
            if (log is null)
                return null;

            _context.EventsLog.Remove(log);
            await _context.SaveChangesAsync();

            return await _context.EventsLog.ToListAsync();

        }
    }
}

