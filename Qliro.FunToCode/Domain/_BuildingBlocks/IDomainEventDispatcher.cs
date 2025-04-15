namespace Qliro.FunToCode.Domain._BuildingBlocks;

public interface IDomainEventDispatcher
{
  Task DispatchAndClearEvents(IEnumerable<IHasDomainEvents> entitiesWithEvents);
}