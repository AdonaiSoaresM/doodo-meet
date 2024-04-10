using Domain.Interfaces;
using Domain.Security;
using Domain.ViewModel;

namespace Domain.Services;

public class ListUserService : IListUserService
{
    private readonly IUserRepository _userRepository;
    private readonly UserRequestContext _userRequestContext;

    public ListUserService(IUserRepository userRepository, UserRequestContext userRequestContext)
    {
        _userRepository = userRepository;
        _userRequestContext = userRequestContext;
    }

    public async Task<IEnumerable<ListUserViewModel>> Handle()
    {
        var users = await _userRepository.ListAsync(p => p.Id != _userRequestContext.UserId);

        var viewModels = users.Select(p => new ListUserViewModel(p.Id,
            p.Name,
            p.Email,
            p.Online));

        return viewModels;
    }
}
