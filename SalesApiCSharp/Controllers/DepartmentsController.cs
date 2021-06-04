using Microsoft.AspNetCore.Mvc;
using SalesApiCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesApiCSharp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department{Id = 1, Name = "Eletronics"});
            list.Add(new Department{Id = 2, Name = "Books"});
            return View(list);
        }
    }
}
