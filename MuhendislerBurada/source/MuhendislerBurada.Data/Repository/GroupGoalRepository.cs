using MuhendislerBurada.Model.Models;
using MuhendislerBurada.Data.Infrastructure;


namespace MuhendislerBurada.Data.Repository
{
    public class GroupGoalRepository : RepositoryBase<GroupGoal>, IGroupGoalRepository
    {
        public GroupGoalRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupGoalRepository : IRepository<GroupGoal>
    {
    }
}
