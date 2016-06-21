using Renibat.RazorEmail.Wrappers;
using ReSystems.RazorEmail.Tests.Core;

namespace Renibat.RazorEmail.Tests.WrapperTests.SmtpClientWrapperTests
{
    public abstract class WhenTestingTheSmtpClientWrapper : SpecBase
    {
        protected SmtpClientWrapper _SmtpClientWrapper { get; set; }

        protected override void Given()
        {
            base.Given();

            _SmtpClientWrapper = new SmtpClientWrapper();            
        }
    }
}
