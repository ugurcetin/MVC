using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class UpdateRepository: RepositoryBase<Update>, IUpdateRepository
        {
        public UpdateRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IUpdateRepository : IRepository<Update>
    {
    }
}