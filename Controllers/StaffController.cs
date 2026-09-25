using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge5_PetAdoptionAPICThomason.Models;
using Challenge5_PetAdoptionAPICThomason.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge5_PetAdoptionAPICThomason.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffServices _staff; 

        public StaffController(IStaffServices staffs)
        {
            _staff = staffs; 
        }//end of contructor
        [HttpGet("GetAllWorking")]

        public ActionResult<List<StaffModel>> getWorking()
        {
            return _staff.Working(); 
        }

        [HttpPost("AddStaff")]

        public ActionResult<StaffModel> AddStaff([FromBody] StaffModel info)
        {
            StaffModel createdStaff = _staff.AddStaff(info); 

            return CreatedAtAction(
                 nameof(getWorking),
                 createdStaff   
            );
        }

    //       {
    //     "Id" : 1,
    //    "FirstName" : "Isaiah",
    //     "LastName" : "Ferguson",
    //   "Email" : "FootSaiah@Gmail.com",
    //   "Salary" : 1000000,
    //     "JobPosition" : "Bee Keeper",
    //    "IsWorking" : true
    // }

    [HttpPatch("patch/{id}")]
    public ActionResult<StaffModel> Patch(int id, StaffModel change)
        {
            StaffModel? changed = _staff.Patch(id, change);
            if(changed is null)
            {
                return NotFound($"No Staff was found with the {id} was found");
            }
            return NoContent(); 
        }

    }
}