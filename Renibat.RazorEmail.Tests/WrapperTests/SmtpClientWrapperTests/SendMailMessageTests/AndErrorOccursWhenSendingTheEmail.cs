using NUnit.Framework;
using System;

namespace Renibat.RazorEmail.Tests.WrapperTests.SmtpClientWrapperTests.SendMailMessageTests
{

    public class AndErrorOccursWhenSendingTheEmail : WhenCallingSendMailMessage
    {
        protected override void Given()
        {
            base.Given();
        }

        [Test]
        public void ThenResultIsFalse()
        {
            Assert.IsFalse(Result);
        }
    }			
        
}
