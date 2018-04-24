using System.Net.Mail;
using EmailService.Models;

namespace EmailService
{
    public static class EmailMessage
    {
        public static MailMessage BuildMessage(Email email)
        {
            var to =  new MailAddress(email.To);
            var from = new MailAddress(email.From);
            var message = new MailMessage(from, to);

            message.Subject = email.Subject;
            message.Body = email.Body;
            message.IsBodyHtml = true;

            return message;
        }
    }
}