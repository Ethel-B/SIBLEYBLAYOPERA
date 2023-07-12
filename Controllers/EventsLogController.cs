using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using System.Net;
using System.Text;
using SIBLEYBLAYOPERA.Services.EventsLogService;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsLogController : ControllerBase
    {
        private readonly IEventsLogService _eventsLogService;

        public EventsLogController(IEventsLogService eventsLogService)
        {
            _eventsLogService = eventsLogService;
        }

     
        [HttpGet]
        public async Task<ActionResult<List<Eventslog>>> GetAllLogs()
        {
            return await _eventsLogService.GetAllLogs();
        }

        [HttpGet("GetSingleLogByEventName/{EventName}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByEventName(string eventname)
        {
            var result = await _eventsLogService.GetSingleLogByEventName(eventname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByAddress/{Address}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByAddress(string address)
        {
            var result = await _eventsLogService.GetSingleLogByAddress(address);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByRolePerformers/{RolePerformers}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByRolePerformers(string roleperformers)
        {
            var result = await _eventsLogService.GetSingleLogByRolePerformers(roleperformers);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByNameOfRolePerformer/{NameOfRolePerformer}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByNameOfRolePerformer(string nameofroleperformer)
        {
            var result = await _eventsLogService.GetSingleLogByNameOfRolePerformer(nameofroleperformer);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByTitleOfRolePerformer/{TitleOfRolePerformer}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByTitleOfRolePerformer(string titleofroleperformer)
        {
            var result = await _eventsLogService.GetSingleLogByTitleOfRolePerformer(titleofroleperformer);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByEventDetails/{EventDetails}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByEventDetails(DateTime eventdetails)
        {
            var result = await _eventsLogService.GetSingleLogByEventDetails(eventdetails);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByAudienceSeatingCapacity/{AudienceSeatingCapacity}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByAudienceSeatingCapacity(int audienceseatingcapacity)
        {
            var result = await _eventsLogService.GetSingleLogByAudienceSeatingCapacity(audienceseatingcapacity);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByExpectedAudienceSeatingNo/{ExpectedAudienceSeatingNo}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno)
        {
            var result = await _eventsLogService.GetSingleLogByExpectedAudienceSeatingNo(expectedaudienceseatingno);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByUnExpectedAudienceSeatingNo/{UnExpectedAudienceSeatingNo}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByUnexpectedAudienceSeatingNo(int unexpectedaudienceseatingno)
        {
            var result = await _eventsLogService.GetSingleLogByUnexpectedAudienceSeatingNo(unexpectedaudienceseatingno);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByEventPrice/{EventPrice}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByEventPrice(int eventprice)
        {
            var result = await _eventsLogService.GetSingleLogByEventPrice(eventprice);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByTotalMonthlyExpenditure/{TotalMonthlyExpenditure}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var result = await _eventsLogService.GetSingleLogByTotalMonthlyExpenditure(totalmonthlyexpenditure);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleLogByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<Eventslog>> GetSingleLogByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var result = await _eventsLogService.GetSingleLogByTotalYearlyExpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Eventslog>>> AddEvents(Eventslog events)
        {
            var result = await _eventsLogService.AddEvents(events);
            return Ok(result);
        }

        [HttpPut("UpdateLogByEventName/{EventName}")]
         public async Task<ActionResult<List<Eventslog>>> UpdateLogByEventName(string eventname, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByEventName(eventname, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByAddress/{Address}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByAddress(string address, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByAddress(address, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByRolePerformers/{RolePerformers}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByRolePerformers(string roleperformers, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByRolePerformers(roleperformers, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByNameOfRolePerformer/{NameOfRolePerformer}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByNameOfRolePerformer(string nameofroleperformer, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByNameOfRolePerformer(nameofroleperformer, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByTitleOfRolePerformer/{TitleOfRolePerformer}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByTitleOfRolePerformer(string titleofroleperformer, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByNameOfRolePerformer(titleofroleperformer, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByEventDetails/{EventDetails}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByEventDetails(DateTime eventdetails, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByEventDetails(eventdetails, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByAudienceSeatingCapacity/{AudienceSeatingCapacity}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByAudienceSeatingCapacity(int audienceseatingcapacity, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByAudienceSeatingCapacity(audienceseatingcapacity, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByExpectedAudienceSeatingNo/{ExpectedAudienceSeatingNo}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByExpectedAudienceSeatingNo(expectedaudienceseatingno, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByUnExpectedaudienceseatingno/{UnExpectedAudienceSeatingNo}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByunexpectedaudienceseatingno(int unexpectedaudienceseatingno, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByUnExpectedAudienceSeatingNo(unexpectedaudienceseatingno, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByEventPrice/{EventPrice}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByEventPrice(int eventprice, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByEventPrice(eventprice, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByTotalMonthlyExpenditure/{TotalMonthlyExpenditure}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByTotalMonthlyExpenditure(totalmonthlyexpenditure, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpPut("UpdateLogByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<List<Eventslog>>> UpdateLogByTotalYearlyExpenditure(int totalyearlyexpenditure, Eventslog request)
        {
            var result = await _eventsLogService.UpdateLogByTotalYearlyExpenditure(totalyearlyexpenditure, request);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        
        [HttpDelete("DeleteLogByEventName/{EventName}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByEventName(string eventname)
        {
            var result = await _eventsLogService.DeleteLogByEventName(eventname);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByAddress/{Address}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByAddress(string address)
        {
            var result = await _eventsLogService.DeleteLogByAddress(address);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByRolePerformers/{RolePerformers}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByRolePerformers(string roleperformers)
        {
            var result = await _eventsLogService.DeleteLogByRolePerformers(roleperformers);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByNameOfRolePerformer/{NameOfRolePerformer}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByNameOfRolePerformer(string nameofroleperformer)
        {
            var result = await _eventsLogService.DeleteLogByNameOfRolePerformer(nameofroleperformer);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByTitleOfRolePerformer/{TitleOfRolePerformer}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByTitleOfRolePerformer(string titleofroleperformer)
        {
            var result = await _eventsLogService.DeleteLogByTitleOfRolePerformer(titleofroleperformer);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByEventDetails/{EventDetails}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByEventDetails(DateTime eventdetails)
        {
            var result = await _eventsLogService.DeleteLogByEventDetails(eventdetails);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByAudienceSeatingCapacity/{AudienceSeatingCapacity}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByAudienceSeatingCapacity(int audienceseatingcapacity)
        {
            var result = await _eventsLogService.DeleteLogByAudienceSeatingCapacity(audienceseatingcapacity);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByExpectedAudienceSeatingNo/{ExpectedAudienceSeatingNo}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByExpectedAudienceSeatingNo(int expectedaudienceseatingno)
        {
            var result = await _eventsLogService.DeleteLogByExpectedAudienceSeatingNo(expectedaudienceseatingno);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByUnExpectedAudienceSeatingNo/{UnExpectedAudienceSeatingNo}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByUnExpectedAudienceSeatingNo(int unexpectedaudienceseatingno)
        {
            var result = await _eventsLogService.DeleteLogByUnExpectedAudienceSeatingNo(unexpectedaudienceseatingno);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByEventPrice/{EventPrice}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByEventPrice(int eventprice)
        {
            var result = await _eventsLogService.DeleteLogByEventPrice(eventprice);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByTotalMonthlyExpenditure/{TotalMonthlyExpenditure}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByTotalMonthlyExpenditure(int totalmonthlyexpenditure)
        {
            var result = await _eventsLogService.DeleteLogByTotalMonthlyExpenditure(totalmonthlyexpenditure);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteLogByTotalYearlyExpenditure/{TotalYearlyExpenditure}")]
        public async Task<ActionResult<List<Eventslog>>> DeleteLogByTotalYearlyExpenditure(int totalyearlyexpenditure)
        {
            var result = await _eventsLogService.DeleteLogByTotalYearlyExpenditure(totalyearlyexpenditure);
            if (result is null)
                return NotFound("Log not found.");

            return Ok(result);
        }
    }
}

