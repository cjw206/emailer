using NUnit.Framework;
using EmailService.Models;
using EmailService;

namespace EmailerTests
{
    [TestFixture]
    public class EmailMessageTests
    {
        [Test]
        public void BuildMessageTest()
        {
            var email = BuildEmail();
            var message = EmailMessage.BuildMessage(email);

            Assert.That(message.Body, Is.EqualTo(email.Body));
            Assert.That(message.Subject, Is.EqualTo(email.Subject));
            Assert.That(message.To, Is.EqualTo(email.To));
        }

        private static Email BuildEmail()
        {
            return new Email
            {
                To = "testemail@something.com",
                From = "fromemail@somethingelse.com",
                Subject = "This is a test",
                Body = "Do you think this test will pass first try?"
            };
        }
    }
}