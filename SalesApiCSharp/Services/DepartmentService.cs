using SalesApiCSharp.Data;
using SalesApiCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesApiCSharp.Services
{
    public class DepartmentService
    {
        private readonly SalesApiCSharpContext _context;

        public DepartmentService(SalesApiCSharpContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
