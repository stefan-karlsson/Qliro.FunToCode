using Qliro.FunToCode.Application.Contracts;
using Qliro.FunToCode.Infrastructure.Email;

namespace Qliro.FunToCode.Infrastructure.Persistence;

public static partial class EmailModule
{
    public static void AddEmailModule(this IServiceCollection services)
    {
        services
            .AddScoped<IEmailSender, EmailSender>();
    }
}