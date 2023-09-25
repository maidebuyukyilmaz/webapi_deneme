using entities.Models;
using repositories.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace repositories.Efcore
{
    public class Bookrepository : RepositoryBase<Book>, Ibookrepository
    {
        public Bookrepository(Repositorycontext context) : base(context)
        {
        }

        public void createonebook(Book book)
       => create(book);
        public void deleteonebook(Book book)
        =>delete(book);
        public IQueryable<Book> getallbooks(bool trackchanges)
        => findall(trackchanges);

        public Book getonebookbyid(int id, bool trackchanges)
       => findbycondition(b => b.Id.Equals(id), trackchanges).SingleOrDefault();

        public void updateeonebook(Book book)
       =>update(book);  
    }
}
