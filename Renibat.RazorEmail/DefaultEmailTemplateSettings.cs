using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace Renibat.RazorEmail
{
    public class DefaultEmailTemplateSettings : IEmailTemplateSettings
    {
        private string _templatePath;

        public string TemplatePath
        {
            get 
            {
                if (!string.IsNullOrEmpty(_templatePath))
                    return _templatePath;

                var basePath = GetAssemblyDirectory();
                var emailTemplatePath = ConfigurationManager.AppSettings["EmailTemplatePath"];

                _templatePath = Path.Combine(basePath, emailTemplatePath);

                return _templatePath;
            }
        }

        private static string GetAssemblyDirectory()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var dir = new DirectoryInfo(Uri.UnescapeDataString(uri.Path));
            return dir.Parent.FullName;
        }
    }
}
