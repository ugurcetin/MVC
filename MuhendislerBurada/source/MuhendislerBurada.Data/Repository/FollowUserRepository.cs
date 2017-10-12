using MuhendislerBurada.Model.Models;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    public class FollowUserRepository : RepositoryBase<FollowUser>, IFollowUserRepository
    {
        public FollowUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        //public IEnumerable<User> SearchUserForGroup(string searchString, int groupId)
        //{

        //}
    }
    public interface IFollowUserRepository : IRepository<FollowUser>
    {
        //IEnumerable<User> SearchUserForGroup(string searchString, int groupId);
    }
}
