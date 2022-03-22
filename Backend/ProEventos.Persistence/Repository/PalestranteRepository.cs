using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Models;
using ProEventos.Persistence.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Repository
{
    public class PalestranteRepository : IPalestranteRepository
    {
        private readonly DataContext _context;

        public PalestranteRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Palestrante[]> GetAllPalestrantesAsync()
        {

            IQueryable<Palestrante> query = _context.Palestrantes
                .Include(c => c.RedesSociais);
            query = query.OrderBy(e => e.Id);
            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestrantesByIdAsync(int palestranteId)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
                     .Include(e => e.RedesSociais);
            query = query.OrderBy(e => e.Id == palestranteId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome)
        {
            IQueryable<Palestrante> query = _context.Palestrantes
            .Include(e => e.RedesSociais);
            query = query.OrderBy(e => e.Id).Where(e => e.User.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();
        }
    }
}
