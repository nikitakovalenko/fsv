using Fsv.Common.Entities;

namespace Fsv.Common.Dal.Abstraction;

public interface IRepository<I>
    where I : EntityWithId, new()
{
    I GetById(long id);
    IQueryable<I> GetAsQueryable();
    void Create(I entity);
    void Update(I entity);
}
