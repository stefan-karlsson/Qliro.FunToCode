using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Qliro.FunToCode.Domain._BuildingBlocks;
using Qliro.FunToCode.Domain.MerchantApplications;

namespace Qliro.FunToCode.Infrastructure.Persistence;

public class AppDbContext(
  DbContextOptions<AppDbContext> options,
  IDomainEventDispatcher? dispatcher) : DbContext(options)
{
  public DbSet<MerchantApplication> MerchantApplications => Set<MerchantApplication>();
  
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
  {
    var result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    if (dispatcher == null) return result;

    var entitiesWithEvents = ChangeTracker.Entries<HasDomainEventsBase>()
      .Select(e => e.Entity)
      .Where(e => e.DomainEvents.Count != 0)
      .ToArray();

    await dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges() => SaveChangesAsync().GetAwaiter().GetResult();
}