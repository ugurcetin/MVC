using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class SecurityTokenRepository: RepositoryBase<SecurityToken>, ISecurityTokenRepository
        {
        public SecurityTokenRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface ISecurityTokenRepository : IRepository<SecurityToken>
    {
    }
}