using ProEventos.Application.Dtos;
using System.Threading.Tasks;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {

        Task<EventoDto> AddEventos(EventoDto model);
        Task<EventoDto> UpdateEventos(int eventoId, EventoDto model);
        Task<bool> deleteEventos(int eventoId);

        Task<EventoDto[]> GetAllEventosByTemaAsync(string tema);
        Task<EventoDto[]> GetAllEventosAsync();
        Task<EventoDto> GetEventosByIdAsync(int eventoId);
    }
}
