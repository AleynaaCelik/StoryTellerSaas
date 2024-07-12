using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Common.Models.Auth
{
    public class UserAuthRegisterResponseDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string EmailToken { get; set; }
        public UserAuthRegisterResponseDto(Guid id, string email, string firstname, string emailToken)
        {
            Id = id;
            Email = email;
            FirstName = firstname;
            EmailToken = emailToken;

        }
    }
}
