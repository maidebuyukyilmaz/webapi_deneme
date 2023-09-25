using repositories.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.Efcore
{
    public class repositorymanager : Irepositorymanager
    {
        private readonly Repositorycontext _context;
        private readonly Lazy<Ibookrepository> _bookrepository;

        public repositorymanager(Repositorycontext context)
        {
            _context = context;
            _bookrepository=new Lazy<Ibookrepository>(()=>new Bookrepository(_context));
        }

        public Ibookrepository Book =>_bookrepository.Value;

        public void save()
        {
          _context.SaveChanges();   
        }
    }
}
