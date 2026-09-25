using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge5_PetAdoptionAPICThomason.Models
{
    public class PetModel
    {
        public int Id{get; set;}
        public string Name{get; set;} = string.Empty; 
        public string Species{get; set;} = string.Empty;
        public string Breed{get; set;} = string.Empty; 
        public int Age{get; set;}
        public bool IsAdopted{get; set;}
        public bool IsDeleted{get; set;}

    }
}