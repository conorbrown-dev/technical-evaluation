namespace Application.Users;

public class UserValidator : IUserValidator
{
    public ValidationStatus Validate(string email, string password)
    {
        // Basic validation for demonstration purposes. In a real application, more robust validation logic should be used.
        if (string.IsNullOrWhiteSpace(email))
        {
            return ValidationStatus.InvalidEmail;
        }

        return string.IsNullOrWhiteSpace(password)
            ? ValidationStatus.WeakPassword
            : ValidationStatus.Valid;
    }

    public enum ValidationStatus
    {
        Valid,
        InvalidEmail,
        WeakPassword
    }
}
