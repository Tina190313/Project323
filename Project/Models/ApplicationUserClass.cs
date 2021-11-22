using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models;


namespace Project.Models
{
    public class ApplicationUserClass:IdentityDbContext

    {
        public ApplicationUserClass(DbContextOptions<ApplicationUserClass> options):base(options)

        {

        }
        public DbSet<UserRegClass> UserTable { get; set; }
        public DbSet<Project.Models.LoginViewClass> LoginViewClass { get; set; }
        public DbSet<Project.Models.ImageClass> ImageClass { get; set; }
       
    }
}
