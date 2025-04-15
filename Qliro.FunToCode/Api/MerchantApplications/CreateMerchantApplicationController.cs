using JetBrains.Annotations;
using MediatR;
using Qliro.FunToCode.Application.Contracts;
using Qliro.FunToCode.Application.MerchantApplications.UseCases;
using Qliro.FunToCode.Application.MerchantApplications.UseCases.Create;

namespace Qliro.FunToCode.Api.MerchantApplications;

[UsedImplicitly]
public class CreateMerchantApplicationController : IEndpoint
{
  public static void MapEndpoint(IEndpointRouteBuilder endpoints)
  {
    endpoints.MapPost("/merchant-applications",
      async (CreateMerchantApplicationRequest request, IMediator mediator, CancellationToken ct) =>
      {
        var command = new CreateMerchantApplicationCommand(request.Name);

        var response = await mediator.Send(command, ct);

        return response != null
          ? Results.Ok(response)
          : Results.BadRequest();
      })
      .WithName("Create Merchant Application")
      .WithTags("Merchant Application")
      .WithOpenApi();
  }
}