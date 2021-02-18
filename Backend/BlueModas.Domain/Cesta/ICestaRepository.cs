using System;
using System.Threading.Tasks;

namespace BlueModas.Domain.Cesta
{
    public interface ICestaRepository
    {
        Task Create(Cesta cesta);
        Task Update(Cesta cesta);
        Task Delete(Cesta cesta);
        Task<Cesta> GetById(Guid id);
    }
}