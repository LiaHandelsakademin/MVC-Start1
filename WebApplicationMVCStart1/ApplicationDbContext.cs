using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVCStart1.Models;

namespace WebApplicationMVCStart1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        /* This constructor must be added. */
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
