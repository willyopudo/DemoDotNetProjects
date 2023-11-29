using RepositoryAndUnitOfWorkDemo.Models;
using RepositoryAndUnitOfWorkDemo.UnitOfWork;

namespace RepositoryAndUnitOfWorkDemo.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(IUnitOfWork unitOfwork) : base(unitOfwork)
        {
        }
    }
}
