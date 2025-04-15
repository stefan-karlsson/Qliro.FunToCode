namespace Qliro.FunToCode.Domain._BuildingBlocks;

public abstract class EntityBase<T, TId> : HasDomainEventsBase
  where T : EntityBase<T, TId>
{
  public TId Id { get; set; } = default!;
}