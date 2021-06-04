using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesApiCSharp.Models;

namespace SalesApiCSharp.Data
{
    public class SalesApiCSharpContext : DbContext
    {
        public SalesApiCSharpContext (DbContextOptions<SalesApiCSharpContext> options)
            : base(options)
        {
        }

        public DbSet<SalesApiCSharp.Models.Department> Department { get; set; }
    }
}
