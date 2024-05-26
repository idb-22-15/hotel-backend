namespace api.Env
{
    public interface IEnv
    {
        public int SMTP_PORT { get; }
        public string SMTP_EMAIL { get; }
        public string SMTP_PASSWORD { get; }
    }
}