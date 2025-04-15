using Qliro.FunToCode.Domain._BuildingBlocks;

namespace Qliro.FunToCode.Domain.MerchantApplications.Events;

public sealed class MerchantApplicationCreatedEvent(MerchantApplicationId id) : DomainEventBase
{
  public Guid Id { get; init; } = id.Value;
}