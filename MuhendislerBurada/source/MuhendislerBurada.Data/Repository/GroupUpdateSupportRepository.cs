using System;
using MuhendislerBurada.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    class GroupUpdateSupportRepository : RepositoryBase<GroupUpdateSupport>, IGroupUpdateSupportRepository
    {
        public GroupUpdateSupportRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupUpdateSupportRepository : IRepository<GroupUpdateSupport>
    {
    }
}
