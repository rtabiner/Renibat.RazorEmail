using System.Net.Mail;

namespace Renibat.RazorEmail.Factories
{
    public class MailMessageFactory  : IMailMessageFactory
    {
        public MailMessage BuildEmail(string from, string to, string subject, string emailHtml)
        {
            return new MailMessage(from, to, subject, emailHtml) { IsBodyHtml = true };
        }
    }
}
