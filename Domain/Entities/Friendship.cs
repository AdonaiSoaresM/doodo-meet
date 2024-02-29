namespace Domain.Entities;

public class Friendship : EntityBase
{
    public ICollection<User> Users => _users;

    private readonly List<User> _users = [];

    public Friendship(User user1, User user2)
    {
        Id = Guid.NewGuid();
        _users.Add(user1);
        _users.Add(user2);
    }
    public void AddUser(User user)
    {
        _users.Add(user);
    }
}
