using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Model;
using Microsoft.EntityFrameworkCore;

namespace APP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }

    // public class ApplicationDbContextSqlite : DbContext
    // {
    //     public ApplicationDbContextSqlite(DbContextOptions<ApplicationDbContextSqlite> options) : base(options)
    //     {
            
    //     }

    //     public DbSet<Category> Category { get; set; }
    // }
}