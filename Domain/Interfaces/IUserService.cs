namespace Domain.Interfaces;

public interface IUserService
{
    public Task ToggleUserOnlineOffline(string? userId, bool status);
}
