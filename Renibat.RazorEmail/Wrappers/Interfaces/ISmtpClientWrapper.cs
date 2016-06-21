using System.Net.Mail;

namespace Renibat.RazorEmail.Wrappers.Interfaces
{
    public interface ISmtpClientWrapper
    {
        bool SendMailMessage(MailMessage mailMessage);
    }
}
