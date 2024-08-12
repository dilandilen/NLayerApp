﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GettAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>>expression);
        Task AddAsync(T entity);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        void Update(T entity);
        void Remove(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);

    }
}
