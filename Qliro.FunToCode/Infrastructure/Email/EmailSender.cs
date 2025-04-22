using Qliro.FunToCode.Application.Contracts;

namespace Qliro.FunToCode.Infrastructure.Email;

public class EmailSender(ILogger<EmailSender> logger) : IEmailSender
{
    public Task SendApplicationUrl(string email, string url)
    {
        logger.LogInformation("Sending email to {Email} with URL: {Url}", email, url);
        
        // In a real application, you would use an SMTP client or an email service provider here.
        return Task.CompletedTask;
    }
}
