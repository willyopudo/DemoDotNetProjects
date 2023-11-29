using Microsoft.EntityFrameworkCore;

namespace RepositoryAndUnitOfWorkDemo.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        public Task SaveChangesAsync();
    }
}
