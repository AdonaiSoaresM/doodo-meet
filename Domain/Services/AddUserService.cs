using Domain.Entities;
using Domain.Interfaces;
using Domain.Security;

namespace Domain.Services;
public class AddUserService : IAddUserService
{
    private readonly IUserRepository _userRepository;
    private readonly UserRequestContext _userRequestContext;

    public AddUserService(IUserRepository userRepository, UserRequestContext userRequestContext)
    {
        _userRepository = userRepository;
        _userRequestContext = userRequestContext;
    }

    public async Task Handle()
    {
        var user = await _userRepository.Find(_userRequestContext.UserId);

        if(user == null)
        {
            user = new User(_userRequestContext.UserId, _userRequestContext.UserName!, _userRequestContext.Email!);
            user.ChangeOnline(true);
            await _userRepository.Add(user);
        } else
        {
            user.ChangeOnline(true);
            _userRepository.Update(user);
        }

        await _userRepository.Commit();
    }
}
