﻿using _2013204637_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //public void Add(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddRange(IEnumerable<TEntity> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public TEntity Get(int? id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<TEntity> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateRange(IEnumerable<TEntity> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRange(IEnumerable<TEntity> entities)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
