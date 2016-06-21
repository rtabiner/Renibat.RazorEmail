using System.Net.Mail;

namespace Renibat.RazorEmail.Factories
{
    public interface IMailMessageFactory
    {
        MailMessage BuildEmail(string from, string to, string subject, string emailHtml);
    }
}
