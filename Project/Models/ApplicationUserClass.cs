using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Project.Models
{
    public class ApplicationUserClass:DbContext

    {
        public ApplicationUserClass(DbContextOptions<ApplicationUserClass> options):base(options)

        {

        }
        public DbSet<UserRegClass> UserTable { get; set; }
    }
}
