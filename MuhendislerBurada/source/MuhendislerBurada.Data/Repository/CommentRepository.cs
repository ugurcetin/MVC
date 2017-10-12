using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class CommentRepository: RepositoryBase<Comment>, ICommentRepository
        {
        public CommentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }
      
        }
    public interface ICommentRepository : IRepository<Comment>
    {    

    }
}