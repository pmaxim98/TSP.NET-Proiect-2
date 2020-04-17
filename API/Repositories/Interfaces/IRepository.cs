using MyPhotos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        bool Any(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> enumerable);

        void Update(T entity);

        void Update(T item, T initialEntity);

        void UpdateMultimediaChildren(Multimedia updateItem, Multimedia initialEntity);

        IEnumerable<T> Search(Expression<Func<T, bool>> predicate);

        IQueryable<T> Include<TEntity>(Expression<Func<T, TEntity>> predicate);

        T GetById(int id);

        IEnumerable<T> GetAll();
    }
}
