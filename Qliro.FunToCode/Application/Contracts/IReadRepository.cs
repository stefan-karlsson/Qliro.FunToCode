using Ardalis.Specification;
using Qliro.FunToCode.Domain._BuildingBlocks;

namespace Qliro.FunToCode.Application.Contracts;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot;