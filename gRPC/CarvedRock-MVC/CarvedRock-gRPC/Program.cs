using CarvedRock_gRPC.Data;
using CarvedRock_gRPC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();

var app = builder.Build();

app.MapGrpcService<ProductService>();

app.Run();
