using repositories.contracts;
using services.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services
{
    public class servicemanager : Iservicemanager
    {

        private readonly Lazy<Ibookservice> _bookservice;
        public servicemanager(Irepositorymanager repositorymanager)
        {
            _bookservice = new Lazy<Ibookservice>(() => new bookmanager(repositorymanager));
        }
        public Ibookservice bookservice => _bookservice.Value;
    }
}
