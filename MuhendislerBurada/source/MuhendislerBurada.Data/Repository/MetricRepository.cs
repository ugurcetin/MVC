using MuhendislerBurada.Data.Infrastructure;
using MuhendislerBurada.Model.Models;
namespace MuhendislerBurada.Data.Repository
{
    public class MetricRepository: RepositoryBase<Metric>, IMetricRepository
        {
        public MetricRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IMetricRepository : IRepository<Metric>
    {
    }
}