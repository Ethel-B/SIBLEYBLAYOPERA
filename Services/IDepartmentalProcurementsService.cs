using Microsoft.AspNetCore.Mvc;

namespace SIBLEYBLAYOPERA.Services.DepartmentalProcurementsService
{
    public interface IDepartmentalProcurementsService
    {
       public Task<List<DepartmentalProcurements>> GetAllDepartmentalProcurements();

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByFirstname(string firstname);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByMiddlename(string middlename);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByLastname(string lastname);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByRoleTitle(string roletitle);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByStaffIDNumber(int staffidnumber);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByDepartment(string department);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByItem(string item);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByOrderQuantity(int orderquantity);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByPresentQuantity(int presentquantity);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByAbsentQuantity(int absentquantity);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByProcurementCenter(string procurementcenter);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByTelephone(int telephone);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByAddress(string address);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByArrivalDate(DateTime arrivaldate);

        public Task<DepartmentalProcurements> GetSingleDepartmentalProcurementsByArrivalLocation(string arrivallocation);

        public Task<ActionResult<List<DepartmentalProcurements>>> AddDepartmentalProcurements(DepartmentalProcurements departmentalprocurements);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByFirstname(string firstname, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByMiddlename(string middlename, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByLastname(string lastname, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByRoleTitle(string roletitle, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByStaffIDNumber(int staffidnumber, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByDepartment(string department, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByItem(string item, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByOrderQuantity(int orderquantity, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByPresentQuantity(int presentquantity, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByAbsentQuantity(int absentquantity, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByProcurementCenter(string procurementcenter, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByTelephone(int telephone, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByAddress(string address, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByArrivalDate(DateTime arrivaldate, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> UpdateDepartmentalProcurementsByArrivalLocation(string arrivallocation, DepartmentalProcurements request);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByFirstname(string firstname);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByMiddlename(string middlename);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByLastname(string lastname);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByRoleTitle(string roletitle);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByStaffIDNumber(int staffidnumber);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByDepartment(string department);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByItem(string item);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByOrderQuantity(int orderquantity);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByPresentQuantity(int presentquantity);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByAbsentQuantity(int absentquantity);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByProcurementCenter(string procurementcenter);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByTelephone(int telephone);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByAddress(string address);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByMonthlyPlacementOrderQuantity(int monthlyplacementorderquantity);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByYearlyPlacementOrderQuantity(int yearlyplacementorderquantity);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByDateOfPlacementOrder(DateTime dateofplacementorder);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByTargetedDeliveryDate(DateTime targeteddeliverydate);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByArrivalDate(DateTime arrivaldate);

        public Task<List<DepartmentalProcurements>> DeleteDepartmentalProcurementsByArrivalLocation(string arrivallocation);
             }
    }


