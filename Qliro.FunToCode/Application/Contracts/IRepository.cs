using Ardalis.Specification;
using Qliro.FunToCode.Domain._BuildingBlocks;

namespace Qliro.FunToCode.Application.Contracts;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot;