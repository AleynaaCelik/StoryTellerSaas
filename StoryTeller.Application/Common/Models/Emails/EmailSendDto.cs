using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller.Application.Common.Models.Emails
{
    public class EmailSendDto
    {
        public string Subject { get; set; }
        public List<string> Addreses { get; set; }
        public string HtmlContent { get; set; }

        public EmailSendDto(string email, string subject, string htmlBody)
        {
            Subject = subject;
            Addreses = new() { email };
            HtmlContent = htmlBody;
        }
        public EmailSendDto(List<string> emails, string subject, string htmlBody)
        {
            Subject = subject;
            Addreses = emails;
            HtmlContent = htmlBody;
        }
    }
}
