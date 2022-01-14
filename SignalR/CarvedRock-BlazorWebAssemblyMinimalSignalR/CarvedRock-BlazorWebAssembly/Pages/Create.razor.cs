using CarvedRock_BlazorWebAssembly.ApiServices;
using CarvedRock_Shared.Data;
using Microsoft.AspNetCore.Components;

namespace CarvedRock_BlazorWebAssembly.Pages;

    public partial class Create
{
    private Product newProduct { get; set; } = new();

    [Inject]
    private IProductApiService productApiService { get; set; } = default!;

    [Inject]
    private NavigationManager navigationManager { get; set; } = default!;

    private async void CreateProduct()
    {
        await productApiService.Add(newProduct);
        navigationManager.NavigateTo("/");
    }
}

