using CarvedRock_gRPC;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Components;

namespace CarvedRock_BlazorWebAssembly.Pages;

    public partial class Create
{
    private Product NewProduct { get; set; } = new();

    [Inject]
    private GrpcChannel Channel { get; set; } = default!;

    [Inject]
    private NavigationManager NavigationManager { get; set; } = default!;

    private async void CreateProduct()
    {
        var client = new Products.ProductsClient(Channel);
        await client.CreateNewAsync(new CreateNewRequest { Product = NewProduct });
        NavigationManager.NavigateTo("/");
    }
}

