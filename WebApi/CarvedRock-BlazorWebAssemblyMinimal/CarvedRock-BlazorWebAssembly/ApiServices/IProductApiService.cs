using CarvedRock_Shared.Data;

namespace CarvedRock_BlazorWebAssembly.ApiServices
{
    public interface IProductApiService
    {
        Task<Product?> Add(Product product);
        Task<IEnumerable<Product>> GetAll();
    }
}