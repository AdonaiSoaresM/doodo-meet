using Domain.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;

namespace backend.Hubs;

[Authorize]
public class AppHub : Hub<IHubEvents>
{
    private readonly IUserService _userService;

    public AppHub(IUserService userService)
    {
        _userService = userService;
    }
    public async override Task OnConnectedAsync()
    {
        await Clients.All.UserLoggedIn(Context.UserIdentifier);
        await _userService.ToggleUserOnlineOffline(Context.UserIdentifier, true);
        await base.OnConnectedAsync();
    }

    public async override Task OnDisconnectedAsync(Exception? exception)
    {
        await Clients.All.UserLoggedOff(Context.UserIdentifier);
        await _userService.ToggleUserOnlineOffline(Context.UserIdentifier, false);
        await base.OnDisconnectedAsync(exception);
    }
    public void SendMessage(string userId, string message)
    {
    }

}
