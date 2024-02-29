namespace Domain.Security;

public class UserRequestContext
{
    public Guid UserId { get; private set; }
    public string? UserName { get; private set; }
    public string? Email { get; private set; }

    public UserRequestContext(string? userId, string? userName, string? email)
    {
        UserId = new Guid(userId!);
        UserName = userName;
        Email = email;
    }
}
