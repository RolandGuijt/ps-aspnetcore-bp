using Microsoft.AspNetCore.SignalR;

namespace CarvedRock_WebApi.Hubs;
public class ProductHub: Hub
{
    public async Task SendMessageToAll(string message)
    {
        await Clients.All.SendAsync("Message", message);
    }
}

