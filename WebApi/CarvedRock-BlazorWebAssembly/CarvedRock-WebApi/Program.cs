using CarvedRock_WebApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(b => { 
    b.WithOrigins("https://localhost:7220"); 
    b.AllowAnyHeader(); 
    b.AllowAnyMethod(); 
});

app.UseAuthorization();

app.MapControllers();

app.Run();
