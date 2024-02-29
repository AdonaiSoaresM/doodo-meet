namespace Infrastructure.Security;

public class UserRequestContext
{
    public string? UserId { get; private set; }
    public string? UserName { get; private set; }
    public string? Email { get; private set; }

    public UserRequestContext(string? userId, string? userName, string? email)
    {
        UserId = userId;
        UserName = userName;
        Email = email;
    }
}
