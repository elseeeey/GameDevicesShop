using GameDevicesStore.DataAcces.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.DataAcces.Repository.Implementation
{
    public class FileRepository<TEntity> : IGenericRepository<TEntity> where TEntity :class
    {
        public void Create(TEntity entity)
        {

            var type = entity.GetType();
            var props = type.GetProperties();
            using (StreamWriter sw = new StreamWriter("D:\\games.txt"))
            {
                foreach(var prop in props)
                {
                    var value = prop.GetValue(entity);
                    sw.WriteLine(value);
                }
            }
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return null;
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
