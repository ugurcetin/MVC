using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class GroupUpdateRepository : RepositoryBase<GroupUpdate>, IGroupUpdateRepository
    {
        public GroupUpdateRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupUpdateRepository : IRepository<GroupUpdate>
    {
    }
}