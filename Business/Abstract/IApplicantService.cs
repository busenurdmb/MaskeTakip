using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //interface?->
    //kelime anlamı arayüz 
    //interface içerisine method yazamassın,method imzası bulundurabilirsin.
    //sadece imzayı tutmak için  interfaca yapmıyoruz !!!
    //yazılımda bağımlılığı çözmenin teknikleri
    //eğer bu yapıyı oluşturmasaydım PersonManager da yabancı uyruklular için bir manager yazamıyacaktım 
    //interface=Belli metot imzalarını barındırırlar birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar.
    //yani yabancı uyrukuluyu farklı check ederim onun kuralları farklı başvurabilir listeleyebilirm check edebilirim.vatandaşı farklı
    //her kim IApplicationService kullanırsa bu adam onun referansını tutabiliyor.
    //İnterfaceler newlenemz
    public interface IApplicantService
    {
        void ApplyForMask(Person person);
        List<Person> Getlist();
        bool CheckPerson(Person person);
       
        
    }
}
