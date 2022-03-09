using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EngsVirkeri.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EngsVirkeri.Data
{
    public class EngsVirkeriContext : IdentityDbContext
    {
        public EngsVirkeriContext (DbContextOptions<EngsVirkeriContext> options)
            : base(options)
        {
        }

        public DbSet<EngsVirkeri.Models.Product> Product { get; set; }
    }
}
