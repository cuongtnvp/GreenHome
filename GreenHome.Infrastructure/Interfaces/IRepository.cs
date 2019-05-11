using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GreenHome.Infrastructure.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"> class entity </typeparam>
    /// <typeparam name="K"> type of data </typeparam>
    public interface IRepository<T,K> where T:class
    {
        T FindById(K id, params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="preduicate">Return True False</param>
        /// <param name="includeProperties">Including properties from orther table</param>
        /// <returns></returns>
        T FindSingle(Expression<Func<T, bool>> preduicate, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Find All with condition and take out infor from other table
        /// </summary>
        /// <param name="preduicate"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IQueryable<T> FindAll(Expression<Func<T, bool>> preduicate,params Expression<Func<T, object>>[] includeProperties);
        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        void Remove(K id);

        void RemoveMultiple(List<T> entities);
    }
}
