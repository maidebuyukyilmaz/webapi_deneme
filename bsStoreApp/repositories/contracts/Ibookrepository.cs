using entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.contracts
{
    public interface Ibookrepository:Irepositorybase<Book>
    {
        IQueryable<Book> getallbooks(bool trackchanges);
        Book getonebookbyid(int id,bool trackchanges);
        void createonebook(Book book);  
        void updateeonebook(Book book);  
        void deleteonebook(Book book);
    }
}
