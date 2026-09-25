using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge5_PetAdoptionAPICThomason.Models;
using Microsoft.EntityFrameworkCore;


//Must be created before you add the builder to json
namespace Challenge5_PetAdoptionAPICThomason.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //this is left empty
        }
        public DbSet<PetModel> pets{get; set;}
        public DbSet<StaffModel> Staff{get; set;}
    }
}