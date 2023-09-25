using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace repositories.contracts
{
    public interface Irepositorybase<T>
    {
        IQueryable<T> findall(bool trackchanges);
        IQueryable<T> findbycondition(Expression<Func<T,bool>> expression, bool trackchanges);
        void create(T entity);
        void update(T entity);  
        void delete(T entity);


    }
}
