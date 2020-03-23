using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Xamarin_leanr.Model;

namespace Xamarin_leanr.Validator
{
    class ToDoValidator : AbstractValidator<ToDo>
    {
        public ToDoValidator()
        {
            RuleFor(t => t.Title).Must(n => ValidateString(n)).WithMessage("Головна назва повинна бути заповнена!");
            RuleFor(t => t.Content).Must(n => ValidateString(n)).WithMessage("Додайте опис!");
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
