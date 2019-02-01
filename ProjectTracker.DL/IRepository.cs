using ProjectTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DL
{
    public interface IRepository<T>  where T : BaseEntity 
    {
        Task CreateAsync(T typeToAdd);
        Task UpdateAsync(int Id, T typeToUpdate);
        Task RemoveAsync(int Id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int Id);

    }
}
