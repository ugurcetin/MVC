using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class FollowRequestRepository : RepositoryBase<FollowRequest>, IFollowRequestRepository
    {
        public FollowRequestRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IFollowRequestRepository : IRepository<FollowRequest>
    {
    }
}