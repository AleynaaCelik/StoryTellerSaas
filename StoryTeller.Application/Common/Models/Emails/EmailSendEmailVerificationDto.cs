using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Common.Models.Emails
{
    public class EmailSendEmailVerificationDto
    {
        public string Email { get; set; }
        //public string Subject { get; set; }
        public string FirstName { get; set; }
        public string Token { get; set; }

        public EmailSendEmailVerificationDto(string email, string firstname, string token)
        {
            Email = email;
            FirstName = firstname;
            Token = token;
        }

        public EmailSendEmailVerificationDto()
        {

        }
    }
}

