using CarvedRock_Shared.Data;
using Microsoft.AspNetCore.Components;

namespace CarvedRock_BlazorFullStack.Client.Components;

public partial class Create
{
    private Product NewProduct { get; set; } = new();

    [Inject]
    private IProductRepository ProductRepository { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    private async void CreateProduct()
    {
        await ProductRepository.Add(NewProduct);
        NavigationManager.NavigateTo("/");
    }
}

