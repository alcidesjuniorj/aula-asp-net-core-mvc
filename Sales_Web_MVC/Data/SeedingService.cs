using Sales_Web_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales_Web_MVC.Models.Enum;

namespace Sales_Web_MVC.Data
{
    public class SeedingService
    {
        private DepartmentContext _context;

        public SeedingService(DepartmentContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; //se houver algum registro no banco de dados... não faz nada.
            }

            Department d1 = new Department(1, "Eletronics");
            Department d2 = new Department(2, "Books");
            Department d4 = new Department(3, "Tools");
            Department d3 = new Department(4, "Fashions");

            Seller s1 = new Seller(1, "alcides", "alcides@yahoo.com.br", new DateTime(1979, 07, 19), 2.300, d1);
            Seller s2 = new Seller(2, "daiane", "dayschumacher@yahoo.com.br", new DateTime(1986, 02, 06), 2.500, d3);
            Seller s3 = new Seller(3, "dalila", "dalila.schumacher@gmail.com", new DateTime(1994, 10, 15), 1.300, d4);
            Seller s4 = new Seller(1, "Julnei", "julneifagundes12@gmail.com", new DateTime(2000, 03, 15), 4.300, d3);
            Seller s5 = new Seller(1, "michelle Silva", "mimisilva@gmail.com", new DateTime(1990, 11, 09), 2.500, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2020, 03, 01), 11.000, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2020, 03, 01), 8.000, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2020, 03, 01), 15.000, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5);

            _context.SalesRecords.AddRange(sr1, sr2, sr3);

            _context.SaveChanges();
        }
    }
}
