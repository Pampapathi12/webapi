using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Data
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
       { 


       }
        public DbSet<Stock> Stock {  get; set; }
        public DbSet<Comments> Comments { get; set; }

        // search the individual data tables from the database


    }
}

// ORM -> transfer database tables into object
