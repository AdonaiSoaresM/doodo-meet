using Domain.ViewModel;

namespace Domain.Interfaces
{
    public interface IListUserService
    {
        public Task<IEnumerable<ListUserViewModel>> Handle();
    }
}
