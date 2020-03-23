using FluentValidation;
using FluentValidation.Validators;
using Xamarin_leanr.Model;

/// <summary>
/// Using for validate some entry
/// </summary>

namespace Xamarin_leanr.Validator
{
    class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.ContactName).Must(n => ValidateString(n)).WithMessage("Ім'я контакту повинно бути заповненим!");
            RuleFor(c => c.ContactSurname).Must(s => ValidateString(s)).WithMessage("Прізвище контакту повинно бути заповненим!");
            RuleFor(c => c.Email).EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("Неправильний тип E-mail!");
            RuleFor(c => c.Gender).Must(g => ValidateString(g)).WithMessage("Стать повинна бути заповнена!");
            RuleFor(c => c.MobileNumber).NotNull().Length(10);
        }

        public bool ValidateString(string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
