using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class GoalStatusRepository : RepositoryBase<GoalStatus>, IGoalStatusRepository
    {
        public GoalStatusRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGoalStatusRepository : IRepository<GoalStatus>
    {
    }
}