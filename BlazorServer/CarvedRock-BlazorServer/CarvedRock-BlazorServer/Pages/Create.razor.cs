using CarvedRock_BlazorServer.Data;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace CarvedRock_BlazorServer.Pages
{
    public partial class Create
    {        
        private Product newProduct { get; set; } = new();

        [Inject]
        private IProductRepository productRepository { get; set; } = default!;

        [Inject]
        private NavigationManager navigationManager { get; set; } = default!;

        private async void CreateProduct()
        {
            await productRepository.Add(newProduct);
            navigationManager.NavigateTo("/");
        }
    }
}
