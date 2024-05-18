using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Diagnostics.Metrics;

namespace SalesWebMVC.Services
{
    public class SellersService
    {
        private readonly SalesWebMVCContext _context;

        public SellersService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
