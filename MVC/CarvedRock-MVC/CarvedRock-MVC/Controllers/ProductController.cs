using CarvedRock_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarvedRock_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = await productRepository.GetAll();
            return View(model);
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

            await productRepository.Add(newProduct);

            return RedirectToAction("Index");
        }
    }
}