using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Common.Models.Emails
{
    public class EmailSendPasswordResetDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
