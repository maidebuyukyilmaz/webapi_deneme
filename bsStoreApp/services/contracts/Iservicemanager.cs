using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace services.contracts
{
   public interface Iservicemanager
    {

        Ibookservice bookservice { get; }
    }
}
