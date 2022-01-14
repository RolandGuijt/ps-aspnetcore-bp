using CarvedRock_gRPC.Data;
using Grpc.Core;

namespace CarvedRock_gRPC.Services;
public class ProductService: Products.ProductsBase
{
    private readonly IProductRepository productRepository;

    public ProductService(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }
    public override async Task<AllProductsResponse> GetAll(
        AllProductsRequest request, ServerCallContext context)
    {
        var response = new AllProductsResponse();
        response.Products.Add(await productRepository.GetAll());
        return response;
    }

    public override async Task<CreateNewResponse> CreateNew(
        CreateNewRequest request, ServerCallContext context)
    {
        return new CreateNewResponse(new CreateNewResponse { 
            Product = await productRepository.Add(request.Product)});
    }
}
