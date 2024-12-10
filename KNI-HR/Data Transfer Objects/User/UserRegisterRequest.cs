using System.ComponentModel.DataAnnotations;

namespace KNI_HR.Data_Transfer_Objects.User;
public class UserRegisterRequest
{
    [RegularExpression("^[A-Z]([a-z]){0, 99}$", ErrorMessage = "Name can contain only latin symbols and have to start with capital letter")]
    public string FirstName { get; init; }
    [RegularExpression("^[A-Z]?([a-z]){0, 99}$", ErrorMessage = "Name can contain only latin symbols and have to start with capital letter")]
    public string? SecondName { get; init; }
    [RegularExpression("^(?=.{1, 100}$)[A-Z][a-zA-Z]* (?:-[A-Z][a-zA-Z]*)*$", ErrorMessage = "Name can contain only latin symbols, dashes and have to start with capital letter")]
    public string LastName { get; init; }
    [EmailAddress]
    public string Email { get; init; }
    [RegularExpression("^[A-z0-9!$%@^]{8,16}$")]
    public string Password { get; init; }
}
