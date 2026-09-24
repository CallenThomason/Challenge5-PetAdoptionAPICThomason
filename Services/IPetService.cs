using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge5_PetAdoptionAPICThomason.Models;

namespace Challenge5_PetAdoptionAPICThomason.Services
{
    public interface IPetService
    {
        public List<PetModel> GetAllAvailable(); 

        public PetModel FindById(int id);

        public PetModel AddPet(PetModel pet);

        public bool UpdatePet(int id, PetModel pet);

        public bool AdoptPet(int id); 

        public bool RemovePet(int id); 

        public bool RestorePet(int id); 
       
    }
}