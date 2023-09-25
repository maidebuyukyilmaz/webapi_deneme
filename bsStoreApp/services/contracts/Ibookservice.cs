using entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.contracts
{
    public interface Ibookservice
    {
        IEnumerable<Book> getallbooks(bool trackchanges);
        Book getonebookyid(int id,bool trackchanges);
        Book createonebook(Book book);
        void updateonebook(int id,Book book,bool trackchanges);   
        void deleteonebook(int id,bool trackchanges);
    }
}
