using MuhendislerBurada.Data.Models;

namespace MuhendislerBurada.Data.Infrastructure
{
public class DatabaseFactory : Disposable, IDatabaseFactory
{
    private MuhendislerBuradaEntities dataContext;
    public MuhendislerBuradaEntities Get()
    {
        return dataContext ?? (dataContext = new MuhendislerBuradaEntities());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
