namespace Domain.Interfaces
{
    public interface IHubEvents
    {
        Task UserLoggedIn(string? userId);
        Task UserLoggedOff(string? userId);
    }
}
