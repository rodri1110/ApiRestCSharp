using SalesApiCSharp.Data;
using SalesApiCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesApiCSharp.Services
{
    public class DepartmentService
    {
        private readonly SalesApiCSharpContext _context;

        public DepartmentService(SalesApiCSharpContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
