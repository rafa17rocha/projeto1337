﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EY.Reinf.Infra.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity AddReturn(TEntity entity);

        void Add(TEntity entity);

        void AddAll(List<TEntity> entity);

        void Edit(TEntity entity);

        void Delete(TEntity entity);

        void DeleteAll(Expression<Func<TEntity, bool>> filter = null);

        List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        TEntity GetOne(TEntity entity);
    }
}
