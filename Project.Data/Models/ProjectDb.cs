using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Models
{
    public class ProjectDb : DbContext

    {
        public ProjectDb(DbContextOptions<ProjectDb> options) : base(options)

        {

        }
       

        public DbSet<ImageClass> ImageClass { get; set; }
        public DbSet<Tag> Tag { get; set; }


    }
}
