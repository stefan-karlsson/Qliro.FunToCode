using MediatR;

namespace Qliro.FunToCode.Application.MerchantApplications.UseCases.Create;

public record CreateMerchantApplicationCommand(string Name) : IRequest<MerchantApplicationResponse>;