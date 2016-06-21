
using NUnit.Framework;
using Rhino.Mocks;

namespace Renibat.RazorEmail.Tests.FactoryTests.EmailTemplateFactoryTests.ParseEmailTests
{
    public class WhenParsingEmailWithModel : WhenTestingTheEmailTemplateFactory
    {
        protected string TemplateFileName { get; set; }
        protected string Result { get; set; }
        protected string TemplatePath { get; set; }
        protected string Model { get; set; }

        protected override void Given()
        {
            base.Given();

            TemplatePath = "../../EmailTemplates";
            TemplateFileName = "TestEmail.cshtml";
            Model = "this is string content";

            MoqEmailTemplateSettings.Stub(x => x.TemplatePath).Return(TemplatePath);
        }

        protected override void When()
        {
            Result = _EmailTemplateFactory.ParseEmail<string>(TemplateFileName, Model);
        }

        [Test]
        public void ThenExpectedStringIsReturned()
        {
            Assert.That(Result, Is.EqualTo(string.Format("<h1>Hello everyone!</h1><p>Content is: {0}</p>",Model)));
        }
    }
}
