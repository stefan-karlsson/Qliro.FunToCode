using MediatR;
using Qliro.FunToCode.Domain._BuildingBlocks;
using ServiceScan.SourceGenerator;

namespace Qliro.FunToCode.Infrastructure.Processing;

public static partial class ProcessingModule
{
  public static void AddProcessingModule(this IServiceCollection services)
  {
    services
      .AddTransient<IMediator, Mediator>()
      .AddScoped<IDomainEventDispatcher, DomainEventDispatcher>()
      .AddMediatRHandlers();
  }

  [GenerateServiceRegistrations(AssignableTo = typeof(IRequestHandler<,>), Lifetime = ServiceLifetime.Transient)]
  [GenerateServiceRegistrations(AssignableTo = typeof(INotificationHandler<>), Lifetime = ServiceLifetime.Transient)]
  private static partial IServiceCollection AddMediatRHandlers(this IServiceCollection services);
}