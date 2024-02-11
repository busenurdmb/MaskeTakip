using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Entities-> veri tabanı nesnelerimizi ve diğer nesnelerimizi tutucak olan  katman
    //internal-> aynı derleme içindeki diğer tüm türler erişebilir
    //person -> maske takibindeki vatandaşlar
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DataOfBirthYear { get; set; }
    }
}
