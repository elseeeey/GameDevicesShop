using GameDevicesStore.DataAcces.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.DataAcces.Repository.Implementation
{
    public class EfRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _set;

        public EfRepository(DbContext context)
        {
            _context = context;

            _set = _context.Set<TEntity>();
        }

        

        public void Create(TEntity entity)
        {
            _set.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            //Get entities from database, for example all devices
        
            return _set.AsEnumerable();
        }

        public TEntity GetById(int id)
        {
            return _set.Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
