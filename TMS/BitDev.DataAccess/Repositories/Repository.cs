﻿using System;
using System.Collections.Generic;

namespace BitDev.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class 
    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}