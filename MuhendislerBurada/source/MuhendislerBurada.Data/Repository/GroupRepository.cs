using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Data.Repository
{
    public class GroupRepository:RepositoryBase<Group>, IGroupRepository
        {
        public GroupRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IGroupRepository : IRepository<Group>
    {
    }
   
}
