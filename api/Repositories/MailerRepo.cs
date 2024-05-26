using System.Net;
using System.Net.Mail;
using api.Interfaces;

namespace api.Repositories
{
    public class MailerRepo : IMailerRepo
    {
        public Task SendEmailAsync(string clientEmail, string subject, string message)
        {

            var serverEmail = "";
            var serverEmailPassword = "";

            var client = new SmtpClient("smtp.mail.ru", 465)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(serverEmail, serverEmailPassword),
            };

            return client.SendMailAsync(new MailMessage(from: serverEmail, to: clientEmail, subject, message));
        }
    }
}