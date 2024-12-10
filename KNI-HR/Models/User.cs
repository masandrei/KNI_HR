namespace KNI_HR.Models;
public class User
{
    public Guid Id { get; }
    public string FirstName { get; private set; }
    public string? SecondName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string HashSalt { get; private set; }
    public DateTime RegistrationDate { get; }
    public Roles UserRole { get; private set; }
}
