namespace Qliro.FunToCode.Application.Contracts;

public interface IEmailSender
{
    Task SendApplicationUrl(string email, string url);
}
