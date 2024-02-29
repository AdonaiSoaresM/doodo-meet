namespace Domain.Entities;

public class User : EntityBase
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public bool Online { get; private set; } = false;

    public User(Guid id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public void ChangeOnline(bool online)
    {
        Online = online;
    }
}
