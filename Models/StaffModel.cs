using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge5_PetAdoptionAPICThomason.Models
{
    public class StaffModel
    {
         public int Id{get; set;}
        public string FirstName{get; set;} = string.Empty; 
        public string LastName{get; set;} = string.Empty;
       public string Email{get; set;} = string.Empty;
       public  int Salary{get; set;}
        public string JobPosition{get; set;} = string.Empty; 
       public bool IsWorking{get; set;} 
    }
}