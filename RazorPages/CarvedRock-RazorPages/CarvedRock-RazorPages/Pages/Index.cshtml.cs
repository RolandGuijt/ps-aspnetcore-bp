using CarvedRock_RazorPages.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarvedRock_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductRepository productRepository;

        public IndexModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();

        public async Task OnGet()
        {
            Products = await productRepository.GetAll();
        }
    }
}