using CarvedRock_Shared.Data;
using System.Net.Http.Json;

namespace CarvedRock_BlazorWebAssembly.ApiServices;
public class ProductApiService : IProductApiService
{
    private readonly HttpClient httpClient;

    public ProductApiService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<IEnumerable<Product>> GetAll()
    {
        var response = await httpClient.GetAsync("product");
        response.EnsureSuccessStatusCode();
        var products = await 
            response.Content.ReadFromJsonAsync<IEnumerable<Product>>();

        if (products == null)
            return Enumerable.Empty<Product>();
        return products;

    }

    public async Task<Product?> Add(Product product)
    {
        var jsonContent = JsonContent.Create(product);
        var response = await httpClient.PostAsync("product", jsonContent);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Product>();
    }
}
