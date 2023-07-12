using Microsoft.AspNetCore.Mvc;
using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using System.Net;
using System.Text;
using SIBLEYBLAYOPERA.Migrations;
using SIBLEYBLAYOPERA.Services.DepartmentalProcurementsService;
using DepartmentalProcurements = SIBLEYBLAYOPERA.Models.DepartmentalProcurements;

namespace SIBLEYBLAYOPERA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentalProcurementsController : ControllerBase
    {
        private readonly IDepartmentalProcurementsService _departmentalprocurementsService;

        public DepartmentalProcurementsController(IDepartmentalProcurementsService departmentalprocurementsService)
        {
            _departmentalprocurementsService = departmentalprocurementsService;
        }

      
        [HttpGet]
        public async Task<ActionResult<List<DepartmentalProcurements>>> GetAllDepartmentalProcurements()
        {
            return await _departmentalprocurementsService.GetAllDepartmentalProcurements();
        }

        [HttpGet("GetSingleDepartmentalProcurementsByFirstname/{Firstname}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByFirstname(string firstname)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByFirstname(firstname);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByMiddlename/{Middlename}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByMiddlename(string middlename)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByMiddlename(middlename);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByLastname/{Lastname}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByLastname(string lastname)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByLastname(lastname);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByRoleTitle(string roletitle)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByRoleTitle(roletitle);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByStaffIDNumber(int staffidnumber)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByStaffIDNumber(staffidnumber);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByDepartment/{Department}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByDepartment(string department)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByDepartment(department);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementssByItem/{Item}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByItem(string item)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByItem(item);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByOrderQuantity/{OrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByOrderQuantity(int orderquantity)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByOrderQuantity(orderquantity);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByPresentQuantity/{PresentQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByPresentQuantity(int presentquantity)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByPresentQuantity(presentquantity);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByAbsentQuantity/{AbsentQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByAbsentQuantity(int absentquantity)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByAbsentQuantity(absentquantity);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByProcurementCenter/{ProcurementCenter}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByProcurementCenter(string procurementcenter)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByProcurementCenter(procurementcenter);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByTelephone/{Telephone}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByTelephone(int telephone)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByTelephone(telephone);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByAddress/{Address}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByAddress(string address)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByAddress(address);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByMonthlyPlacementOrderQuantity/{MonthlyPlacementOrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByMonthlyPlacementOrderQuantity(monthlyplacementorderquantity);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByYearlyPlacementOrderQuantity/{YearlyPlacementOrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByYearlyPlacementOrderQuantity(yearlyplacementorderquantity);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByDateOfPlacementOrder/{DateOfPlacementOrder}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByDateOfPlacementOrder(dateofplacementorder);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByTargetedDeliveryDate/{TargetedDeliveryDate}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByTargetedDeliveryDate(targeteddeliverydate);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByArrivalDate/{ArrivalDate}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByArrivalDate(arrivaldate);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

        [HttpGet("GetSingleDepartmentalProcurementsByArrivalLocation/{ArrivalLocation}")]
        public async Task<ActionResult<DepartmentalProcurements>> GetSingleDepartmentalProcurementsByArrivalLocation(string arrivallocation)
        {
            var result = await _departmentalprocurementsService.GetSingleDepartmentalProcurementsByArrivalLocation(arrivallocation);
            if (result is null)
                return NotFound("DepartmentalProcurements not found.");

            return Ok(result);
        }

      
        [HttpPost]
        public async Task<ActionResult<List<DepartmentalProcurements>>> AddDepartmentalProcurements(DepartmentalProcurements departmentalprocurements)
        {
            var result = await _departmentalprocurementsService.AddDepartmentalProcurements(departmentalprocurements);
            return Ok(result);
        }

     
        [HttpPut("UpdateDepartmentalProcurementsByFirstname/{Firstname}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByFirstname(string firstname, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByFirstname(firstname, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByMiddlename/{Middlename}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByMiddlename(string middlename, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByMiddlename(middlename, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByLastname/{Lastname}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByLastname(string lastname, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByLastname(lastname, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByRoleTitle(string roleTitle, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByRoleTitle(roleTitle, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByStaffIDNumber(int staffidnumber, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByStaffIDNumber(staffidnumber, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByDepartment/{Department}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByDepartment(string department, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByDepartment(department, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByItem/{Item}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByItem(string item, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByItem(item, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByOrderQuantity/{OrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByOrderQuantity(int orderquantity, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByOrderQuantity(orderquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByPresentQuantity/{PresentQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByPresentQuantity(int presentquantity, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByOrderQuantity(presentquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByAbsentQuantity/{AbsentQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByAbsentQuantity(int absentquantity, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByAbsentQuantity(absentquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByProcurementCenter/{ProcurementCenter}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByProcurementCenter(string procurementcenter, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByProcurementCenter(procurementcenter, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByTelephone/{Telephone}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByTelephone(int telephone, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByTelephone(telephone, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByAddress/{Address}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByAddress(string address, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByAddress(address, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByMonthlyPlacementOrderQuantity/{MonthlyPlacementOrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByMonthlyPlacementOrderQuantity(monthlyplacementorderquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByYearlyPlacementOrderQuantity/{YearlyPlacementOrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByYearlyPlacementOrderQuantity(yearlyplacementorderquantity, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByDateOfPlacementOrder/{DateOfPlacementOrder}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByDateOfPlacementOrder(dateofplacementorder, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByDateOfPlacementOrder/{TargetedDeliveryDate}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByTargetedDeliveryDate(targeteddeliverydate, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByArrivalDate/{ArrivalDate}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByArrivalDate(DateTime arrivaldate, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByArrivalDate(arrivaldate, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpPut("UpdateDepartmentalProcurementsByArrivalLocation/{ArrivalLocation}")]
        public async Task<ActionResult<DepartmentalProcurements>> UpdateDepartmentalProcurementsByArrivalLocation(string arrivallocation, DepartmentalProcurements request)
        {
            var result = await _departmentalprocurementsService.UpdateDepartmentalProcurementsByArrivalLocation(arrivallocation, request);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

       
        [HttpDelete("DeleteDepartmentalProcurementsByFirstname/{Firstname}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByFirstname(string firstname)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByFirstname(firstname);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByMiddlename/{Middlename}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByMiddlename(string middlename)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByMiddlename(middlename);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByLastname/{Lastname}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByLastname(string lastname)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByLastname(lastname);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByRoleTitle/{RoleTitle}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByRoleTitle(string roletitle)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByRoleTitle(roletitle);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByStaffIDNumber/{StaffIDNumber}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByStaffIDNumber(int staffidnumber)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByStaffIDNumber(staffidnumber);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByDepartment/{Department}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByDepartment(string department)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByDepartment(department);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByItem/{Item}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByItem(string item)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByItem(item);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByOrderQuantity/{OrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByOrderQuantity(int orderquantity)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByOrderQuantity(orderquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByPresentQuantity/{PresentQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByPresentQuantity(int presentquantity)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByPresentQuantity(presentquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByAbsentQuantity/{AbsentQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByAbsentQuantity(int absentquantity)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByAbsentQuantity(absentquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByProcurementCenter/{ProcurementCenter}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByProcurementCenter(string procurementcenter)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByProcurementCenter(procurementcenter);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByTelephone/{Telephone}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByTelephone(int telephone)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByTelephone(telephone);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByAddress/{Address}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByAddress(string address)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByAddress(address);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByMonthlyPlacementOrderQuantity/{MonthlyPlacementOrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByMonthlyPlacementOrderQuantity(monthlyplacementorderquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByYearlyPlacementOrderQuantity/{YearlyPlacementOrderQuantity}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByYearlyPlacementOrderQuantity(yearlyplacementorderquantity);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByDateOfPlacementOrder/{DateOfPlacementOrder}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByDateOfPlacementOrder(dateofplacementorder);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByTargetedDeliveryDate/{TargetedDeliveryDate}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByTargetedDeliveryDate(targeteddeliverydate);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByArrivalDate/{ArrivalDate}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByTargetedDeliveryDate(arrivaldate);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartmentalProcurementsByArrivalLocation/{ArrivalLocation}")]
        public async Task<ActionResult<DepartmentalProcurements>> DeleteDepartmentalProcurementsByArrivalLocation(string arrivallocation)
        {
            var result = await _departmentalprocurementsService.DeleteDepartmentalProcurementsByArrivalLocation(arrivallocation);
            if (result is null)
                return NotFound("Procurements not found.");

            return Ok(result);
        }
    }
}

