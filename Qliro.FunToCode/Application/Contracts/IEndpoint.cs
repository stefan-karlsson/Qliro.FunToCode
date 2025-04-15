namespace Qliro.FunToCode.Application.Contracts;

public interface IEndpoint
{
  abstract static void MapEndpoint(IEndpointRouteBuilder endpoints);
}