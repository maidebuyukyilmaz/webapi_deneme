using entities.Models;
using repositories.contracts;
using services.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services
{
    public class bookmanager : Ibookservice
    {
        private readonly Irepositorymanager _manager;

        public bookmanager(Irepositorymanager manager)
        {
            _manager = manager;
        }

        public Book createonebook(Book book)
        {
           _manager.Book.createonebook(book);
            _manager.save();
            return book;
        }

        public void deleteonebook(int id, bool trackchanges)
        {
            var entity=_manager.Book.getonebookbyid(id,trackchanges);
            if (entity == null) throw new Exception($"book with id:{id} could not found");
            _manager.Book.deleteonebook(entity);
            _manager.save();
        }

        public IEnumerable<Book> getallbooks(bool trackchanges)
        {
            return _manager.Book.getallbooks(trackchanges);
        }

        public Book getonebookyid(int id, bool trackchanges)
        {
         return _manager.Book.getonebookbyid(id,trackchanges);
        }

        public void updateonebook(int id, Book book,bool trackchanges)
        {

            var entity = _manager.Book.getonebookbyid(id, trackchanges);
            if (entity == null) throw new Exception($"book with id:{id} could not found");
            
            if(book is null) throw new ArgumentException(nameof(book)); 
          
            entity.Title = book.Title;
            entity.Prize = book.Prize;
            _manager.Book.update(entity);
            _manager.save();
        }
    }
}
