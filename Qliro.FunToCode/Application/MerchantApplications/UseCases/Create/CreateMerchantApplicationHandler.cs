using MediatR;
using Qliro.FunToCode.Application.Contracts;
using Qliro.FunToCode.Domain.MerchantApplications;

namespace Qliro.FunToCode.Application.MerchantApplications.UseCases.Create;

public class CreateMerchantApplicationHandler(IRepository<MerchantApplication> repository)
  : IRequestHandler<CreateMerchantApplicationCommand, MerchantApplicationResponse>
{
  public async Task<MerchantApplicationResponse> Handle(CreateMerchantApplicationCommand request,
    CancellationToken cancellationToken)
  {
    var merchantApplication = MerchantApplication.Create(request.Name, request.Email);

    var entity = await repository.AddAsync(merchantApplication, cancellationToken);

    return new MerchantApplicationResponse(entity.Id.Value);
  }
}