using Ardalis.Specification.EntityFrameworkCore;
using Qliro.FunToCode.Application.Contracts;
using Qliro.FunToCode.Domain._BuildingBlocks;

namespace Qliro.FunToCode.Infrastructure.Persistence;

public class EfRepository<T>(AppDbContext dbContext) :
  RepositoryBase<T>(dbContext), IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot;