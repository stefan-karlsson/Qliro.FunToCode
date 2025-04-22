using MediatR;
using Qliro.FunToCode.Domain.MerchantApplications.Events;

namespace Qliro.FunToCode.Application.MerchantApplications.Handlers;

public class MerchantApplicationCreatedHandler : INotificationHandler<MerchantApplicationCreatedEvent>
{
  public async Task Handle(MerchantApplicationCreatedEvent @event, CancellationToken cancellationToken)
  {
    // #error Assignment starts here.
  }
}