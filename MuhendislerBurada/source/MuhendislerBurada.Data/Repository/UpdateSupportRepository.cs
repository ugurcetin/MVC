using System;
using MuhendislerBurada.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MuhendislerBurada.Data.Infrastructure;

namespace MuhendislerBurada.Data.Repository
{
    class UpdateSupportRepository : RepositoryBase<UpdateSupport>, IUpdateSupportRepository
    {
        public UpdateSupportRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IUpdateSupportRepository : IRepository<UpdateSupport>
    {
    }
}
