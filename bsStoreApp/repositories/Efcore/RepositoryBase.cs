using Microsoft.EntityFrameworkCore;
using repositories.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.Efcore
{
    public abstract class RepositoryBase<T> : Irepositorybase<T>
        where T:class
    {
        protected readonly Repositorycontext _context;

        public RepositoryBase(Repositorycontext context)
        {
            _context = context;
        }

        public void create(T entity)
        =>_context.Set<T>().Add(entity);
        public void delete(T entity)
       =>_context.Set<T>().Remove(entity);

        public IQueryable<T> findall(bool trackchanges)
       => !trackchanges ?
            _context.Set<T>().AsNoTracking() :
        _context.Set<T>();

        public IQueryable<T> findbycondition(System.Linq.Expressions.Expression<Func<T, bool>> expression, bool trackchanges)
        => !trackchanges ?
            _context.Set<T>().Where(expression).AsNoTracking() :
            _context.Set<T>().Where(expression);


        public void update(T entity)
       =>_context.Set<T>().Update(entity);
    }
}
