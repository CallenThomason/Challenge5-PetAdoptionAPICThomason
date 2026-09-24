using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge5_PetAdoptionAPICThomason.Data;
using Challenge5_PetAdoptionAPICThomason.Models;
using SQLitePCL;

namespace Challenge5_PetAdoptionAPICThomason.Services
{
    public class PetService : IPetService //neccesary to connect the two files
    {
        private AppDbContext _petDb;

        public PetService(AppDbContext petDb) //This is a constructor, it runs every time the program is called
        {
            _petDb = petDb; //pull information from the database and creates a new variable
        }//end of constructor

        public List<PetModel> GetAllAvailable()
        {

            IEnumerable<PetModel> result = _petDb.pets;
            result = result.Where(p => p.IsAdopted == false && p.IsDeleted == false);  //this is returning a list that has filtered through all the adopted and deleted pets
            return result.ToList();
        } //end of GetAllAvailable

        public PetModel FindById(int id)
        {
            PetModel? pet = _petDb.pets.FirstOrDefault(p => p.Id == id);

            return pet;
        } //end of GetById

        public PetModel AddPet(PetModel pet)
        {
            pet.Id = 0; 
            _petDb.pets.Add(pet);
            _petDb.SaveChanges();
            return pet;
        }//end of AddPet
        public bool UpdatePet(int id, PetModel pet)
        {
            PetModel? present = _petDb.pets.FirstOrDefault(p => p.Id == id);
            if (present is null)
            {
                return false;
            }
           present.Name = pet.Name;
            present.Species = pet.Species;
            present.Breed = pet.Breed;
            present.Age = pet.Age;
            present.IsAdopted = pet.IsAdopted;
            present.IsDeleted = pet.IsDeleted;

            _petDb.SaveChanges(); 
           
            return true;
        } //end of UpdatePet

        public bool AdoptPet(int id)
        {
            PetModel? present = _petDb.pets.FirstOrDefault(p => p.Id == id);
            if (present is null)
            {
                return false;
            }
            present.IsAdopted = true;
            _petDb.SaveChanges(); 
            return true;

            //runs exactly like an update
            //but only changes the one variable to true
        }//end of AdoptPet
        public bool RemovePet(int id)
        {
            PetModel? present = _petDb.pets.FirstOrDefault(p => p.Id == id);
            if (present is null)
            {
                return false;
            }
            present.IsDeleted = true;
            _petDb.SaveChanges(); 
            return true;
            //does the same thing as AdoptPet
            //except this one changes the value of IsDeleted
        }
        public bool RestorePet(int id)
        {
            PetModel? present = _petDb.pets.FirstOrDefault(p => p.Id == id);
            if (present is null)
            {
                return false;
            }
            present.IsDeleted = false; //this one just makes it false
            _petDb.SaveChanges(); 
            return true;
          
        }
    }
}