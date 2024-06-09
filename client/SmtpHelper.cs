using System.Net.Mail;
using System.Net;

/**
 * Author: Rodriaum (Rodrigo Ferreira)
 * Este arquivo está licenciado sob a MIT License.
 * https://github.com/rodriaum/MailSender?tab=MIT-1-ov-file#readme
 */

namespace MailSender.client
{
    internal class SmtpHelper
    {
        // Custom Connection
        public static SmtpClient Connection(SenderBuilder login)
        {
            return new SmtpClient(login.Host, login.Port)
            {
                Credentials = new NetworkCredential(login.SenderAddress, login.Password),
                EnableSsl = true
            };
        }

        // Default Simple Mail Transfer Protocol: Microsoft Outlook
        public static SmtpClient Connection(string? userName, string? password) => Connection(new SenderBuilder("smtp-mail.outlook.com", 587, userName, password));

        // Message Builder
        public static MailMessage Message(SenderBuilder senderBuilder, MessageBuilder messageBuilder)
        {
            MailMessage message = new MailMessage
            {
                From = new MailAddress(messageBuilder.Recipient),
                Subject = messageBuilder.Subject,
                Body = messageBuilder.Body
            };

            if (!string.IsNullOrEmpty(messageBuilder.AttachmentPath))
                message.Attachments.Add(new Attachment(messageBuilder.AttachmentPath));

            message.To.Add(messageBuilder.Recipient);

            return message;
        }

        // Message Mail Builder
        public static void Send(SmtpClient client, MailMessage message) => client.Send(message);
    }
}
