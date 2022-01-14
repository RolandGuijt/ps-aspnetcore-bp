using CarvedRock_BlazorWebAssembly;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton(services =>
{
    var httpHandler = new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler());

    return GrpcChannel.ForAddress("https://localhost:7110", new GrpcChannelOptions { HttpHandler = httpHandler });
});

await builder.Build().RunAsync();
