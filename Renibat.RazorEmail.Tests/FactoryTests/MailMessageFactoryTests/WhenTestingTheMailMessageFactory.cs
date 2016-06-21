using NUnit.Framework;
using Renibat.RazorEmail.Factories;
using ReSystems.RazorEmail.Tests.Core;
using System;
using System.Net.Mail;

namespace Renibat.RazorEmail.Tests.FactoryTests.MailMessageFactoryTests
{
    public class WhenTestingTheMailMessageFactory : SpecBase
    {
        protected MailMessage Result { get; set; }
        protected MailMessageFactory _MailMessageFactory { get; set; }
        protected string To { get; set; }
        protected string From { get; set; }
        protected string Subject { get; set; }
        protected string Body { get; set; }

        protected override void Given()
        {
            base.Given();

            To = "rob.tabiner@re-systems.co.uk";
            From = "noreply@tests.com";
            Subject = "Email subject";
            Body = "<p>Some HTML</p>";

            _MailMessageFactory = new MailMessageFactory();
        }

        protected override void When()
        {
            Result = _MailMessageFactory.BuildEmail(From, To, Subject, Body);
        }

        [Test]
        public void ThenMailMessageFromAdressMatchesFrom()
        {
            Assert.That(Result.From.Address, Is.EqualTo(From));
        }

        [Test]
        public void ThenMailMessageToAdressMatchesTo()
        {
            Assert.That(Result.To[0].Address, Is.EqualTo(To));
        }

        [Test]
        public void ThenMailMessageSubjectMatchesSubject()
        {
            Assert.That(Result.Subject, Is.EqualTo(Subject));
        }

        [Test]
        public void ThenMailMessageBodyMatchesBody()
        {
            Assert.That(Result.Body, Is.EqualTo(Body));
        }

        [Test]
        public void TheIsBodyHtmlIsTrue()
        {
            Assert.IsTrue(Result.IsBodyHtml);
        }
    }
}
