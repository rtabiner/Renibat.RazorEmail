using System.Net.Mail;
using NUnit.Framework;
using System;

namespace Renibat.RazorEmail.Tests.WrapperTests.SmtpClientWrapperTests.SendMailMessageTests
{
    [Category("BehaviourTest")]
    public class AndSendingTheEmailSucceeds : WhenCallingSendMailMessage
    {
        protected override void Given()
        {
            base.Given();

            MailMessage = new MailMessage("from@address.co.uk", "to@address.co.uk");
        }

        [Test]
        public void ThenResultIsTrue()
        {
            Assert.IsTrue(Result);
        }
    }			
        
}
