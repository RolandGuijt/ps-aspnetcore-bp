using CarvedRock_gRPC;
using Microsoft.AspNetCore.Mvc;
using static CarvedRock_gRPC.Products;

namespace CarvedRock_MVC.Controllers;

public class ProductController : Controller
{
    private readonly ProductsClient client;

    public ProductController(ProductsClient client)
    {
        this.client = client;
    }

    public async Task<IActionResult> Index()
    {
        var response = await client.GetAllAsync(
            new AllProductsRequest());
        return View(response.Products);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product newProduct)
    {
        if (!ModelState.IsValid)
            return View();

        await client.CreateNewAsync(new CreateNewRequest { 
            Product = newProduct });
        return RedirectToAction("Index");
    }
}
