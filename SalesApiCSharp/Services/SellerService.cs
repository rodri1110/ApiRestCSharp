using SalesApiCSharp.Data;
using SalesApiCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesApiCSharp.Services
{
    public class SellerService
    {
        private readonly SalesApiCSharpContext _context;

        public SellerService(SalesApiCSharpContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
