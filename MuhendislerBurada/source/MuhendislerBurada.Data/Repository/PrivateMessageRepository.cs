using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhendislerBurada.Data.Repository {

    public class PrivateMessageRepository : RepositoryBase<PrivateMessage>, IPrivateMessageRepository {

        public PrivateMessageRepository(IDatabaseFactory databaseFactory) : base(databaseFactory) {
        }

    }

    public interface IPrivateMessageRepository : IRepository<PrivateMessage> {
    }
}
