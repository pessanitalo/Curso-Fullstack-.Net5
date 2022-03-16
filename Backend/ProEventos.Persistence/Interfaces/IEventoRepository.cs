using ProEventos.Domain.Models;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Interfaces
{
    public interface IEventoRepository
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema);
        Task<Evento[]> GetAllEventosAsync();
        Task<Evento> GetEventosByIdAsync(int eventoId);
    }
}
