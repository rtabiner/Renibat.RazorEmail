======
Step 1
======
Register following dependencies with MVC using whatever dependency resolver you're using

- IEmailTemplateFactory -> EmailTemplateFactory
- IEmailTemplateSettings -> DefaultEmailTemplateSettings
- IMailMessageFactory -> MailMessageFactory

NOTE: The DefaultEmailTemplateSettings uses whatever value is provided in the appSetting "EmailTemplatePath". This should be a relative path to the root of your project

======
Step 2
======
Use IEmailTemplateFactory as a parameter in your controller constructor for creating the template.
Use IMailMessageFactory as a parameter in your controller constructor for building a mail message.

=====
Usage
=====

_emailTemplateFactory.ParseEmail("template_filename.cshtml")
_emailTemplateFactory.ParseEmail<TModel>("template_filename.cshtml", model (of type TModel)



Example code
============

var emailBody = _emailTemplateFactory.ParseEmail("Test.cshtml", "Ball bags");

var mailMessage = _mailMessageFactory.BuildEmail("noreply@test.com", "rob.tabiner@re-systems.co.uk", "TESTING", emailBody);

var emailResult = _smtpClientWrapper.SendMailMessage(mailMessage);

