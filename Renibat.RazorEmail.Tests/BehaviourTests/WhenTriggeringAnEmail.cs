using NUnit.Framework;
using Renibat.RazorEmail.Factories;
using ReSystems.RazorEmail.Tests.Core;
using System;
using System.Net.Mail;

namespace Renibat.RazorEmail.Tests.BehaviourTests
{
    [Category("BehaviourTest")]
    public class WhenTriggeringAnEmail : SpecBase
    {
        protected EmailTemplateFactory EmailTemplateFactory { get; set; }
        protected DefaultEmailTemplateSettings DefaultEmailTemplateSettings { get; set; }
        protected MailMessageFactory MailMessageFactory { get; set; }
        protected string ParsedBody { get; set; }
        protected MailMessage MailMessage { get; set; }
        protected bool Result { get; set; }
        protected Exception CaughtException { get; set; }
        protected string Model { get; set; }
        protected string EmailTemplateName { get; set; }
        protected string FromAddress { get; set; }
        protected string ToAddress { get; set; }
        protected string Subject { get; set; }

        protected override void Given()
        {
            base.Given();

            EmailTemplateName = "TestEmail.cshtml";
            FromAddress = "no-reply@re-systems.co.uk";
            ToAddress = "destination@world.com";
            Subject = "Subject goes here...";
            Model = "This is the model that is passed into the email";

            DefaultEmailTemplateSettings = new DefaultEmailTemplateSettings();

            EmailTemplateFactory = new EmailTemplateFactory(DefaultEmailTemplateSettings);

            MailMessageFactory = new MailMessageFactory();

            ParsedBody = EmailTemplateFactory.ParseEmail(EmailTemplateName, Model);

            MailMessage = MailMessageFactory.BuildEmail(FromAddress, ToAddress, Subject, ParsedBody);
        }

        protected override void When()
        {
            try
            {
                using (var client = new SmtpClient())
                {
                    client.Send(MailMessage);
                }

                Result = true;
            }
            catch(Exception ex)
            {
                CaughtException = ex;
            }
        }

        [Test]
        public void ThenResultIsTrue()
        {
            Assert.IsTrue(Result);
        }
    }
}
