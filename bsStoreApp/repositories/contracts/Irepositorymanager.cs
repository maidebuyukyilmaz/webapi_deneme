using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.contracts
{
   public interface Irepositorymanager
    {
        Ibookrepository Book { get; }
        void save();
    }
}
