using Catalog.API.Entities;

namespace Catalog.API.DAL.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(string id);
        Task<Product> GetProductByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(string category);
        Task CreateProductAsync(Product product);
        Task<bool> DeleteProductAsync(string id);
        Task<bool> UpdateProductAsync(Product product);
    }
}
