using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sales_Web_MVC.Models
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext (DbContextOptions<DepartmentContext> options)
            : base(options)
        {
        }

        public DbSet<Sales_Web_MVC.Models.Department> Department { get; set; }
    }
}
