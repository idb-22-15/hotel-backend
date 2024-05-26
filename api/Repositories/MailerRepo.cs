using System.Net;
using System.Net.Mail;
using api.Env;
using api.Interfaces;

namespace api.Repositories
{
    public class MailerRepo(IEnv env) : IMailerRepo
    {

        public async Task SendEmailAsync(string to, string subject, string message)
        {

            var from = env.SMTP_EMAIL;
            var fromPassword = env.SMTP_PASSWORD;
            var port = env.SMTP_PORT;
            to = "mrart111@mail.ru";

            var client = new SmtpClient("smtp.gmail.com", port)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(from, fromPassword),
            };

            var mailMessage = new MailMessage(
                new MailAddress(from, "Hotel Vatrigo"),
                new MailAddress(to, to))

            {
                Subject = subject,
                SubjectEncoding = System.Text.Encoding.UTF8,
                BodyEncoding = System.Text.Encoding.UTF8,
                Body = message,
                IsBodyHtml = true
            };

            await client.SendMailAsync(mailMessage);
        }
    }
}