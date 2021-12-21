using CarvedRock_BlazorWebAssembly.Data;
using Microsoft.AspNetCore.Components;

namespace CarvedRock_BlazorWebAssembly.Pages;

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

