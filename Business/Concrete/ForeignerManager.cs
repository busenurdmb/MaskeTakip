using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        //bir projede ne kadar if varsa o proje o kadar yazılım geliştirme prensiplerinden uzaktır deriz.
        //Sonarqube->yazılım kalite ölçüm aracı
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            //yabancı kuralı buraya
            return true;
        }

        public List<Person> Getlist()
        {
            throw new NotImplementedException();
        }
    }
}
