using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sales_Web_MVC.Models;

namespace Sales_Web_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> lista = new List<Department>();
            lista.Add(new Department { Id=1,Name="Eletronics"});
            lista.Add(new Department { Id=2,Name="Fashions"});
            lista.Add(new Department { Id=3,Name="Gifts"});

            return View(lista);
        }
    }
}