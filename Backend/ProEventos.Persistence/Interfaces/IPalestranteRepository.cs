using ProEventos.Domain.Models;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Interfaces
{
    public interface IPalestranteRepository
    {
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome);
        Task<Palestrante[]> GetAllPalestrantesAsync();
        Task<Palestrante> GetPalestrantesByIdAsync(int palestranteId);
    }
}
