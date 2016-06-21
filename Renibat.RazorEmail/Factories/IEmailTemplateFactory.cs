namespace Renibat.RazorEmail.Factories
{
    public interface IEmailTemplateFactory
    {
        string ParseEmail(string templateFilename);
        string ParseEmail<TModel>(string templateFilename, TModel model);
    }
}
