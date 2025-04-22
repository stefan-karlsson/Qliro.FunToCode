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

  private MerchantApplication(MerchantApplicationId id, string name, string email)
  {
    Id = id;
    Name = name;
    Email = email;
  }

  public string Name { get; }

  public string Email { get; }
  
  public DateTimeOffset CreatedAt { get; } = TimeProvider.System.GetUtcNow();

  public MerchantApplicationStatus Status { get; private set; } = MerchantApplicationStatus.Created;

  public static MerchantApplication Create(string name, string email)
  {
    var id = MerchantApplicationId.From(Guid.NewGuid());

    var merchantApplication = new MerchantApplication(id, name, email);
    
    merchantApplication.RegisterDomainEvent(new MerchantApplicationCreatedEvent(id, email));
    
    return merchantApplication;
  }
}