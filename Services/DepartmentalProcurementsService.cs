using System;
using SIBLEYBLAYOPERA.Models;
using SIBLEYBLAYOPERA.Data;
using SIBLEYBLAYOPERA.Services;
using SIBLEYBLAYOPERA.Services.DepartmentalProcurementsService;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SIBLEYBLAYOPERA.Migrations;
using DepartmentalProcurements = SIBLEYBLAYOPERA.Models.DepartmentalProcurements;

namespace SIBLEYBLAYOPERA.Services.DepartmentalProcurementsService
{
    public class DepartmentalProcurementsService: IDepartmentalProcurementsService
        {
            private readonly DataContext _context;

            public DepartmentalProcurementsService(DataContext context)
            {
                _context = context;
            }

            public async Task<List<DepartmentalProcurements>> GetAllDepartmentalProcurements()
            {
                var departmentalprocurements = await _context.DepartmentalProcurements.ToListAsync();
                return departmentalprocurements;
            }

            public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByFirstname(string firstname)
            {
                var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(firstname);
                if (departmentalprocurements is null)
                    return null;

                return departmentalprocurements;
            }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByMiddlename(string middlename)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(middlename);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByLastname(string lastname)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(lastname);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByRoleTitle(string roletitle)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(roletitle);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByStaffIDNumber(int staffidnumber)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(staffidnumber);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByDepartment(string department)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(department);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByItem(string item)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(item);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByOrderQuantity(int orderquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(orderquantity);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByPresentQuantity(int presentquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(presentquantity);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByAbsentQuantity(int absentquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(absentquantity);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByProcurementCenter(string procurementcenter)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(procurementcenter);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByTelephone(int telephone)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(telephone);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByAddress(string address)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(address);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(monthlyplacementorderquantity);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(yearlyplacementorderquantity);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(dateofplacementorder);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(targeteddeliverydate);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(arrivaldate);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByArrivalLocation(string arrivallocation)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(arrivallocation);
            if (departmentalprocurements is null)
                return null;

            return departmentalprocurements;
        }

        public async Task<ActionResult<List<DepartmentalProcurements>>> AddDepartmentalProcurements(DepartmentalProcurements departmentalprocurements)
        {
            _context.DepartmentalProcurements.Add(departmentalprocurements);
            await _context.SaveChangesAsync();
            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByFirstname(string firstname, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(firstname);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.Firstname = request.Firstname;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByMiddlename(string middlename, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(middlename);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.Middlename = request.Middlename;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByLastname(string lastname, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(lastname);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.Lastname = request.Lastname;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByRoleTitle(string roletitle, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(roletitle);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.RoleTitle = request.RoleTitle;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByStaffIDNumber(int staffidnumber, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(staffidnumber);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.RoleTitle = request.RoleTitle;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByDepartment(string department, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(department);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.Department = request.Department;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByItem(string item, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(item);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.Item = request.Item;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByOrderQuantity(int orderquantity, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(orderquantity);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.OrderQuantity = request.OrderQuantity;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByPresentQuantity(int presentquantity, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(presentquantity);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.PresentQuantity = request.PresentQuantity;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByAbsentQuantity(int absentquantity, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(absentquantity);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.AbsentQuantity = request.AbsentQuantity;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByProcurementCenter(string procurementcenter, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(procurementcenter);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.ProcurementCenter = request.ProcurementCenter;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByTelephone(int telephone, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(telephone);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.Telephone = request.Telephone;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByAddress(string address, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(address);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.Address = request.Address;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(monthlyplacementorderquantity);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.MonthlyPlacementOrderQuantity = request.MonthlyPlacementOrderQuantity;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(yearlyplacementorderquantity);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.YearlyPlacementOrderQuantity = request.YearlyPlacementOrderQuantity;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(dateofplacementorder);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.DateOfPlacementOrder = request.DateOfPlacementOrder;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(targeteddeliverydate);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.TargetedDeliveryDate = request.TargetedDeliveryDate;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByArrivalDate(DateTime arrivaldate, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(arrivaldate);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.ArrivalDate = request.ArrivalDate;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByArrivalLocation(string arrivallocation, DepartmentalProcurements request)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(arrivallocation);
            if (departmentalprocurements is null)
                return null;

            departmentalprocurements.ArrivalLocation = request.ArrivalLocation;
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByFirstname(string firstname)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(firstname);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByMiddlename(string middlename)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(middlename);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByLastname(string lastname)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(lastname);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByRoleTitle(string roletitle)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(roletitle);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByStaffIDNumber(int staffidnumber)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(staffidnumber);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByDepartment(string department)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(department);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByItem(string item)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(item);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByOrderQuantity(int orderquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(orderquantity);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByPresentQuantity(int presentquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(presentquantity);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByAbsentQuantity(int absentquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(absentquantity);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByProcurementCenter(string procurementcenter)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(procurementcenter);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByTelephone(int telephone)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(telephone);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByAddress(string address)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(address);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(monthlyplacementorderquantity);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(yearlyplacementorderquantity);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(dateofplacementorder);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(targeteddeliverydate);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByArrivalDate(DateTime arrivaldate)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(arrivaldate);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }

        public async Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByArrivalLocation(string arrivallocation)
        {
            var departmentalprocurements = await _context.DepartmentalProcurements.FindAsync(arrivallocation);
            if (departmentalprocurements is null)
                return null;

            _context.DepartmentalProcurements.Remove(departmentalprocurements);
            await _context.SaveChangesAsync();

            return await _context.DepartmentalProcurements.ToListAsync();
        }
    }
}
