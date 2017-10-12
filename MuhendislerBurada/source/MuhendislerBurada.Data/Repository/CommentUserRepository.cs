using MuhendislerBurada.Model.Models;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    public class CommentUserRepository : RepositoryBase<CommentUser>, ICommentUserRepository
    {
        public CommentUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface ICommentUserRepository : IRepository<CommentUser>
    {
        
    }
}
