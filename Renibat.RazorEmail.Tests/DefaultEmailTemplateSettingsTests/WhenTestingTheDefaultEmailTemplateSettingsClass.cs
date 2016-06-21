using NUnit.Framework;
using ReSystems.RazorEmail.Tests.Core;
using System;

namespace Renibat.RazorEmail.Tests.DefaultEmailTemplateSettingsTests
{
    public class WhenTestingTheDefaultEmailTemplateSettingsClass : SpecBase
    {
        protected DefaultEmailTemplateSettings _DefaultEmailTemplateSettings { get; set; }
        protected string Result { get; set; }

        protected override void Given()
        {
            base.Given();

            _DefaultEmailTemplateSettings = new DefaultEmailTemplateSettings();
        }

        protected override void When()
        {
            Result = _DefaultEmailTemplateSettings.TemplatePath;
        }

        [Test]
        public void ThenResultContainsTheProvidedEmailTemplatesPath()
        {
            Assert.That(Result.Contains("EmailTemplates"));
        }
    }
}
