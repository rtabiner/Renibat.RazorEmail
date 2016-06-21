using System;
using System.Net.Mail;
using Renibat.RazorEmail.Wrappers.Interfaces;

namespace Renibat.RazorEmail.Wrappers
{
    public class SmtpClientWrapper : ISmtpClientWrapper
    {
        public bool SendMailMessage(MailMessage mailMessage)
        {
            try
            {
                using (var client = new SmtpClient())
                {
                    client.Send(mailMessage);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
