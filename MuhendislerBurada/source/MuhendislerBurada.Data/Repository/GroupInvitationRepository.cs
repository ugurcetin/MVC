using MuhendislerBurada.Model.Models;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    public class GroupInvitationRepository : RepositoryBase<GroupInvitation>, IGroupInvitationRepository
    {
        public GroupInvitationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupInvitationRepository : IRepository<GroupInvitation>
    {
    }
}
