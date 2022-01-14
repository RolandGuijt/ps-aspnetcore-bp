using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InitialApplication.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IProductRepository productRepository)
        {

        }
    }
}