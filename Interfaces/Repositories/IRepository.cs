using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CommunityProApp.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        T Get(Guid id);
        T Get(string name);
        IEnumerable<T> Get();
        List<T> Get(IList<Guid> ids);
        T Get(Expression<Func<T, bool>> expression);
        
        IList<T> GetAll(Expression<Func<T, bool>> expression);
        bool Exists(Guid id);
        bool Exists(Expression<Func<T, bool>> expression);
        IEnumerable<T> Create(IEnumerable<T> entities);
        IQueryable<T> Query();
        int SaveChanges();
    }
}
