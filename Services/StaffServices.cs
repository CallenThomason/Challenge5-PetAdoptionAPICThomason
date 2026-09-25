using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge5_PetAdoptionAPICThomason.Data;
using Challenge5_PetAdoptionAPICThomason.Migrations;
using Challenge5_PetAdoptionAPICThomason.Models;



namespace Challenge5_PetAdoptionAPICThomason.Services
{
    public class StaffServices : IStaffServices
    {
        private AppDbContext _staff;

        public StaffServices(AppDbContext staff)
        {
            _staff = staff; 
        }//end of contructor

        public StaffModel AddStaff(StaffModel newStaff)
        {
            newStaff.Id = 0; 
            _staff.Staff.Add(newStaff); 
            _staff.SaveChanges(); 
            return newStaff; 
        }//end of AddStaff
        public List<StaffModel> Working()
        {
            IEnumerable<StaffModel> result = _staff.Staff; 
            result = result.Where(s => s.IsWorking == true); 
            return result.ToList(); 
        }//end of Working
        public StaffModel Patch(int id, StaffModel changes)
        {
            StaffModel? existingStaff = _staff.Staff.Find(id); 
            if(existingStaff is null)
            {
                return null; 
            }
            if (!string.IsNullOrWhiteSpace(changes.JobPosition))
            {
                existingStaff.JobPosition = changes.JobPosition; 
            }
           int? newNum = changes.Salary; 
            if (newNum.HasValue)
            {
                existingStaff.Salary = changes.Salary; 
            }
            _staff.SaveChanges(); 

            return existingStaff; 
        }//end of working

    }//end of class
}//end of namespace