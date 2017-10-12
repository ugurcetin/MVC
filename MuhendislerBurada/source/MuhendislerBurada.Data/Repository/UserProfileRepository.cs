using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Data.Repository
{
    public class UserProfileRepository : RepositoryBase<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IUserProfileRepository : IRepository<UserProfile>
    {
    }
}
