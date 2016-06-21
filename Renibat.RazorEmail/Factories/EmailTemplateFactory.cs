using System.IO;
using RazorEngine;
using Renibat.RazorEmail.Extensions;

namespace Renibat.RazorEmail.Factories
{
    public class EmailTemplateFactory : IEmailTemplateFactory
    {
        private readonly IEmailTemplateSettings _emailTemplateSettings;

        public EmailTemplateFactory(IEmailTemplateSettings emailTemplateSettings)
        {
            _emailTemplateSettings = emailTemplateSettings;
        }

        public string ParseEmail(string templateFilename)
        {
            var templateContent = GetTemplateContent(templateFilename);

            return Razor.Parse(templateContent);
        }
        public string ParseEmail<TModel>(string templateFilename, TModel model)
        {
            var templateContent = GetTemplateContent(templateFilename);

            return Razor.Parse<TModel>(templateContent, model);
        }

        private string GetTemplateContent(string templateFilename)
        {
            var templatePath = Path.Combine(_emailTemplateSettings.TemplatePath, templateFilename);

            return templatePath.ReadFilePathContentToString();
        }
    }
}
