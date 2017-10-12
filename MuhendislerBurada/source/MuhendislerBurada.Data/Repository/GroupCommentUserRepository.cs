using MuhendislerBurada.Model.Models;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    public class GroupCommentUserRepository : RepositoryBase<GroupCommentUser>, IGroupCommentUserRepository
    {
        public GroupCommentUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface IGroupCommentUserRepository : IRepository<GroupCommentUser>
    {
        
    }
}
