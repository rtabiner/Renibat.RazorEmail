using System;
using System.Net.Mail;

namespace Renibat.RazorEmail.Tests.WrapperTests.SmtpClientWrapperTests.SendMailMessageTests
{
    public class WhenCallingSendMailMessage : WhenTestingTheSmtpClientWrapper
    {
        protected bool Result { get; set; }
        protected MailMessage MailMessage { get; set; }

        protected override void When()
        {
            Result = _SmtpClientWrapper.SendMailMessage(MailMessage);
        }
    }
}
