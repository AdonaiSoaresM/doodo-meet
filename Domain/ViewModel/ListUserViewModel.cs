namespace Domain.ViewModel;

public class ListUserViewModel
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }
    public bool Online { get; init; }

    public ListUserViewModel(Guid id, string name, string email, bool online)
    {
        Id = id;
        Name = name;
        Email = email;
        Online = online;
    }
}
