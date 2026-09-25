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
    public class PetController : ControllerBase
    {
        private readonly IPetService _pet;

        public PetController(IPetService pet)
        {
            _pet = pet; //gives the string access to our methods
        }//end of Constructor PetController

        [HttpGet("GetAllAvail")]
        public ActionResult<List<PetModel>> GetAll()
        {
            return Ok(_pet.GetAllAvailable());
        }

        [HttpGet("FindById/{id}")]

        public ActionResult<PetModel> FindById(int id)
        {
            return Ok(_pet.FindById(id));
        }

        [HttpPost("addPet")]

        public ActionResult<PetModel> AddPet([FromBody] PetModel newPet)
        {
            PetModel createdPet = _pet.AddPet(newPet);

            return CreatedAtAction( //returns a 201 created
                    nameof(GetAll), //and lists the pet that was created
                    createdPet
            );
        }
       

        [HttpPut("UpdateInfo/{id}")]
        public ActionResult<bool> UpdatePet(int id, PetModel pet)
        {
            bool update = _pet.UpdatePet(id, pet);
            if (!update)
            {
                return NotFound($"A pet with id {id} was not found in our system");
            }
            return NoContent(); //returns 204 no content
        }//end of updatePet

        [HttpPatch("AdoptPet/{id}")]
        public ActionResult<bool> AdoptPet(int id)
        {
            bool update = _pet.AdoptPet(id);
            if (!update)
            {
                return NotFound($"A pet with id {id} was not found in our system");
            }
            return NoContent(); //returns 204 no content
        }//end of AdoptPet


        [HttpDelete("RemovePet/{id}")]
        public ActionResult<bool> RemovePet(int id)
        {
            bool update = _pet.RemovePet(id);
            if (!update)
            {
                return NotFound($"A pet with id {id} was not found in our system");
            }
            return NoContent(); //returns 204 no content
        }
         [HttpPatch("RestorePet/{id}")]
        public ActionResult<bool> RestorePet(int id)
        {
            bool update = _pet.RestorePet(id);
            if (!update)
            {
                return NotFound($"A pet with id {id} was not found in our system");
            }
            return NoContent(); //returns 204 no content
        }//end of restore pet

    } //end of class PetController
}