using CarvedRock_Shared.Data;

namespace CarvedRock_WebApi.Data;
public class ProductRepository : IProductRepository
{
    private List<Product> products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Mountain Walkers",
            Price = 219.5m,
            Stock = 12,
            PhotoFileName = "shutterstock_66842440.jpg"
        },
        new Product
        {
            Id = 2,
            Name = "Army Slippers",
            Price = 125.9m,
            Stock = 45,
            PhotoFileName = "shutterstock_222721876.jpg"
        },
        new Product
        {
            Id = 3,
            Name = "Backpack Deluxe",
            Price = 199.99m,
            Stock = 64,
            PhotoFileName = "shutterstock_6170527.jpg"
        },
        new Product
        {
            Id = 4,
            Name = "Climbing kit",
            Price = 350m,
            Stock = 8,
            PhotoFileName = "shutterstock_48040747.jpg"
        }
    };

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await Task.Run(() => products);

    }
    public async Task<Product?> GetOne(int id)
    {
        return await Task.Run(() => products.FirstOrDefault(p => p.Id == id));
    }

    public async Task<Product> Add(Product product)
    {
        product.Id = 10;
        product.PhotoFileName = "shutterstock_495259978.jpg";
        await Task.Run(() => products.Add(product));
        return product;
    }
}

