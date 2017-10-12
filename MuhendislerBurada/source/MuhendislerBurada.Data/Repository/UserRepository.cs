using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Data.Models;
using MuhendislerBurada.Model.Models;
using System;
using System.Linq.Expressions;
namespace MuhendislerBurada.Data.Repository
{
    public class UserRepository: RepositoryBase<ApplicationUser>, IUserRepository
        {
        public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }        
        }
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        
    }
}