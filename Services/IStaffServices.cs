using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge5_PetAdoptionAPICThomason.Migrations;
using Challenge5_PetAdoptionAPICThomason.Models;

namespace Challenge5_PetAdoptionAPICThomason.Services
{
    public interface IStaffServices
    {
       
       StaffModel AddStaff(StaffModel newstaff); 
        List<StaffModel> Working(); 
        StaffModel Patch(int id, StaffModel change);
    }
}