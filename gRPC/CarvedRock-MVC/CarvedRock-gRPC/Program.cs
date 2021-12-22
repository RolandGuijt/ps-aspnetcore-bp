using CarvedRock_gRPC.Data;
using CarvedRock_gRPC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddCors();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseCors(b => b.WithOrigins("https://localhost:7220")
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapGrpcService<ProductService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
