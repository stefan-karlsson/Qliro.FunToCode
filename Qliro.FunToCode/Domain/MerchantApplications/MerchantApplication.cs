using JetBrains.Annotations;
using Qliro.FunToCode.Domain._BuildingBlocks;
using Qliro.FunToCode.Domain.MerchantApplications.Events;

namespace Qliro.FunToCode.Domain.MerchantApplications;

public class MerchantApplication : EntityBase<MerchantApplication, MerchantApplicationId>, IAggregateRoot
{
  [UsedImplicitly(ImplicitUseKindFlags.Access)]
  private MerchantApplication()
  {
  }

  private MerchantApplication(MerchantApplicationId id, string name)
  {
    Id = id;
    Name = name;
  }

  public string Name { get; }

  public DateTimeOffset CreatedAt { get; } = TimeProvider.System.GetUtcNow();

  public MerchantApplicationStatus Status { get; private set; } = MerchantApplicationStatus.Created;

  public static MerchantApplication Create(string name)
  {
    var id = MerchantApplicationId.From(Guid.NewGuid());

    var merchantApplication = new MerchantApplication(id, name);
    
    merchantApplication.RegisterDomainEvent(new MerchantApplicationCreatedEvent(id));
    
    return merchantApplication;
  }

  public void StartApplication()
  {
    Status = MerchantApplicationStatus.Created;
  }
}