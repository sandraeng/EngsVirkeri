using EngsVirkeri.Data;
using EngsVirkeri.Interfaces;
using EngsVirkeri.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngsVirkeri.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EngsVirkeriContext _context;

        public ProductRepository(EngsVirkeriContext context)
        {
            _context = context;
        }

        public Task AddProductAsync(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products
                .FirstOrDefault(m => m.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
        }

        public async Task<Product> GetProductAsync(int? id)
        {            
            return await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);           
        }

        public async Task<List<Product>> ListAllProductsAsync()
{
            return await _context.Products.ToListAsync();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(int id, Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
