namespace Application.Users;

public interface IUserValidator
{
    UserValidator.ValidationStatus Validate(string email, string password);
}