using MediatR;

namespace Qliro.FunToCode.Domain._BuildingBlocks;

public abstract class DomainEventBase : INotification
{
  public DateTime OccurredAt { get; protected set; } = TimeProvider.System.GetUtcNow().DateTime;
}