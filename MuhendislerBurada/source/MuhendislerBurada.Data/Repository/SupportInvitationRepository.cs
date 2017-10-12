using MuhendislerBurada.Model.Models;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    public class SupportInvitationRepository : RepositoryBase<SupportInvitation>, ISupportInvitationRepository
    {
        public SupportInvitationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface ISupportInvitationRepository : IRepository<SupportInvitation>
    {
    }
}
