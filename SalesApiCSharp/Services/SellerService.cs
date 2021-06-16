using SalesApiCSharp.Data;
using SalesApiCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesApiCSharp.Services.Exceptions;

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
            return _context.Seller.OrderBy(x => x.Name).ToList();
        }

        public void Inserir(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found!");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
