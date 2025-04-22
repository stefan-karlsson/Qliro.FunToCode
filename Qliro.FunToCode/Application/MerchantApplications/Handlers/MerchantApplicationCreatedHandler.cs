using MediatR;
using Qliro.FunToCode.Application.Contracts;
using Qliro.FunToCode.Domain.MerchantApplications.Events;

namespace Qliro.FunToCode.Application.MerchantApplications.Handlers;

public class MerchantApplicationCreatedHandler(IEmailSender emailSender) : INotificationHandler<MerchantApplicationCreatedEvent>
{

  public async Task Handle(MerchantApplicationCreatedEvent @event, CancellationToken cancellationToken)
  {
    emailSender.SendApplicationUrl(@event.Email, $"https://nocode.platform.com/{@event.Id}");
    
    // #error Assignment starts here.
  }
}