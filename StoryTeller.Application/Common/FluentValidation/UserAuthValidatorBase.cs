using FluentValidation;
using MextFullStackSaas.Application.Common.Interfaces;
using System.Text.RegularExpressions;

namespace MextFullStackSaas.Application.Common.FluentValidation.BaseValidators
{
    public class UserAuthValidatorBase<T> : AbstractValidator<T> where T : class
    {
        protected readonly IIdentityService _identityService;

        public UserAuthValidatorBase(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        protected bool IsEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
        }

        protected bool IsValidTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title) && title.Length <= 100;
        }

        protected bool IsValidList(List<string> list)
        {
            return list != null && list.Any() && list.All(item => !string.IsNullOrWhiteSpace(item));
        }

        protected bool IsValidGenre(string genre)
        {
            return !string.IsNullOrWhiteSpace(genre);
        }

        protected bool IsValidLength(int length)
        {
            return length > 0;
        }
    }
}
