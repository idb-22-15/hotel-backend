namespace api.Interfaces
{
    public interface IMailerRepo
    {
        public Task SendEmailAsync(string email, string subject, string message);
    }
}