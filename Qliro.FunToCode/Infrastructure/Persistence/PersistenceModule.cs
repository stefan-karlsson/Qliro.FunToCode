using Microsoft.EntityFrameworkCore;
using Qliro.FunToCode.Application.Contracts;
using ServiceScan.SourceGenerator;

namespace Qliro.FunToCode.Infrastructure.Persistence;

public static partial class PersistenceModule
{
  public static void AddPersistenceModule(this IServiceCollection services)
  {
    services
      .AddRepositories();
    
    services.AddDbContext<AppDbContext>(cfg =>
    {
      cfg.UseInMemoryDatabase("MerchantApplications");
    });
  }
  
  [GenerateServiceRegistrations(AssignableTo = typeof(IRepository<>), Lifetime = ServiceLifetime.Scoped)]
  [GenerateServiceRegistrations(AssignableTo = typeof(IReadRepository<>), Lifetime = ServiceLifetime.Scoped)]
  private static partial IServiceCollection AddRepositories(this IServiceCollection services);

}