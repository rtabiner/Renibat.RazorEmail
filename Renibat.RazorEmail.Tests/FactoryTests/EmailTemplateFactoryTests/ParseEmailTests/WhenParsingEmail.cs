﻿
using NUnit.Framework;
using Rhino.Mocks;

namespace Renibat.RazorEmail.Tests.FactoryTests.EmailTemplateFactoryTests.ParseEmailTests
{
    public class WhenParsingEmail : WhenTestingTheEmailTemplateFactory
    {
        protected string TemplateFileName { get; set; }
        protected string Result { get; set; }
        protected string TemplatePath { get; set; }

        protected override void Given()
        {
            base.Given();

            TemplatePath = "../../EmailTemplates";
            TemplateFileName = "TestEmail.cshtml";

            MoqEmailTemplateSettings.Stub(x => x.TemplatePath).Return(TemplatePath);
        }

        protected override void When()
        {
            Result = _EmailTemplateFactory.ParseEmail(TemplateFileName);
        }

        [Test]
        public void ThenExpectedStringIsReturned()
        {
            Assert.That(Result, Is.EqualTo("<h1>Hello everyone!</h1><p>Content is: </p>"));
        }
    }
}
