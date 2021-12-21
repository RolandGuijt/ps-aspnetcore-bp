using CarvedRock_RazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarvedRock_RazorPages.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IProductRepository productRepository;

        public CreateModel(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [BindProperty]
        public Product NewProduct { get; set; } = new();
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            await productRepository.Add(NewProduct);

            return RedirectToPage("Index");
        }
    }
}
