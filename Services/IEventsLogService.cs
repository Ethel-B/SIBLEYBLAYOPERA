using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.EventsLogService
{
    public interface IEventsLogService
    {

        public Task<List<Eventslog>> GetAllLogs();

        public Task<Eventslog> GetSingleLogByEventName(string eventname);

        public Task<Eventslog> GetSingleLogByAddress(string address);

        public Task<Eventslog> GetSingleLogByRolePerformers(string roleperformers);

        public Task<Eventslog> GetSingleLogByNameOfRolePerformer(string nameofroleperformer);

        public Task<Eventslog> GetSingleLogByTitleOfRolePerformer(string titleofroleperformer);

        public Task<Eventslog> GetSingleLogByEventDetails(DateTime eventdetails);

        public Task<Eventslog> GetSingleLogByAudienceSeatingCapacity(int audienceseatingcapacity);

        public Task<Eventslog> GetSingleLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno);

        public Task<Eventslog> GetSingleLogByUnexpectedAudienceSeatingNo(int unexpectedaudienceseatingno);

        public Task<Eventslog> GetSingleLogByEventPrice(int eventprice);

        public Task<Eventslog> GetSingleLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure);

        public Task<Eventslog> GetSingleLogByTotalYearlyExpenditure(int totalyearlyexpenditure);

        public Task<ActionResult<List<Eventslog>>> AddEvents(Eventslog events);

        public Task<List<Eventslog>> UpdateLogByEventName(string eventname, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByAddress(string address, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByRolePerformers(string roleperformers, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByNameOfRolePerformer(string nameofroleperformer, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByTitleOfRolePerformer(string titleofroleperformer, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByEventDetails(DateTime eventdetails, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByAudienceSeatingCapacity(int audienceseatingcapacity, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByUnExpectedAudienceSeatingNo(int unexpectedaudienceseatingno, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByEventPrice(int eventprice, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure, Eventslog request);

        public Task<List<Eventslog>> UpdateLogByTotalYearlyExpenditure(int totalyearlyexpenditure, Eventslog request);

        public Task<List<Eventslog>> DeleteLogByEventName(string eventname);

        public Task<List<Eventslog>> DeleteLogByAddress(string address);

        public Task<List<Eventslog>> DeleteLogByRolePerformers(string roleperformers);

        public Task<List<Eventslog>> DeleteLogByNameOfRolePerformer(string nameofroleperformer);

        public Task<List<Eventslog>> DeleteLogByTitleOfRolePerformer(string titleofroleperformer);

        public Task<List<Eventslog>> DeleteLogByEventDetails(DateTime eventdetails);

        public Task<List<Eventslog>> DeleteLogByAudienceSeatingCapacity(int audienceseatingcapacity);

        public Task<List<Eventslog>> DeleteLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno);

        public Task<List<Eventslog>> DeleteLogByUnExpectedAudienceSeatingNo(int unexpectedaudienceseatingno);

        public Task<List<Eventslog>> DeleteLogByEventPrice(int eventprice);

        public Task<List<Eventslog>> DeleteLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure);

        public Task<List<Eventslog>> DeleteLogByTotalYearlyExpenditure(int totalyearlyexpenditure);
           
        }
    }



