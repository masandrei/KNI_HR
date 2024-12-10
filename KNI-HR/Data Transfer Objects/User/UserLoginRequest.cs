using System.ComponentModel.DataAnnotations;

namespace KNI_HR.Data_Transfer_Objects.User;
    
public class UserLoginRequest
{
    [EmailAddress]
    public string Email { get; init; }
    [RegularExpression("^[A-z0-9!$%@^]{8,16}$")]
    public string Password { get; init; }
}
