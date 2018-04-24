using Microsoft.AspNetCore.Mvc;
using EmailService.Models;

namespace EmailService.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        [HttpPost]
        [Route("send")]
        public IActionResult SendEmail([FromBody] Email email)
        {
            var message = EmailMessage.BuildMessage(email);

            try
            {
                Mailer.SendMail(message);
            }
            catch (System.Exception)
            {
                return BadRequest("Unable to send email. Make sure address is correct.");
            }
            return Ok();
        }
    }
}