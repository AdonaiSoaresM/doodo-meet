using Microsoft.AspNetCore.SignalR;

namespace backend.Hubs;

public class AppHub : Hub
{
    public override Task OnConnectedAsync()
    {
        Console.WriteLine("Client connected");
        return base.OnConnectedAsync();
    }
}
