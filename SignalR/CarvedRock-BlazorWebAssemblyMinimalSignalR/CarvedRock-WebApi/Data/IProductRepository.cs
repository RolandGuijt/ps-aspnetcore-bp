
namespace CarvedRock_WebApi.Data
{
    public interface IProductRepository
    {
        Task<Product> Add(Product product);
        Task<IEnumerable<Product>> GetAll();
        Task<Product?> GetOne(int id);
    }
}