using Qliro.FunToCode.Application.Contracts;
using ServiceScan.SourceGenerator;

namespace Qliro.FunToCode.Configuration.Endpoints;

public static partial class EndpointRouteBuilder
{
  [GenerateServiceRegistrations(AssignableTo = typeof(IEndpoint), CustomHandler = nameof(MapEndpoint))]
  public static partial IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder endpoints);

  private static void MapEndpoint<T>(IEndpointRouteBuilder endpoints) where T : IEndpoint
  {
    T.MapEndpoint(endpoints);
  }
}