using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //dağıtıcı
    public interface ISupplierService
    {
        void GiveMask(Person person);
    }
}
