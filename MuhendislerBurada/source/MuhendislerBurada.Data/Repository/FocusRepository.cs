using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class FocusRepository: RepositoryBase<Focus>, IFocusRepository
        {
        public FocusRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IFocusRepository : IRepository<Focus>
    {
    }
}