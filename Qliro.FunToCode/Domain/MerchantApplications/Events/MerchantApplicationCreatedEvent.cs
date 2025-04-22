using Qliro.FunToCode.Domain._BuildingBlocks;

namespace Qliro.FunToCode.Domain.MerchantApplications.Events;

public sealed class MerchantApplicationCreatedEvent(MerchantApplicationId id, string email) : DomainEventBase
{
  public Guid Id { get; init; } = id.Value;

  public string Email { get; init; } = email;
}