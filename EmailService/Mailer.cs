using System.Net.Mail;
using System.Net;

namespace EmailService
{
    public class Mailer
    {
        private const string primarySmtp = "smtp.somevendor.com";
        private const string secondarySmtp = "smtp.anothervendor.com";

        public static void SendMail(MailMessage message)
        {
            using (var mailer = new SmtpClient(primarySmtp))
            {
                try
                {
                    mailer.Send(message);
                }
                catch (System.Exception)
                {
                    mailer.Dispose();
                    Resend(message);
                }    
            }
        }

        private static void Resend(MailMessage message)
        {
            using (var mailer = new SmtpClient(secondarySmtp))
            {
                mailer.Send(message);
            }
        }
    }
}