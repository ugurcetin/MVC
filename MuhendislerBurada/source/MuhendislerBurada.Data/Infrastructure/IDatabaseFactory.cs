using System;
using MuhendislerBurada.Data.Models;

namespace MuhendislerBurada.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        MuhendislerBuradaEntities Get();
    }
}
