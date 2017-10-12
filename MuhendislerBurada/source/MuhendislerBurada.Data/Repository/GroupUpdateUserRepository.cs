using MuhendislerBurada.Model.Models;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    public class GroupUpdateUserRepository : RepositoryBase<GroupUpdateUser>, IGroupUpdateUserRepository
    {
        public GroupUpdateUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface IGroupUpdateUserRepository : IRepository<GroupUpdateUser>
    {
       
    }
}
