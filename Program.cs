namespace MailSender
{
    public class SenderBuilder
    {
        public string Host;
        public int Port;
        public string SenderAddress;
        public string Password;

        public SenderBuilder(string host, int port, string userName, string password)
        {
            this.Host = host;
            this.Port = port;
            this.SenderAddress = userName;
            this.Password = password;
        }
    }

    public class MessageBuilder
    {
        public string Subject;
        public string Body;
        public string AttachmentPath;
        public string Recipient;

        public MessageBuilder(string subject, string body, string attachmentPath, string recipient)
        {
            this.Subject = subject;
            this.Body = body;
            this.AttachmentPath = attachmentPath;
            this.Recipient = recipient;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SenderForm());
        }
    }
}