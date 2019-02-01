using ProjectTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DL
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ProjectContext context;
        private DbSet<T> _entities;

        public Repository()
        {
            context = ProjectContext.GetInstance;
            _entities = context.Set<T>();

        }

        public async Task CreateAsync(T typeToAdd)
        {
            _entities.Add(typeToAdd);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync<T>();
        }

        public async Task<T> GetAsync(int Id)
        {
            return await _entities.FindAsync(Id);
        }

        public async Task RemoveAsync(int Id)
        {
            var item = await _entities.FindAsync(Id);
            _entities.Remove(item);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int Id, T typeToUpdate)
        {
            var item = await _entities.FindAsync(Id);
            item = typeToUpdate;
            await context.SaveChangesAsync();
        }


        //public IDbSet<T> Entities
        //{
        //    get
        //    {
        //        if (_entities == null)
        //        {
        //            _entities = context.Set<T>();
        //        }

        //        return _entities;
        //    }
        //}



    }
}
