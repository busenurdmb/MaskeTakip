using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //ptt deyken sistem eczaneye döndü. çıplak bırakmak doğru değil
    //iyi bir geliştirici gelecekte nasıl bir talep gelecğini tahmin eden değil,geleckte bir şey geleceğini tahmin etmiş gibi kodlayan kişidir.
   public class PttManager:ISupplierService
    {
        //Dependency Injection->pttmanager'ın bağımlısı olduğu sınıf yerine o sınıfların interfaceni yazıyorum
        //field
        private IApplicantService _applicantService;
        //ne zaman lazım?-Bu class başladığında lazım
        //bu clasın başlaması constructor denen bir blogdur.
        public PttManager(IApplicantService applicantService)//Constructor(Oluşturucu) pttmanager new yapıldığında çalışır
        {
            //BEN IApplicationService bağımlıyım diyorum beni oluşturuudğun zaman bana parametre olarak birtane adayservici ver
            //fieldlerin _ çizgi ile başlama sebebi ctorda set etmemiz.
            _applicantService = applicantService;
            
        }
        //her kim IApplicationService kullanırsa bu adam onun referansını tutabiliyor.
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi.");
            }
        }
        //public void GiveMask(Person person)
        //{
        //    //BU sadece vatandaş için ve devlet dediki bundan sonra yabancı uyruklu kişlerde maske alabilir.
        //    //Eğer bir sınıf başka bir sınıfı kullanırken newliyorsa ileriye dönük yazılımda değişiklik talebi geldiğinde uygulama direnç gösterir (bunlar entity ler için gerçerli değil  ,bunlar iş sınıfı veri erişim sınıfı için geçerli)
        //    //Direnç göstermek ne demek Newlediniz personmanagera bağımlısınız demektir
        //    //yarın obürgün personmanager değilde devlet dediki bundan sonra kendi vatandaşım olmayana da maske vericem 
        //    //GiveMask tamamen vatandaşa bağımlı
        //    //bus sistem doğru bir sistem değil inşaat projesi gibi
        //    PersonManager personManager=new PersonManager();->tasarım deseni kullanıyoruz dependency ınjection
        //    if(personManager.CheckPerson(person))
        //    {
        //        Console.WriteLine(person.FirstName + " " + "için maske verildi");
        //    }
        //}
    }
}
