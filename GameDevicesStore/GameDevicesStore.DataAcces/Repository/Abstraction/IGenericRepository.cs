﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevicesStore.DataAcces.Repository.Abstraction
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Delete(TEntity entity);
                                
        void Update(TEntity entity);

        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
