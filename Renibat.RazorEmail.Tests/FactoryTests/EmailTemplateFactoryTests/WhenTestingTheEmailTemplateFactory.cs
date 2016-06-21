using Renibat.RazorEmail.Factories;
using ReSystems.RazorEmail.Tests.Core;
using Rhino.Mocks;

namespace Renibat.RazorEmail.Tests.FactoryTests.EmailTemplateFactoryTests
{
    public abstract class WhenTestingTheEmailTemplateFactory : SpecBase
    {
        protected EmailTemplateFactory _EmailTemplateFactory { get; set; }
        protected IEmailTemplateSettings MoqEmailTemplateSettings { get; set; }

        protected override void Given()
        {
            base.Given();

            MoqEmailTemplateSettings = MockRepository.GenerateMock<IEmailTemplateSettings>();

            _EmailTemplateFactory = new EmailTemplateFactory(MoqEmailTemplateSettings);
        }
    }
}
