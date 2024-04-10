using Domain.Interfaces;

namespace Domain.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task ToggleUserOnlineOffline(string? userId, bool status)
    {
        _ = Guid.TryParse(userId, out Guid id);
        if(id == Guid.Empty) return;

        var user = await _userRepository.Find(id);
        if (user == null) return;

        user.ChangeOnline(status);
        _userRepository.Update(user);
        await _userRepository.Commit();
    }
}
