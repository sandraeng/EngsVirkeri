using EngsVirkeri.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EngsVirkeri.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> ListAllProductsAsync();
        public Task<Product> GetProductAsync(int? id);
        public Task AddProductAsync(Product product);
        public void DeleteProduct(int id);
        public void UpdateProduct(int id, Product product);
        public Task<bool> SaveAllAsync();
    }
}
