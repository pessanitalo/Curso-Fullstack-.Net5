using ProEventos.Domain.Identity;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Interfaces
{
    public interface IUserRepository : IGenericRepository
    {
        Task<IEnumerable<User>> GetUserAsync();
        Task<User> GetUserIdAsync(int id);
        Task<User> GetUserNameAsync(string username);
    }
}
